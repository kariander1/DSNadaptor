using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using DSNadaptor.Properties;
using System.Net.Http;
using System.Web;
using System.Reflection;
namespace DSNadaptor
{


   
    public partial class Form_Main : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;
        public int default_delivery_delay;
        public int bytesToMiliSecRatio;
        private string serverToPing;


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        
        //panel_
        private Config AppConfig;
        //    private QuerySession qs;
        private List<UDP> udpDests;
        private static bool isRunning = false;
        Queue<byte[]> dataStack;
        List<Thread> samplingThreads;
        OpenAM openAMsession;
        Thread udpThread;
        bool manual = false;
        public static bool initialize = true;
        public Form_Main()
        {
            InitializeComponent();

            #region GUI
            FadeIn(this, 25);
            tabControl_tabs.Appearance = TabAppearance.FlatButtons;
            tabControl_tabs.ItemSize = new Size(0, 1);
            tabControl_tabs.SizeMode = TabSizeMode.Fixed;


            pictureBox_web2adapt.Visible = false;
            pictureBox_adapt2scc.Visible = false;
            pictureBox_adapt2web.Visible = false;

            display_manual_controls(manual);

            #endregion
            addToLog("Loading configuraiton...");
            AppConfig = new Config();
            displayConfigData();
            addToLog("Loading configuraiton done");

            default_delivery_delay = AppConfig.DelayDelivery;
            bytesToMiliSecRatio = AppConfig.ByteRatio;

            if (AppConfig.UDPdests.Count > 0)
                textBox_destUDPip.Text = AppConfig.UDPdests[0];
            if (AppConfig.UDPports.Count > 0)
                textBox_UDPport.Text = AppConfig.UDPports[0].ToString();

            if (AppConfig.ProxyServerUsage)
            {
                serverToPing = AppConfig.ProxyServerAddress;
                label_ping.Text = "Ping Proxy";
            }
            else
            {
                serverToPing = AppConfig.WebTLMaddress;
            }
            foreach (string queryServer in AppConfig.QueryServers)
            {
                comboBox_QueryServers.Items.Add(queryServer);
                comboBox_QueryServers.Text = comboBox_QueryServers.Items[0].ToString();
            }



            textBox_server.Text = serverToPing;
            textBox_testURI.Text = AppConfig.BaseURI;

            textBox_testServer.Text = AppConfig.WebTLMaddress;

            //checkConnected();
            Thread temp = new Thread(monitorCheck);
            temp.Start();
            timer_checkConnected.Interval = AppConfig.CheckConnectedInterval;
            timer_checkConnected.Enabled = true;

            LoadSFTPthread();
            initialize = false;

        }
        private int getDelayDlivery(int numberOfBytes)
        {
          //  if(AppConfig.dela)
            if (AppConfig.CalcDelivery)
            {
                return numberOfBytes / bytesToMiliSecRatio;
            }
            else
            {
                return default_delivery_delay;
            }
        }
        public byte[] stringToBytes(string sfduBlock)
        {
            return Encoding.ASCII.GetBytes(sfduBlock);
        }

        public void addToLog(string text)
        {
            ListViewItem LVI = new ListViewItem(DateTime.Now.ToString());
            LVI.SubItems.Add(text);
            addToLogFile(text);
            if (listView_log.InvokeRequired)
            {
                StringArgReturningVoidDelegate2 d = new StringArgReturningVoidDelegate2(addToLog);
                listView_log.Invoke(d, new object[] { text });
            }
            else
            {
                listView_log.Items.Insert(0, LVI);
                Application.DoEvents();
            }

        }
       public void addToLogFile(string text)
        {
            using (StreamWriter w = File.AppendText(Settings.Default.LogFileDir+"dsn_adaptor_log_"+DateTime.UtcNow.DayOfYear+".txt"))
            {
                w.WriteLine(DateTime.UtcNow.ToString() +"."+DateTime.UtcNow.Millisecond+ " : "+ text);
            }
        }
        delegate void StringArgReturningVoidDelegate2(string text);
        delegate void StringArgReturningVoidDelegate(string text, Color color);
        public void addToLog(string text, Color color)
        {
            // listBox_log.Items.Insert(0,DateTime.Now.ToString()+" "+text);
            ListViewItem LVI = new ListViewItem(DateTime.Now.ToString());
            LVI.SubItems.Add(text);
            LVI.BackColor = color;
            addToLogFile(text);
            if (listView_log.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(addToLog);
                listView_log.Invoke(d, new object[] { text, color });
            }
            else
            {
                listView_log.Items.Insert(0, LVI);
                listView_log.Items[0].BackColor = color;
                Application.DoEvents();
            }

        }
        public string GetLocalIPAddress()
        {

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    changePictureBoxAccordingToBoolean(pictureBox_localIP, true);
                    addToLog("Fetching IP : " + ip.ToString());
                    if (initialize)
                        textBox_testServer.Text = ip.ToString();
                    pictureBox_adapt2web.BackgroundImage = Resources.arrow;
                    return ip.ToString();
                }
            }
            addToLog(("Fetching IP : No network adapters with an IPv4 address in the system!"));
            changePictureBoxAccordingToBoolean(pictureBox_localIP, false);
            pictureBox_adapt2web.BackgroundImage = Resources.redArrow;
            pictureBox_web2adapt.Visible = false;
            return null;
        }

        private void panel_toolbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public static async void FadeIn(Form o, int interval = 80)
        {
            //Object is not fully invisible. Fade it in
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1; //make fully visible       
        }

        public static void FadeOut(Form o, int interval = 80)
        {
            //Object is fully visible. Fade it out
            while (o.Opacity > 0.0)
            {
                //await Task.Delay(interval);
                Thread.Sleep(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; //make fully invisible       
        }

        private void button_APItest_Click(object sender, EventArgs e)
        {
            tabControl_tabs.SelectedIndex = 1;
            highlight_selected_button(sender);
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            Popup p = new Popup("Warning", "Changing settings should be done under supervision\n\nAre you sure you would like to change settings?", true);
            if (p.ShowDialog() == DialogResult.Yes)
            {
                tabControl_tabs.SelectedIndex = 3;
                highlight_selected_button(sender);
            }
        }
        private void button_testExecute_Click(object sender, EventArgs e)
        {
            richTextBox_response.Clear();
            QuerySession qs = new QuerySession(textBox_testServer.Text, AppConfig.RequstTimeout, textBox_testURI.Text, AppConfig.ProxyServerUsage, AppConfig.ProxyServerAddress, AppConfig.ProxyPort);

            var queryResult = qs.ExecuteRequest();
            //bool connected = checkConnected();
            //if (connected)
            //{
            //    string localIP = textBox_testLocalHost.Text;
            //   // string uri = "https://jsonplaceholder.typicode.com/todos/1";
            //    string uri = @"https://reqres.in/api/users?page=2";
            //    var client = new RestClient(@"http://" + localIP);
            //    var request = new RestRequest(uri, Method.GET); 
            //    var queryResult = client.Execute<List<string>>(request).Data;
            //   // request.
            if (queryResult != null)
            {


                //List<string> lines = new List<string>();
                //foreach (string item in queryResult)
                //{
                //    JObject parsed = JObject.Parse(item);
                //    foreach (var pair in parsed)
                //    {
                //        lines.Add(string.Format("{0}: {1}", pair.Key, pair.Value));
                //    }
                //    lines.Add("");
                //}
                richTextBox_response.Text =queryResult.Content;
                // richTextBox_response.tex = alltext;

            }
            else
            {
                addToLog("Null response from " + qs.BaseURI, Color.Red);
            }
            addToLog("Finished querying");
            //}
            //else
            //{
            //    addToLog("Not connected!", Color.Red);
            //}
        }

        private void button_DSN_Click(object sender, EventArgs e)
        {
            manual = false;
            display_manual_controls(manual);
            tabControl_tabs.SelectedIndex = 0;
            highlight_selected_button(sender);
            
        }
        private void endApplicaiton()
        {
            addToLog("Quitting");
            if (isRunning)
                stopRun();
            if(sftpRunning)
            {
                addToLog("Stopping SFTP thread");
             //   SFTPload.Interrupt();
                SFTPload.Abort();
            //    SFTPload.Join();
            }

            FadeOut(this, 15);
            Application.Exit();
        }
        private void button_quit_Click(object sender, EventArgs e)
        {
            bool toQuit = false;
            string text = "Are you sure you want to quit?";
            if (isRunning)
            {
                text = "Adaptor is still running\n\n" + text;

            }
            Popup warning = new Popup("Warning", text, true);
            toQuit = warning.ShowDialog() == DialogResult.Yes;
            if (toQuit)
                endApplicaiton();
            // FadeOut(this, 15);

            // Application.Exit();
        }

        private void timer_checkConnected_Tick(object sender, EventArgs e)
        {

            monitorCheck();

            //if(timer_checkConnected.Interval != Settings.Default.ConnectionInterval)
            //{
            //    timer_checkConnected.Stop();
            //    timer_checkConnected.Interval = Settings.Default.ConnectionInterval;
            //    timer_checkConnected.Start();
            //}

        }
        private void changePictureBoxAccordingToBoolean(PictureBox picBox, bool status)
        {
            if (status)
            {
                picBox.BackgroundImage = Resources.radio_checked;

            }
            else
            {
                picBox.BackgroundImage = Resources.radio_button_red;
            }
        }
        delegate void MonCheck();
        private void monitorCheck()
        {
            //  bool valid=true;
            if (this.InvokeRequired)
            {
                MonCheck d = new MonCheck(monitorCheck);
                this.Invoke(d, new object[] { });
            }
            else
            {
                GetLocalIPAddress();
                checkConnected();
                pingServer(serverToPing);
                update_queue_size();
            }
        }
        private bool checkConnected()
        {
            bool connected = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            changePictureBoxAccordingToBoolean(pictureBox_connected, connected);
            addToLog("Check network connection : " + connected);

            if (connected)
            {
                pictureBox_adapt2web.BackgroundImage = Resources.arrow;
            }
            else
            {
                pictureBox_adapt2web.BackgroundImage = Resources.redArrow;
                pictureBox_web2adapt.Visible = false;
            }
            return connected;
        }
        private bool pingServer(string address)
        {
            if (initialize)
                textBox_server.Text = address;
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(address);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException pe)
            {
                addToLog("Check ping to " + address + ": " + pe.Data, Color.Red);
            }
            catch (Exception e)
            {
                addToLog("Check ping to " + address + ": " + e.Data, Color.Red);
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }
            addToLog("Check ping to " + address + ": " + pingable);
            changePictureBoxAccordingToBoolean(pictureBox_ping, pingable);

            if (pingable)
                pictureBox_adapt2web.BackgroundImage = Resources.arrow;
            else
            {
                pictureBox_adapt2web.BackgroundImage = Resources.redArrow;
                pictureBox_web2adapt.Visible = false;
            }
            return pingable;
        }
        private void stopRun()
        {

            addToLog("Stopping session", Color.Yellow);
            isRunning = false;
            foreach (Thread samplingThread in this.samplingThreads)
            {
                addToLog("Stopping Thread : "+samplingThread.Name);
                if (samplingThread != null && samplingThread.IsAlive)
                {
                    samplingThread.Interrupt();
                    samplingThread.Join();
                }
            }
            if (udpThread != null && udpThread.IsAlive)
                udpThread.Join();

            button_listen.Invoke(new MethodInvoker(() => { button_listen.Text = "Initiate"; }));
            
            addToLog("Stopping threads");
            button_listen.Invoke(new MethodInvoker(() => { button_listen.Image = Resources.dish; }));
         
            isStopping = false;
        }
        private bool Authenticate(ref Cookie cook)
        {
         if(openAMsession==null)
            {
                openAMsession = new OpenAM(AppConfig.OpenAMuser, AppConfig.OpenAMpassword, AppConfig.CookieURI, AppConfig.TokenIdURI, AppConfig.CookieDomain, AppConfig.CookieDefaultName, AppConfig.tokenValidity);

            }
            //         addToLog("Authenticating " + AppConfig.OpenAMauthenticateURI); // TODO add general query for seeing general connection
            //  bool auth = oam.Authenticate(localIP);
            cook = null;
            bool auth = openAMsession.Authenticate(ref cook);
            changePictureBoxAccordingToBoolean(pictureBox_authenticated, auth);

            if (!auth)
            {
                pictureBox_adapt2web.BackgroundImage = Resources.redArrow;

              
                if(pictureBox_web2adapt.InvokeRequired)
                {
                    pictureBox_web2adapt.Invoke(new MethodInvoker(() => { pictureBox_web2adapt.Visible = false; }));
                }
                else
                {
                    pictureBox_web2adapt.Visible = false;
                }
                
               
                foreach (string item in openAMsession.errors)
                {
                    addToLog(item, Color.Red);
                }
                return false;
            }
          
            return true;
        }
        bool isStopping = false;
        private void button_listen_Click(object sender, EventArgs e)
        {
            if (isRunning) // Stop querying
            {
                isStopping = true;
                timer_checkConnected.Enabled = true;
                if (dataStack!=null && dataStack.Count > 0)
                    addToLog("UDP records reamining: " + dataStack.Count);
                Application.DoEvents();
                Thread stoppingThread = new Thread(stopRun);
                // stopRun(); // Should be different thread , Should assign bool "stopping value"
                stoppingThread.Start();
              


                // Move to stop run thread
          

            }
            else if(!isStopping) // Run new session
            {

                samplingThreads = new List<Thread>();
                label_SfduRead.Text = "";
                timer_checkConnected.Enabled = false;
                button_listen.Image = Resources.stop;
                isRunning = true;
                button_listen.Text = "Stop";
                clear_status_radio_buttons();
                addToLog("Establishing connection...");
                pictureBox_adapt2web.Visible = true;
                string localIP = GetLocalIPAddress();
                bool connected = checkConnected();

                if (localIP == null) // Local IP
                {
                    stopRun();

                    return;
                }
                if (!connected) // Network
                {
                    stopRun();
                    return;
                }

                if (!pingServer(serverToPing)) // ping
                {
                    stopRun();
                    return;
                }
                //       pictureBox_adapt2web.BackgroundImage = Resources.arrow;

                
              



                pictureBox_adapt2scc.Visible = true;
                udpDests = new List<UDP>();
                int count = 0;
                foreach (string destIP in AppConfig.UDPdests)
                {
                    int port = (AppConfig.UDPports[count]);
                    addToLog("Initializing UDP output connection, IP : " + destIP + " Port : " + port);
                    UDP udp = new UDP(destIP, port);
                    if (udp.bundle == null)
                    {
                        addToLog("Unable to intialize UDP output to : " + destIP + " Port " + port, Color.Red);
                        // ChangeArrowImage(pictureBox_adapt2scc, Resources.redArrow) ;
                        pictureBox_adapt2scc.BackgroundImage = Resources.redArrow;


                    }
                    else
                        udpDests.Add(udp);
                    count++;
                }







                #region Query Session



                addToLog("Initializing UDP loop");
                udpThread = new Thread(UDPloop);
                dataStack = new Queue<byte[]>();
                udpThread.Start();


                addToLog("Start querying");
                pictureBox_web2adapt.Visible = true;
                pictureBox_web2adapt.BackgroundImage = Resources.arrow;
              

                if (!manual)
                {
                    foreach (string queryServer in AppConfig.QueryServers)
                    {
                        addToLog("Initializing query loop : " + queryServer);
                        Thread samplingThread = new Thread(new ParameterizedThreadStart(QueryLoop));
                        samplingThread.Name = queryServer;
                        samplingThread.Start(queryServer);
                        samplingThreads.Add(samplingThread);
                    }
                }
                else
                {
                    string queryServer = comboBox_QueryServers.Text;
                    addToLog("Initializing query loop : " + queryServer);
                    Thread samplingThread = new Thread(new ParameterizedThreadStart(QueryLoop));
                    samplingThread.Name = queryServer;
                    samplingThread.Start(queryServer);
                    samplingThreads.Add(samplingThread);
                }
             
                 
                
                #endregion
            }
            else
            {
                addToLog("Previous sessions still stopping", Color.Yellow);
            }

        }

        private string responseListToString(List<string> data)
        {
            string text = "";
            foreach (string item in data)
            {
                JObject parsed = JObject.Parse(item);
                foreach (var pair in parsed)
                {
                    text += (string.Format("{0}: {1}", pair.Key, pair.Value));
                }
                text += "\n";
            }
            return text;
        }
        private void clear_status_radio_buttons()
        {
            pictureBox_localIP.BackgroundImage = Resources.radio_unchecked;
            pictureBox_connected.BackgroundImage = Resources.radio_unchecked;
            pictureBox_authenticated.BackgroundImage = Resources.radio_unchecked;
            pictureBox_ping.BackgroundImage = Resources.radio_unchecked;
            pictureBox_request.BackgroundImage = Resources.radio_unchecked;
        }
        public void reset_buttons_back()
        {
            button_DSN.BackColor = Color.White;
            button_APItest.BackColor = Color.White;
            button_manual.BackColor = Color.White;
            button_settings.BackColor = Color.White;
        }
        private void highlight_selected_button(object sender)
        {
            reset_buttons_back();
            Button b = (Button)sender;
            b.BackColor = SystemColors.ControlLight;
        }
        private void button_manual_Click(object sender, EventArgs e)
        {
            manual = true;
            display_manual_controls(manual);
            tabControl_tabs.SelectedIndex =0;

            //TODO manual settings
            highlight_selected_button(sender);
          
        }
        private void display_manual_controls(bool display)
        {
            label_queryServers.Visible = display;
            comboBox_QueryServers.Visible = display;

            label_queryStart.Visible = display;
            dateTimePicker_queryStart.Visible = display;

            label_queryEnd.Visible = display;
            dateTimePicker_queryEnd.Visible = display;


            label_dss.Visible = display;
            textBox_DSS.Visible = display;
        }
        //private void invokeCheckConnection()
        //{
        //    // timer_checkConnected.Enabled = false;
        //    timer_checkConnected.Stop();
        //    timer_checkConnected.Interval = Settings.Default.ConnectionIntervalLoss;
        //    timer_checkConnected.Start();
        //    //  timer_checkConnected.Enabled = true;
        //}
        //private void ChangeArrowImage(PictureBox box, Image im)
        //{
        //    box.BackgroundImage = im;
        //    //box.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);

        //}
        private bool displayConfigData()
        {
            numericUpDown_MonitorInterval.Value = AppConfig.CheckConnectedInterval;

            checkBox_useProxy.Checked = AppConfig.ProxyServerUsage;
            textBox_proxyaddress.Text = AppConfig.ProxyServerAddress;
            numericUpDown_port.Value = AppConfig.ProxyPort;

            numericUpDown_deliveryDelay.Value = AppConfig.DelayDelivery;
            checkBox_calcDelay.Checked = AppConfig.CalcDelivery;
            numericUpDown_byteratio.Value = AppConfig.ByteRatio;

            dataGridView_addresses.Rows.Clear();
            foreach (string item in AppConfig.UDPdests)
            {
                dataGridView_addresses.Rows.Add(item);
            }

            dataGridView_ports.Rows.Clear();
            foreach (int item in AppConfig.UDPports)
            {
                dataGridView_ports.Rows.Add(item.ToString());
            }

            textBox_webTLMaddress.Text = AppConfig.WebTLMaddress;
            textBox_SCID.Text = AppConfig.SCID;
            textBox_BaseURI.Text = AppConfig.BaseURI;
            numericUpDown_RequestTimeout.Value = AppConfig.RequstTimeout;
            numericUpDown_RequestInterval.Value = AppConfig.RequestInterval;
            numericUpDown_RequestRetry.Value = AppConfig.RequestRetries;
            textBox_SFDUsync.Text = AppConfig.SFDUsync;
            foreach (string item in AppConfig.QueryServers)
            {
                dataGridView_queryServers.Rows.Add(item);
            }
        


            checkBox_useAu.Checked = AppConfig.UseAuthentication;
            textBox_AMuser.Text = AppConfig.OpenAMuser;
            textBox_AMpassword.Text = AppConfig.OpenAMpassword;
            textBox_AMserver.Text = AppConfig.OpenAMserver;
            textBox_CookieURI.Text = AppConfig.CookieURI;
            textBox_AuURI.Text = AppConfig.TokenIdURI;

            return true;
        }
        public static void AppendAllBytes(string path, byte[] bytes)
        {
            //argument-checking here.

            using (var stream = new FileStream(path, FileMode.Append))
            {
                stream.Write(bytes, 0, bytes.Length);
            }
        }
        private PVLblock getNextBlockStartOffset(byte[] buffer,ref int offset)
        {
            int min = int.MaxValue;
            int startOffset = offset;
            PVLblock temp = null;
            foreach (PVLblock block in AppConfig.PVLblocks)
            {
                startOffset = FindSyncWordOffset(buffer.ToArray(), offset, block.header);
                if (startOffset!=-1 && startOffset<min)
                {
                    //  addToLog("Start block: " + block.BlockName, Color.Green);
                    //    pvlBlocks.Enqueue(block);
                    temp = block;
                    min = startOffset;
                  
                }
            }
            if (temp != null)
                offset = min;
            return temp;
        }
        int sfduRead = 0;

        List<Stream> activeStreams = new List<Stream>();
        public void cancelStream()
        {
            foreach (Stream item in activeStreams)
            {
                item.Close();
            }
            activeStreams.Clear();
        }


        public void ReadStream(Stream ms)
        {
            activeStreams.Add(ms);
            
            List<byte> buffer = new List<byte>();
            int bufferSize = AppConfig.bufferSize;
            int bytesRead;

          
            int readPointer = 0;
            Stack<PVLblock> pvlBlocks = new Stack<PVLblock>();
            PVL p = new PVL();
            bool readData = manual;
         
            if (AppConfig.PVLblocks.Count == 0)
            {
                addToLog("No PVL blocks, Start reading data");
                readData = true; ;
            }
            do
            {

                byte[] tempBuffer = new byte[bufferSize];

                //  bytesRead = await ms.ReadAsync(tempBuffer, 0, bufferSize, cancelReadStream.Token); //TODO Do asyncronyious, cancel token
                try
                {

                    bytesRead = ms.Read(tempBuffer, 0, bufferSize);

                }
                catch (IOException e)
                {

                    //throw;
                    bytesRead = 0;
                }
                //    BinaryReader br = new BinaryReader(ms);
                //  tempBuffer = br.ReadBytes(bufferSize);
                //bytesRead = tempBuffer.Length;

                if (bytesRead > 0) // New data
                {
                    buffer.AddRange(tempBuffer.Take(bytesRead));
                    if (Config.debugLevel == DebugLevel.FULL)
                    {
                        AppendAllBytes(AppConfig.debugFile, tempBuffer);
                    }
                    if (!readData)
                    {
                        PVLblock nextBlock;
                        do
                        {


                            int nextBlockHeaderPointer = readPointer;
                            nextBlock = getNextBlockStartOffset(buffer.ToArray(), ref nextBlockHeaderPointer);

                            if (pvlBlocks.Count > 0)
                            {
                                int endOffset;
                                do
                                {


                                    string trailerToFind = pvlBlocks.Peek().trailer;
                                    endOffset = FindSyncWordOffset(buffer.ToArray(), readPointer, trailerToFind);
                                    if (endOffset != -1)
                                    {
                                        if (nextBlock == null || endOffset < nextBlockHeaderPointer) // End Block is sooner than next block
                                        {

                                            PVLblock foundBlock = pvlBlocks.Pop();

                                            addToLog("End block: " + foundBlock.BlockName, Color.Green);
                                            byte[] blockData = new byte[endOffset + trailerToFind.Length - foundBlock.StartOffset];
                                            Buffer.BlockCopy(buffer.ToArray(), foundBlock.StartOffset, blockData, 0, blockData.Length); // TODO fix start pointer to start from buffer start
                                            foundBlock.SubmitData(blockData);
                                            if (Config.debugLevel == DebugLevel.FULL)
                                            {
                                                AppendAllBytes(@".\Blocks", blockData);
                                            }
                                            readPointer = endOffset + trailerToFind.Length;
                                            if (foundBlock.BlockName == AppConfig.PVLdataStart)
                                            {
                                                addToLog("Reading SFDU", Color.Green);
                                                readData = true;

                                                buffer = buffer.Skip(readPointer).ToList();
                                                readPointer = 0;
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            break;
                                        }

                                        //readPointer = endOffset;
                                    }
                                } while (endOffset != -1 && pvlBlocks.Count > 0);
                            }
                            if (nextBlock != null && !readData)
                            {
                                nextBlock.StartOffset = nextBlockHeaderPointer;
                                pvlBlocks.Push(nextBlock);

                                readPointer = nextBlockHeaderPointer + nextBlock.header.Length;
                            }
                        } while (nextBlock != null && !readData);
                    }
                    if (readData)
                    {
                        int endExcessDataPoint = readPointer;
                        List<byte[]> sfdus = deliminateSFDU(buffer.ToArray(), ref endExcessDataPoint);

                        //Calculate Pointer
                        int totalBytes = 0;
                        foreach (byte[] sfdu in sfdus)
                        {
                            totalBytes += sfdu.Length;
                        }
                        if (totalBytes < buffer.Count) // More data exists in the buffer
                        {
                            //TODO
                            int nextBlockHeaderPointer = 0;
                            PVLblock nextBlock = getNextBlockStartOffset(buffer.ToArray(), ref nextBlockHeaderPointer);

                            if (nextBlock != null)
                            {
                                int endOffset = FindSyncWordOffset(buffer.ToArray(), readPointer, nextBlock.trailer);

                                if (endOffset != -1)
                                {
                                    addToLog("Found block: " + nextBlock.BlockName, Color.Green);
                                    byte[] blockData = new byte[endOffset + nextBlock.trailer.Length - nextBlockHeaderPointer];
                                    Buffer.BlockCopy(buffer.ToArray(), nextBlockHeaderPointer, blockData, 0, blockData.Length); // TODO fix start pointer to start from buffer start
                                    nextBlock.SubmitData(blockData);
                                    endExcessDataPoint = endOffset + nextBlock.trailer.Length;
                                }
                                else
                                {
                                    addToLog("Couldn't find block end: " + nextBlock.BlockName, Color.Yellow);
                                }
                            }

                        }

                        buffer = buffer.Skip(endExcessDataPoint).ToList();
                        readPointer = 0;
                        foreach (byte[] item in sfdus)
                        {
                            lock (balanceLock)
                            {
                                dataStack.Enqueue(item);
                                update_queue_size();
                            }
                        }
                        sfduRead += sfdus.Count;

                        label_SfduRead.Invoke(new MethodInvoker(() => { label_SfduRead.Text = sfduRead.ToString(); }));

                        //   label_SfduRead.Text = "SFDU read : " + sfduRead;
                    }

                    //if (readData)
                    //{
                    //    int endExcessDataPoint = 0; //TODO - read the data as PVL object
                    //    List<byte[]> sfdus = deliminateSFDU(buffer.ToArray(),ref endExcessDataPoint);
                    //    buffer = buffer.Skip(endExcessDataPoint).ToList();
                    //    foreach (byte[] item in sfdus)
                    //    {
                    //        dataStack.Enqueue(item);
                    //    }
                    //}

                }
                Thread.Sleep(AppConfig.ReadStreamInterval);
            } while (isRunning && !isStopping && ms.CanRead &&bytesRead>0);
            // File.WriteAllBytes(@".\temp", allBytes.ToArray());
            ms.Close();
        }
  
        public void HandleResponse(IRestResponse restResponse)
        {
            bool reachedMaxRetry = false;
            string queryServer = "";
            try
            {
                queryServer = restResponse.ResponseUri.LocalPath.ToString().Split('/')[3];
            }
            catch (Exception)
            {

                
            }
            addToLog(queryServer + " : " + "End of stream, status code = "+restResponse.StatusCode, Color.GreenYellow);
            if (restResponse.StatusCode == HttpStatusCode.OK)
            {

                changePictureBoxAccordingToBoolean(pictureBox_request, true);
                if (reachedMaxRetry) // Restored connection
                {
                    // invokeCheckConnection();

                    addToLog(queryServer + " : " + "Connection restored", Color.Green);
                    // changePictureBoxAccordingToBoolean(pictureBox_request, true);

                    pictureBox_web2adapt.Invoke(new MethodInvoker(() => { pictureBox_web2adapt.Visible = true; pictureBox_web2adapt.BackgroundImage = Resources.arrow; }));


                    //ChangeArrowImage(pictureBox_web2adapt, Resources.arrow);

                    reachedMaxRetry = false;
                }

               // retries = 0;
               
            }
            else
            {
                addToLog(queryServer + " : " + "Response from server was NULL", Color.Red);
                changePictureBoxAccordingToBoolean(pictureBox_request, false);
                //  error = true;



                // 24.03 - This is for restarting the threads if an unexpected response was recevied
                foreach (Thread samplingThread in this.samplingThreads)
                {
                    addToLog("Stopping Thread : " + samplingThread.Name);
                    if (samplingThread != null && samplingThread.IsAlive)
                    {
                        samplingThread.Interrupt();
                        samplingThread.Join();
                    }
                }
            }

        }
        DateTime lastQuery = new DateTime();
        private readonly object AuthenticateBlock = new object();

        
        private void QueryLoop(object queryServer)
        {
            int retries = 0;
            bool oneTrial = false;
            while (isRunning && !isStopping&& !oneTrial)
            {
                if (manual)
                    oneTrial = true;
                monitorCheck();
                bool error = false;
                Cookie cook = null;
                if (AppConfig.UseAuthentication)
                {
                    lock (AuthenticateBlock)
                    {
                        addToLog(queryServer + " : " + "Attempting to authenticate");
                        bool au = Authenticate(ref cook);
                        if (!au)
                        {
                            addToLog(queryServer + " : " + "Couldn't authenticate", Color.Red);
                            error = false;
                        }
                        else
                        {
                            addToLog(queryServer + " : " + "Successfully authenticated", Color.Green);
                        }
                        changePictureBoxAccordingToBoolean(pictureBox_authenticated, au);
                    }
                }
                if (!error && isRunning)
                {
                    sfduRead = 0;
                    // string queryServer = comboBox_QueryServers.Text;

                    GETsfduQuery query;
                    
                    if(!manual)
                        query= new GETsfduQuery(AppConfig.WebTLMaddress, AppConfig.RequstTimeout, AppConfig.BaseURI, AppConfig.ProxyServerUsage, AppConfig.ProxyServerAddress, AppConfig.ProxyPort, AppConfig.SCID, queryServer.ToString(), cook);
                    else
                    {
                        string dss = null;
                        if(textBox_DSS.Text!="")
                        {
                            dss = (textBox_DSS.Text);
                        }
                        query = new GETsfduQuery(AppConfig.WebTLMaddress, AppConfig.RequstTimeout, AppConfig.BaseURI, AppConfig.ProxyServerUsage, AppConfig.ProxyServerAddress, AppConfig.ProxyPort, AppConfig.SCID, queryServer.ToString(), cook,dateTimePicker_queryStart.Value, dateTimePicker_queryEnd.Value,dss);
                    }


                    query.restRequest.ResponseWriter = new Action<Stream>(ReadStream);

                      query.ExecuteAsyncRequest(HandleResponse);
                    //      Task<IRestResponse> task = query.ExecuteTaskAsyncRequest();
                    //  IRestResponse r= query.ExecuteRequest();

                    if (!manual)
                    {
                        int requestInterval = AppConfig.RequestInterval;
                        addToLog(queryServer + " : " + "About to sleep " + requestInterval + "min");

                        progressBar_prog.Invoke(new MethodInvoker(() => { progressBar_prog.Value = 100; }));
                      
                        lastQuery = DateTime.Now;

                        try
                        {
                            Thread.Sleep(requestInterval * 60 * 1000);
                        }
                        catch (Exception e)
                        {

                            addToLog(queryServer + " : " + "Thread interrupted");
                        }
                        finally
                        {
                            lastQuery = new DateTime();
                            query.restRequest.Timeout = 0;
                            //  query.restRequest.
                            cancelStream();
                        }
                    }
                }
                if(error)
                {
                  
                    retries++;
                    if (retries >= AppConfig.RequestRetries) // Max retry reached
                    {
                      //  if (!reachedMaxRetry)
                       // {

                       //     reachedMaxRetry = true;
                            addToLog(queryServer + " : " + "Max retries reached : " + AppConfig.RequestRetries, Color.Red);
                            //ChangeArrowImage(pictureBox_web2adapt, Resources.redArrow);
                            pictureBox_web2adapt.BackgroundImage = Resources.redArrow;
                            changePictureBoxAccordingToBoolean(pictureBox_request, false);
                            //invokeCheckConnection();
                            monitorCheck();
                      //  }
                      Thread.Sleep(AppConfig.RetryInterval);

                    }
                }


            }
        }
        private readonly object balanceLock = new object();
        private void UDPloop()
        {
            int recordsSent = 0;
            while (isRunning || dataStack.Count > 0)
            {

                if (dataStack.Count > 0)
                {
                    byte[] item;
                    lock (balanceLock)
                    {
                        item = dataStack.Dequeue();
                        update_queue_size();
                    }

                    //string data = responseListToString(item);
                    bool sent = true;
                    foreach (UDP udp in udpDests)
                    {

                        bool thisValid = udp.SendUDPdata(item);
                        sent = sent && thisValid;
                        if (!thisValid)
                        {
                            addToLog("Couldn't send UDP! : " + udp.lastErrorMessage);
                            pictureBox_adapt2scc.BackgroundImage = Resources.redArrow;
                        }
                    
                    }
                    if (sent)
                    {

                        recordsSent++;
                        label_SFDUsent.Invoke(new MethodInvoker(() => { label_SFDUsent.Text = recordsSent.ToString(); }));


                    }
                    if (isRunning)
                        Thread.Sleep(getDelayDlivery(item.Length));
                }

            }
            //update_queue_size();


        }

        private void button_udpTest_Click(object sender, EventArgs e)
        {

            string textToSend = richTextBox_response.Text;

            sendTestText(textToSend);

        }
        private void updateProgress(Label lab,int currnet, int total)
        {
            int progress = (int)(((double)currnet / (double)total) * 100);
            lab.Text = string.Format("{0}/{1} SFDUs {2}% ", currnet, total, progress);
            if (progress > progressBar_prog.Value)
            {
                progressBar_prog.Value = (int)progress;

            }
            Application.DoEvents();
        }

        public async void SendUDPBuffer(Label prog_label,List<byte[]> data)
        {
            UDP udp = new UDP(textBox_destUDPip.Text, int.Parse(textBox_UDPport.Text));
            int byteRatio = AppConfig.ByteRatio;
            bool calcDelay = AppConfig.CalcDelivery;
            int c = 0;
            // bool littleEndia = false;
            foreach (byte[] sfdu in data)
            {
                //string newString = "";
                //for (int i = 0; i < sfdu.Length; i+=2)
                //{

                //    string hexVal;
                //    if(littleEndia)
                //    {
                //        hexVal = sfdu[i+1].ToString() + sfdu[i].ToString();
                //    }
                //    else
                //    {
                //        hexVal = sfdu[i].ToString() + sfdu[i + 1].ToString();
                //    }

                //    int conVal = Convert.ToInt16(hexVal, 16);
                //    newString += (char)conVal;
                //}
                udp.SendUDPdata(sfdu);
                if(Config.debugLevel == DebugLevel.FULL)
                {
                    AppendAllBytes(@".\sfdu",sfdu);
                }
                c++;
                updateProgress(prog_label, c, data.Count);

                //using (Graphics gr = progressBar_prog.CreateGraphics())
                //{
                //    gr.DrawString(progress.ToString() + "%",
                //        SystemFonts.DefaultFont,
                //        Brushes.Black,
                //        new PointF(progressBar_prog.Width / 2 - (gr.MeasureString(progress.ToString() + "%",
                //            SystemFonts.DefaultFont).Width / 2.0F),
                //        progressBar_prog.Height / 2 - (gr.MeasureString(progress.ToString() + "%",
                //            SystemFonts.DefaultFont).Height / 2.0F)));
                //}
                await Task.Delay(getDelayDlivery(sfdu.Length));
                // Thread.Sleep
            }


        }

        private string[] deliminateSFDU(string text)
        {
            List<string> sfdu = new List<string>();
            string deliminator = AppConfig.SFDUsync;
            string[] lines = text.Split(new string[] { deliminator }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = deliminator + lines[i];
            }
            return lines;
        }
        public int FindSyncWordOffset(byte[] bytes, int offset, string syncWord)
        {
            //  int startPos = -1;
            for (int i = offset; i < bytes.Length; i++)
            {
                if (BytesIsSyncWord(bytes, i, syncWord))
                    return i;
            }
            return -1;
        }
        public static bool BytesIsSyncWord(byte[] bytes, int offset, string syncWord)
        {
            bool flag = true;

            byte[] delimBytes = Encoding.ASCII.GetBytes(syncWord);
            int count = 0;
            if (bytes.Length > offset)
            {
                //byte start = delimBytes[offset];
             
                for (int l = 0; l < delimBytes.Length && (offset + l) < bytes.Length; l++)
                {
                    flag = flag && (delimBytes[l] == bytes[offset + l]);
                    if (!flag)
                        break;
                    count++;
                }
               
            }
            flag = flag && count == delimBytes.Length;
            return flag;
        }
        private List<byte[]> deliminateSFDU(byte[] bytes,ref int endPointer)
        {
            List<byte[]> readbytes = new List<byte[]>();
            //  string deliminator = AppConfig.SFDUsync;

            int lengthOffset = AppConfig.LengthAttributeOffset;
            int lengthSize = AppConfig.LengthAttributeSize;
        //    endPointer = 0;
            //  int counter = 0;
            // int k = 0;
            //      List<byte> tempByte = new List<byte>();

            //  int bytesToWrite = 0;
            for (int i = endPointer; i < bytes.Length; i++)
            {
                byte currentByte = bytes[i];
                // if (i != 0)
                // {
                //if (currentByte == delimBytes[0])
                //{

                if (BytesIsSyncWord(bytes, i, AppConfig.SFDUsync)) // Found Sync word
                {
                    // tempByte.Clear();
                    // Try to read length attribute
                    //try
                    //{
                    byte[] subset = new byte[AppConfig.LengthAttributeSize];

                    if (i + lengthOffset + lengthSize >= bytes.Length)
                    {
                      //  addToLog("Couldn't parse length attribute of SFDU", Color.Red);
                        break;
                    }

                    Buffer.BlockCopy(bytes, i + lengthOffset, subset, 0, lengthSize);
                    Array.Reverse(subset);
                    int bytesToWrite = BitConverter.ToInt16(subset, 0);


                    bytesToWrite += lengthOffset + lengthSize;
                    if (i + bytesToWrite > bytes.Length)
                    {
                     //   addToLog("SFDU size exceeds bytes read", Color.Red);
                        break;
                    }
                    byte[] tempA = new byte[bytesToWrite];
                    Buffer.BlockCopy(bytes, i, tempA, 0, bytesToWrite);
                    readbytes.Add(tempA);
                    i += bytesToWrite - 1;
                    endPointer = i + 1;
                    //}
                    //catch (Exception e)
                    //{


                    // }



                    //tempByte.AddRange(delimBytes);

                    //  }
                    //   }
                }
                //if (bytesToWrite > 0)
                //{
                //    //    tempByte.Add(bytes[i]);
                //    counter++;
                //    if (counter == bytesToWrite)
                //    {
                //        byte[] tempA = new byte[bytesToWrite];
                //        Buffer.BlockCopy(bytes, writePointer, tempA, 0, bytesToWrite);
                //        readbytes.Add(bytes.Skip(writePointer).Take(counter).ToArray());
                //        // tempByte.Clear();
                //        writePointer = i + 1;
                //        counter = 0;
                //        bytesToWrite = 0;
                //    }
                //}

            }
            // readbytes.Add(tempByte.ToArray());
          //  if(bufferToModify!=null)
            //    bufferToModify = bytes.Skip(writePointer + 1).ToList();
            return readbytes;
        }
        //private List<byte[]> deliminateSFDU(byte[] text)
        //{
        //    List<byte[]> readbytes = new List<byte[]>();
        //    string deliminator = AppConfig.SFDUsync;
        //    byte[] delimBytes = Encoding.ASCII.GetBytes(deliminator);
        //    // int k = 0;
        //    List<byte> tempByte = new List<byte>();
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        byte currentByte = text[i];
        //        if (i != 0)
        //        {
        //            if (currentByte == delimBytes[0])
        //            {
        //                bool flag = true;
        //                for (int l = 0; l < delimBytes.Length; l++)
        //                {
        //                    flag = flag && (delimBytes[l] == text[i + l]);
        //                    if (!flag)
        //                        break;
        //                }
        //                if (flag)
        //                {
        //                    readbytes.Add(tempByte.ToArray());
        //                    tempByte.Clear();
        //                }
        //            }
        //        }
        //        tempByte.Add(text[i]);
        //    }
        //    readbytes.Add(tempByte.ToArray());
        //    return readbytes;
        //}

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {
            Popup credits = new Popup("About", "DSN Adaptor V1\n\nBrought to you by:\n©Shai Yehezkel\n©Liav Rotenberg");

            credits.ShowDialog();
        }

        private void pictureBox_adapt2scc_BackgroundImageChanged(object sender, EventArgs e)
        {
            PictureBox current = (PictureBox)sender;
            if (current.InvokeRequired)
            {
                current.Invoke(new MethodInvoker(() => { current.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY); }));

            }
            else
            {
                current.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
            }

        }

        private void timer_checkStack_Tick(object sender, EventArgs e)
        {
            update_queue_size();

        }
        private void update_queue_size()
        {
            int num = 0;
            if (dataStack != null)
            {
                num = dataStack.Count;
            }
            if (label_queueCount.InvokeRequired)
            {
                label_queueCount.Invoke(new MethodInvoker(() => { label_queueCount.Text = num.ToString(); }));
            }
            else
                label_queueCount.Text = num.ToString();
        }


        //public class PVL
        //{
        //    [JsonProperty(PropertyName = "foo")]
        //    public int foo { get; set; }
        //    [JsonProperty(PropertyName = "items")]
        //    public int[] items { get; set; }

        //}
        private void button_Parse_Click(object sender, EventArgs e)
        {
            string text = richTextBox_response.Text;
     
            List<PVLobject> pvls = PVL.Deserialize(text);

            string neData = PVL.Serialize(pvls);
            Popup pop = new Popup("New Message", neData);
            pop.ShowDialog();
        }

        private void button_loadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog_load.ShowDialog() == DialogResult.OK)
            {
                int i = 0;
                FileInfo f = new FileInfo(openFileDialog_load.FileName);
                byte[] text = File.ReadAllBytes(f.FullName);

                if(Config.debugLevel == DebugLevel.FULL)
                {
                    AppendAllBytes(@".\readBytes",text);
                }
                string textt = File.ReadAllText(f.FullName);
                string[] splits = textt.Split(new string[] { AppConfig.SFDUsync }, StringSplitOptions.RemoveEmptyEntries);
                List<byte[]> sfdus = deliminateSFDU(text, ref i);
                SendUDPBuffer(label_Progress,sfdus);
            }
        }
        private void sendTestText(string text)
        {
            if (checkBox_deliminate.Checked)
            {
                string[] sfdus = deliminateSFDU(text);
                //   SendUDPBuffer(sfdus);

            }
            //else if (!udp.SendUDPdata(richTextBox_response.Text))
            //{

            //    addToLog("Couldn't send UDP! : " + udp.lastErrorMessage);
            //}
        }

        private void button_testproxy_Click(object sender, EventArgs e)
        {
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(textBox_URI.Text);
            //WebProxy myproxy = new WebProxy(Settings.Default.ProxyServerAddress, Settings.Default.ProxyServerPort);
            //myproxy.BypassProxyOnLocal = false;
            //request.Proxy = myproxy;
            //request.Method = "GET";
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //  string uri = @"https://reqres.in/api/users?page=2";
            var client = new RestClient("https://reqres.in");
            //   client.Proxy = new WebProxy(Settings.Default.ProxyServerAddress, Settings.Default.ProxyServerPort);
            var request = new RestRequest(textBox_testURI.Text, Method.GET);
            var queryResult = client.Execute<List<string>>(request).Data;

            List<string> lines = new List<string>();
            foreach (string item in queryResult)
            {
                JObject parsed = JObject.Parse(item);
                foreach (var pair in parsed)
                {
                    lines.Add(string.Format("{0}: {1}", pair.Key, pair.Value));
                }
                lines.Add("");
            }
            richTextBox_response.Lines = lines.ToArray();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            int checkMonitorInterval = Decimal.ToInt32(numericUpDown_MonitorInterval.Value);

            bool proxyUsed = checkBox_useProxy.Checked;
            string proxyadd = textBox_proxyaddress.Text;
            int proxyPort = Decimal.ToInt32(numericUpDown_port.Value);

            int delayDelivery = Decimal.ToInt32(numericUpDown_deliveryDelay.Value);
            bool calcDelay = checkBox_calcDelay.Checked;
            int byteRatio = Decimal.ToInt32(numericUpDown_byteratio.Value);

            List<string> udpdests = new List<string>();
            foreach (DataGridViewRow row in dataGridView_addresses.Rows)
            {
                if (row.Cells[0].Value != null)
                    udpdests.Add(row.Cells[0].Value.ToString());
            }

            List<string> udpports = new List<string>();
            foreach (DataGridViewRow row in dataGridView_ports.Rows)
            {
                if (row.Cells[0].Value != null)
                    udpports.Add(row.Cells[0].Value.ToString());
            }


            string webTLMaddress = textBox_webTLMaddress.Text;
            string scid = textBox_SCID.Text;
            string baseURI = textBox_BaseURI.Text;
            int requestTimeout = Decimal.ToInt32(numericUpDown_RequestTimeout.Value);
            int requestInterval = Decimal.ToInt32(numericUpDown_RequestInterval.Value);
            int requestRetries = Decimal.ToInt32(numericUpDown_RequestRetry.Value);
            string sfduSync = textBox_SFDUsync.Text;
            List<string> queryServers = new List<string>();
            foreach (DataGridViewRow row in dataGridView_queryServers.Rows)
            {
                if (row.Cells[0].Value != null)
                    queryServers.Add(row.Cells[0].Value.ToString());
            }

            bool useAU = checkBox_useAu.Checked;
            string amUser = textBox_AMuser.Text;
            string amPass = textBox_AMpassword.Text;
          //  string amServer = textBox_AMserver.Text;
            string amCookieURI = textBox_CookieURI.Text;
            string amAuthURI = textBox_AuURI.Text;

            bool applied = AppConfig.SetNewConfigParameters(checkMonitorInterval, proxyUsed, proxyadd, proxyPort, delayDelivery, calcDelay, byteRatio, udpdests, udpports, webTLMaddress, scid, baseURI, requestTimeout, requestInterval, requestRetries, sfduSync, queryServers, amUser, amPass, amCookieURI, amAuthURI, useAU);

            if (applied)
            {
                Popup p = new Popup("Success", "Saved settings successfully");
                p.ShowDialog();
            }
            else
            {
                addToLog("Couldn't save change :", Color.Red);
            }
        }

        private void checkBox_useProxy_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox_useProxy.Checked;
            textBox_proxyaddress.Enabled = isChecked;
            numericUpDown_port.Enabled = isChecked;
        }

        private void checkBox_calcDelay_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox_calcDelay.Checked;
            numericUpDown_byteratio.Enabled = isChecked;
            numericUpDown_deliveryDelay.Enabled = !isChecked;
        }
        public string cookieName = "";
        private async void webTestGetCookieName()
        {
            var client = new HttpClient();

            //            // Create the HttpContent for the form to be posted.
            //            var requestContent = new FormUrlEncodedContent(new[] {
            //    new KeyValuePair<string, string>("text", "This is a block of text"),
            //});

            //            // Get the response.
            //            HttpResponseMessage response = await client.PostAsync(
            //                "http://api.repustate.com/v2/demokey/score.json",
            //                requestContent);

            HttpResponseMessage response = await client.GetAsync(textBox_testURI.Text);

            // Get the response content.
            HttpContent responseContent = response.Content;

            List<string> lines = new List<string>();
            // Get the stream of the content.
            using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
            {
                // Write the output.
                lines.Add(await reader.ReadToEndAsync());
            }
            cookieName = lines[0].Split('=')[1].Trim('\n');
            richTextBox_response.Lines = lines.ToArray();
        }

        public string token = "";
        private async void webTestAuthenticate()
        {
            var client = new HttpClient();

            // Create the HttpContent for the form to be posted.
            var requestContent = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("username", Settings.Default.OpenAM_username),
                new KeyValuePair<string, string>("password", Settings.Default.OpenAM_password)
            });

            // Get the response.
            HttpResponseMessage response = await client.PostAsync(
                textBox_testURI.Text,
                requestContent);

            //   HttpResponseMessage response = await client.GetAsync(textBox_testURI.Text);

            // Get the response content.
            HttpContent responseContent = response.Content;

            List<string> lines = new List<string>();
            // Get the stream of the content.
            if (response.StatusCode != HttpStatusCode.Unauthorized)
            {
                using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                {
                    // Write the output.
                    lines.Add(await reader.ReadToEndAsync());
                }

                string[] segs = lines[0].Split(new string[] { "token.id=" }, StringSplitOptions.RemoveEmptyEntries)[0].Split(new string[] { ".*" }, StringSplitOptions.RemoveEmptyEntries);
                string temp = lines[0].Split(new string[] { "token.id=" }, StringSplitOptions.RemoveEmptyEntries)[0].TrimEnd('\n');
                token = temp;
                richTextBox_response.Lines = lines.ToArray();
            }
            else
            {
                token = "";
               bool f =  Chrome.GetCookie_Chrome("jpl.nasa.gov", "noccSsoToken",ref token);
              //  token = richTextBox_response.Text;
            }
        
            
        }
        private void button_ExecuteWeb_Click(object sender, EventArgs e)
        {
            // webTestAuthenticate();
            webTestGetCookieName();
        }

        private void button_PostWithCookie_Click(object sender, EventArgs e)
        {
            webTestAuthenticate();
          //  var cookie = HttpContext.Current.Request.Cookies["ali_apache_id"];
            //token = "AQIC5wM2LY4SfcykK47COVunhT7SDdgU96U338HPz3Arp60.*AAJTSQACMDIAAlNLABMxMjMwMjEyMDgyMzc2Njk5ODkyAAJTMQACMDE.*";
       //     bool f = Chrome.GetCookie_Chrome("adobe.com", "mbox", ref token); // TODO replace with cookie name fetched
        }
        private void webQueryCookie()
        {
            Cookie cook = new Cookie(cookieName, token);
            //HttpClientHandler handle = new HttpClientHandler();
            //handle.CookieContainer = new CookieContainer();
            //handle.CookieContainer.Add(new Uri(textBox_testServer.Text),cook);
            //var client = new HttpClient(handle);

            //            // Create the HttpContent for the form to be posted.
            //            var requestContent = new FormUrlEncodedContent(new[] {
            //    new KeyValuePair<string, string>("text", "This is a block of text"),
            //});

            //            // Get the response.
            //            HttpResponseMessage response = await client.PostAsync(
            //                "http://api.repustate.com/v2/demokey/score.json",
            //                requestContent);

            try
            {

                RestClient c = new RestClient(textBox_testURI.Text);
                RestRequest restRequest = new RestRequest("/", Method.GET);
                //  restRequest.Timeout = requestTO;
                //HttpResponseMessage response = await client.GetAsync(textBox_testURI.Text);
                c.CookieContainer = new CookieContainer();
                c.CookieContainer.Add(new Uri(textBox_testServer.Text), cook);
                // Get the response content.
                //HttpContent responseContent = response.Content;
                //    Byte[] byteArray = await responseContent.ReadAsByteArrayAsync();

               // IRestResponse r = c.Execute(restRequest);

                //var queryResult = c.Execute<List<string>>(restRequest).Data;
                byte[] data = c.Execute(restRequest).RawBytes;
                List<string> lines = new List<string>();

                //// Get the stream of the content.
                //using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                //{
                //    // Write the output.
                //    lines.Add(await reader.ReadToEndAsync());
                //}
                richTextBox_response.Lines = lines.ToArray();
                int i=0;
                List<byte[]> sfdus = deliminateSFDU(data,ref i);
                if(Config.debugLevel == DebugLevel.FULL)
                {
                    File.WriteAllBytes(@".\queryResult", data);
                }
                SendUDPBuffer(label_Progress,sfdus);
            }
            catch (Exception e)
            {

                richTextBox_response.Text = "ERROR";
            }
        }

        private void button_PostWithCookie_Click_1(object sender, EventArgs e)
        {
            webQueryCookie();
        }

        private void button_ExecuteStream_Click(object sender, EventArgs e)
        {
            QuerySession qs = new QuerySession(textBox_testServer.Text, AppConfig.RequstTimeout, textBox_testURI.Text, AppConfig.ProxyServerUsage, AppConfig.ProxyServerAddress, AppConfig.ProxyPort);
            qs.restRequest.ResponseWriter = new Action<Stream>(ReadStream);

            qs.ExecuteRequest();
           // qs.restResponse.RawBytes;
            //qs.ExecuteRequestStream();
        }

        private void button_GetCookieChrome_Click(object sender, EventArgs e)
        {
            bool f = Chrome.GetCookie_Chrome("jpl.nasa.gov", "noccSsoToken", ref token);
        }

        private void button_LoadStream_Click(object sender, EventArgs e)
        {
            if (openFileDialog_load.ShowDialog() == DialogResult.OK)
            {
                dataStack = new Queue<byte[]>();
                FileInfo f = new FileInfo(openFileDialog_load.FileName);

                FileStream fs = new FileStream(openFileDialog_load.FileName,FileMode.Open);
          //      byte[] text = File.ReadAllBytes(f.FullName);
              //  MemoryStream theMemStream = new MemoryStream();
                //theMemStream.Write(text, 0, text.Length);
                //theMemStream.Position = 0;
                ReadStream(fs);
                SendUDPBuffer(label_Progress,dataStack.ToList());
            }
            
        }

        private void dataGridView_queryServers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView d = (DataGridView)(sender);
            if ( e.RowIndex!=-1 && e.ColumnIndex!=-1 && (e.RowIndex+1)<d.RowCount)
            {
              
                d.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void timer_LoopAgain_Tick(object sender, EventArgs e)
        {
            int interval = AppConfig.RequestInterval*60*1000;

            double diff = (DateTime.Now - lastQuery).TotalMilliseconds;

            double prog =100- ((double)diff / (double)interval)*100;
            if (diff > interval)
                prog = 0;
            progressBar_queryLoopEnd.Value = (int)prog;

        }

        private void textBox_DSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            dataGridView_addresses.Rows.Clear();
            dataGridView_ports.Rows.Clear();
        }

        private void button_FTP_Click(object sender, EventArgs e)
        {
     
          
            SFTP s = new SFTP(Settings.Default.sftpIP, Settings.Default.sftpUser,Settings.Default.sftpKetFileDir);
            string[] files = s.ListDir(Settings.Default.sftpDir,Settings.Default.sftpFileHeader);
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
               
            LoadSFTPthread();
        }
        bool sftpRunning = false;
        Thread SFTPload;
        private void LoadSFTPthread()
        {
            if(!sftpRunning)
            {
              
                sftpRunning = true;
                SFTPload = new Thread(LoadSFTP);
                SFTPload.Start();
            }
            else
            {
                addToLog("SFTP already loading...", Color.Yellow);
            }

        }

            private void LoadSFTP()
        {
            addToLog("SFTP loading...");
            objectListView_SFTPlist.ClearObjects();

            try
            {

            string baseURI = Settings.Default.sftpDir;
           SFTP s = new SFTP(Settings.Default.sftpIP, Settings.Default.sftpUser, Settings.Default.sftpKetFileDir);
            string[] files = s.ListDir(baseURI,Settings.Default.sftpFileHeader);
            foreach (string file in files)
            {
                label_Loading.Invoke(new MethodInvoker(() => { label_Loading.Visible = true; }));

             
                string name = Path.GetFileName(file);
             

                DateTime d = s.GetFileDate(file);
                SFTPrecord record = new SFTPrecord();
                record.fileName = name;
                record.fullName = file;
                record.creationDate = d;
               // ListViewItem lvi = new ListViewItem(new string[] { name, d.ToString() });

                //     listView_SFDUs.Items.Add(lvi);
                objectListView_SFTPlist.AddObject(record);
               
            }
            label_Loading.Invoke(new MethodInvoker(() => { label_Loading.Visible = false; }));
            addToLog("SFTP loading finished",Color.Green);

            }
            catch (Exception e)
            {

                addToLog("SFTP loading failed : "+e.Message, Color.Red);
            }
            sftpRunning = false;
        }
        class SFTPrecord
        {
            public string fileName { get; set; }
            public DateTime creationDate { get; set; }
            public string fullName { get; set; }
        }
        private void button_SFTP_Click(object sender, EventArgs e)
        {
            tabControl_tabs.SelectedIndex = 4;
            highlight_selected_button(sender);
            
        }

    //    List<byte[]> loadedSFDU;
        private void objectListView_SFTPlist_DoubleClick(object sender, EventArgs e)
        {
            label_Loading.Visible = true ;
            SFTPrecord rec = (SFTPrecord)objectListView_SFTPlist.SelectedObject;
            SFTP s = new SFTP(Settings.Default.sftpIP, Settings.Default.sftpUser, Settings.Default.sftpKetFileDir);

            byte[] bytes = s.DownloadFile(rec.fullName);

            int i = 0;

            label_SFDU_FILENAME.Text = rec.fileName;
            List<byte[]> loadedSFDU = deliminateSFDU(bytes, ref i);
            updateProgress(label_SFDU_PROG, 0, loadedSFDU.Count);

            objectListView_queued.AddObject(rec);
            label_Loading.Visible = false;
            //   SendUDPBuffer(sfdus);
        }

        private void button_sendLoadedFile_Click(object sender, EventArgs e)
        {
            List<SFTPrecord> objects = objectListView_queued.Objects.Cast<SFTPrecord>().ToList();
            List<byte[]> totalSFDUs = new List<byte[]>();
            foreach (SFTPrecord item in objects)
            {
             //   objectListView_queued.SelectedObject = item;
              //  objectListView_queued.row
          //      SFTPrecord rec = (SFTPrecord)objectListView_SFTPlist.SelectedObject;
                SFTP s = new SFTP(Settings.Default.sftpIP, Settings.Default.sftpUser, Settings.Default.sftpKetFileDir);

                
                byte[] bytes = s.DownloadFile(item.fullName);

                int i = 0;

                label_SFDU_FILENAME.Text = item.fileName;
                List<byte[]> loadedSFDU = deliminateSFDU(bytes, ref i);
                updateProgress(label_SFDU_PROG, 0, loadedSFDU.Count);
                totalSFDUs.AddRange(loadedSFDU);
                objectListView_queued.RemoveObject(item);
            }

            SendUDPBuffer(label_SFDU_PROG, totalSFDUs);

        }

        private void objectListView_queued_DoubleClick(object sender, EventArgs e)
        {
            objectListView_queued.RemoveObject(objectListView_queued.SelectedObject);
        }

        private void timer_CheckSFTP_Tick(object sender, EventArgs e)
        {
            LoadSFTPthread();
        }



        ///// <summary>
        ///// Adds text into a System.Windows.Forms.ProgressBar
        ///// </summary>
        ///// <param name="Target">The target progress bar to add text into</param>
        ///// <param name="Text">The text to add into the progress bar. 
        ///// Leave null or empty to automatically add the percent.</param>
        ///// <param name="Location">Where the text is to be placed</param>
        ///// <param name="TextColor">The color the text should be drawn in</param>
        ///// <param name="TextFont">The font the text should be drawn in</param>
        //private void SetProgressBarText
        //    (
        //    System.Windows.Forms.ProgressBar Target, //The target progress bar
        //    string Text, //The text to show in the progress bar
        //    ProgressBarTextLocation Location, //Where the text is to be placed
        //    System.Drawing.Color TextColor, //The color the text is to be drawn in
        //    System.Drawing.Font TextFont //The font we use to draw the text
        //    )
        //{

        //    //Make sure we didn't get a null progress bar
        //    if (Target == null) { throw new ArgumentException("Null Target"); }

        //    //Now we can get to the real code

        //    //Check to see if we are to add in the percent
        //    if (string.IsNullOrEmpty(Text))
        //    {
        //        //We are to add in the percent meaning we got a null or empty Text
        //        //We give text a string value representing the percent
        //        int percent = (int)(((double)(Target.Value - Target.Minimum) /
        //            (double)(Target.Maximum - Target.Minimum)) * 100);
        //        Text = percent.ToString() + "%";
        //    }

        //    //Now we can add in the text

        //    //gr will be the graphics object we use to draw on Target
        //    using (Graphics gr = Target.CreateGraphics())
        //    {
        //        gr.DrawString(Text,
        //            TextFont, //The font we will draw it it (TextFont)
        //            new SolidBrush(TextColor), //The brush we will use to draw it

        //            //Where we will draw it
        //            new PointF(
        //                // X location (Center or Left)
        //                Location == ProgressBarTextLocation.Left ?
        //                5 : //Left side
        //                Target.Width / 2 - (gr.MeasureString(Text, //Centered
        //                TextFont).Width / 2.0F),
        //            // Y Location (This is the same regardless of Location)
        //            Target.Height / 2 - (gr.MeasureString(Text,
        //                TextFont).Height / 2.0F)));
        //    }
        //}

        //public enum ProgressBarTextLocation
        //{
        //    Left,
        //    Centered
        //}

    }
    public enum DebugLevel
    {
        NONE,
        FULL,
    }


}
