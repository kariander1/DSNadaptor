using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Data;
using DSNadaptor.Properties;
namespace DSNadaptor
{
    class Config
    {
        // private static Config singleton;

        public string ErrorMessage { get; set; }

        public int CheckConnectedInterval { get; set; }
        public static DebugLevel debugLevel { get; set; }
        public string debugFile { get; set; }

        public bool ProxyServerUsage  { get; set; }     // Using proxy server
        public string ProxyServerAddress { get; set; }  // Proxy server address
        public int ProxyPort { get; set; }              // Proxy server port

        public int DelayDelivery { get; set; }
        public bool CalcDelivery { get; set; }
        public int ByteRatio { get; set; }
        public List<string> UDPdests { get; set; }
        public List<int> UDPports { get; set; }

        public string WebTLMaddress { get; set; }
        public string SCID { get; set; }
        public string BaseURI { get; set; }
        public int RequstTimeout { get; set; }
        public int RequestInterval { get; set; }
        public int RequestRetries { get; set; }
        public string SFDUsync { get; set; }
        public List<string> QueryServers { get; set; }
        public int LengthAttributeOffset { get; set; }
        public int LengthAttributeSize { get; set; }
        public int RetryInterval { get; set; }
        public int bufferSize { get; set; }
        public int ReadStreamInterval { get; set; }

        public bool UseAuthentication { get; set; }
        public string OpenAMuser { get; set; }
        public string OpenAMpassword { get; set; }
        public string OpenAMserver { get; set; }
        public string CookieURI { get; set; }
        public string TokenIdURI { get; set; }
        public string CookieDefaultName { get; set; }
        public string CookieDomain { get; set; }
        public int tokenValidity { get; set; }

        public List<PVLblock> PVLblocks { get; set; }
        public string PVLdataStart { get; set; }


        public Config()
        {
            this.ErrorMessage = "";
            // Get parameters from configuration file
            GetSettingsparameters();
        }

        /// <summary>
        /// Set New Config Parameters to configuration file
        /// </summary>
        /// <param name="newbTlmOnline"></param>
        /// <param name="newbWriteTlmToFile"></param>
        /// <param name="newbSendTlmToTlmServer"></param>
        /// <param name="newjPLMcastIP"></param>
        /// <param name="newjPLMcastPort"></param>
        /// <param name="newtlmServerMcastIP"></param>
        /// <param name="newtlmServerMcastPort"></param>
        public bool SetNewConfigParameters(int checkConnectedInterval, bool proxyUsage, string proxyadd, int proxyport, int deliverydelay, bool calcdelay, int byteratio, List<string> udpadds, List<string> udpports, string tlmWebAdd, string scid, string baseURI, int reqTO, int reqInterval, int reqRetry, string sfduSync, List<string> queryServers, string amUser, string amPassword, string amCookie,string amAuthenticate,bool useAU)
        {
            //this.ProxyServerUsage = proxyUsage;
            //this.ProxyServerAddress = proxyadd;
            //this.ProxyPort = proxyport;
            try
            {
                Settings.Default.ConnectionInterval = checkConnectedInterval;

                Settings.Default.ProxyServerUsage = proxyUsage;
                Settings.Default.ProxyServerAddress = proxyadd;
                Settings.Default.ProxyServerPort = proxyport;

                Settings.Default.deliveryDelay = deliverydelay;
                Settings.Default.calcDelay = calcdelay;
                Settings.Default.ByteToDelayRatio = ByteRatio;
                Settings.Default.udpDestIP.Clear();
                Settings.Default.udpDestIP.AddRange(udpadds.ToArray());
                Settings.Default.udpPort.Clear();
                Settings.Default.udpPort.AddRange(udpports.ToArray());
                //SetLastConfig();        // Set last values to Config file

                Settings.Default.TLMwebServer = tlmWebAdd;
                Settings.Default.SpacecraftID = scid;
                Settings.Default.BaseURI = baseURI;

                Settings.Default.RequestTimeout = RequstTimeout;
                Settings.Default.RequestInterval = reqInterval;
                Settings.Default.RequestRetries = RequestRetries;
                Settings.Default.SFDUsync = sfduSync;
                Settings.Default.QueryServers.Clear();
                Settings.Default.QueryServers.AddRange(queryServers.ToArray());

                Settings.Default.UseAuthentication = useAU;
                Settings.Default.OpenAM_username = amUser;
                Settings.Default.OpenAM_password = amPassword;
              //  Settings.Default.OpenAM_server = amServer;
                Settings.Default.OpenAM_CookieRetrievalURI = amCookie;
                Settings.Default.OpenAM_AuthenticationURI = amAuthenticate;
              //  Settings.Default.CookieValidity = 
                
         //       Settings.Default.PVLheaders.AddRange() //TODO add

                Settings.Default.Save();
                GetSettingsparameters();

                return true;
            }
            catch (Exception e)
            {
                this.ErrorMessage = e.Message;
                return false;
            }
        }

        private List<string> addCollectionsToSetting(List<string> destList, System.Collections.Specialized.StringCollection sourceList)
        {
            destList = new List<string>();
          
            foreach (string item in sourceList)
            {

                
                {
                    destList.Add(item);
                }
           
            }
            return destList;
        }
        private List<int> addCollectionsToSetting(List<int> destList, System.Collections.Specialized.StringCollection sourceList)
        {
            destList = new List<int>();

            foreach (string item in sourceList)
            {


                {
                    destList.Add(int.Parse(item));
                }

            }
            return destList;
        }

        #region Config File
        /// <summary>
        /// Get parameters from configuration file
        /// </summary>
        private void GetSettingsparameters()
        {
            try
            {
                // Define default values to configuration
                SetDefaultValues();
                //config_file = Path.Combine(appRoot, "Config\\JPL_TelemetryHandler_Config.xml");
                //config_file = @".\DSNadaptor.exe.config";
                //ConfigDataSet = new DataSet("DSNadaptor_Config");
                //ConfigDataSet.ReadXml(config_file);
            }
            catch (Exception e)
            {
                // set default values
                // SetDefaultConfig();
                this.ErrorMessage = "Error setting default values : " + e.Message;
            }

           // DataRow dr = ConfigDataSet.Tables["Config"].Rows[0];
            try
            {
                this.CheckConnectedInterval = Settings.Default.ConnectionInterval;
                debugLevel =(DebugLevel) Enum.Parse(typeof(DebugLevel), Settings.Default.DebugLevel);
                this.debugFile = Settings.Default.DebugFile;

                this.ProxyServerAddress = Settings.Default.ProxyServerAddress;
                this.ProxyServerUsage = Settings.Default.ProxyServerUsage;
                this.ProxyPort = Settings.Default.ProxyServerPort;

                this.DelayDelivery = Settings.Default.deliveryDelay;
                this.CalcDelivery = Settings.Default.calcDelay;
                this.ByteRatio = Settings.Default.ByteToDelayRatio;



                this.UDPdests = addCollectionsToSetting(this.UDPdests, Settings.Default.udpDestIP);


                this.UDPports= addCollectionsToSetting(this.UDPports, Settings.Default.udpPort);

                this.WebTLMaddress = Settings.Default.TLMwebServer;
                this.SCID = Settings.Default.SpacecraftID;
                this.BaseURI = Settings.Default.BaseURI;
                this.RequstTimeout = Settings.Default.RequestTimeout;
                this.RequestInterval = Settings.Default.RequestInterval;
                this.RequestRetries = Settings.Default.RequestRetries;
                this.SFDUsync = Settings.Default.SFDUsync;
                this.QueryServers = addCollectionsToSetting(this.QueryServers,Settings.Default.QueryServers);
                this.LengthAttributeOffset = Settings.Default.LengthAttributeOffset;
                this.LengthAttributeSize = Settings.Default.LengthAttributeSize;
                this.RetryInterval = Settings.Default.RetryInterval;
                this.bufferSize = Settings.Default.BufferSize;
                this.ReadStreamInterval = Settings.Default.ReadStreamInterval;
                this.UseAuthentication = Settings.Default.UseAuthentication;
                this.OpenAMuser = Settings.Default.OpenAM_username;
                this.OpenAMpassword = Settings.Default.OpenAM_password;
                this.OpenAMserver = Settings.Default.OpenAM_server;
                this.CookieURI = Settings.Default.OpenAM_CookieRetrievalURI;
                this.TokenIdURI= Settings.Default.OpenAM_AuthenticationURI;
                this.CookieDefaultName = Settings.Default.CookieDefaultName;
                this.CookieDomain = Settings.Default.CookieDomainName;
                this.tokenValidity = Settings.Default.TokenValidity;

                this.PVLblocks = new List<PVLblock>();
                foreach (string item in Settings.Default.PVLblocks)
                {
                    string[] segs = item.Split(',');
                    PVLblocks.Add(new PVLblock(segs[0],segs[1],segs[2]));
                }
               this.PVLdataStart = Settings.Default.PVLdataStart;

                //bTlmOnline = dr["JplTelemetryConfig"].ToString().ToUpper() == "ONLINE" ? true : false;

                //try { bWriteTlmToFile = System.Convert.ToBoolean(dr["WriteTlmToFile"]); }
                //catch { bWriteTlmToFile = true; }

                //try { bSendTlmToTlmServer = System.Convert.ToBoolean(dr["SendTlmToTlmServer"]); }
                //catch { bSendTlmToTlmServer = true; }

                //jPLMcastIP = dr["JplMcastIP"].ToString().ToUpper();
                //try { jPLMcastPort = Convert.ToUInt16(dr["JplMcastPORT"]); }
                //catch { jPLMcastPort = 8500; }

                //tlmServerMcastIP = dr["TlmServerMcastIP"].ToString().ToUpper();
                //try { tlmServerMcastPort = Convert.ToUInt16(dr["TlmServerMcastPort"]); }
                //catch { tlmServerMcastPort = 3090; }
            }
            catch (Exception ex)
            {
                this.ErrorMessage = "Error reading values from config : "+ex.Message;
            }
        }

        /// <summary>
        /// Set Default values to Config file
        /// </summary>
        //private void SetDefaultConfig()
        //{
        //    // Create a DataSet to hold data to/from xml config file.
        //    ConfigDataSet = new DataSet("JPL_TelemetryHandler_Config");
        //    ConfigDataSet.Tables.Add("Config");

        //    // Build table
        //    DataColumn col1 = new DataColumn("JplTelemetryConfig", typeof(string));
        //    DataColumn col2 = new DataColumn("WriteTlmToFile", typeof(Boolean));
        //    DataColumn col3 = new DataColumn("SendTlmToTlmServer", typeof(Boolean));
        //    DataColumn col4 = new DataColumn("JplMcastIP", typeof(string));
        //    DataColumn col5 = new DataColumn("JplMcastPORT", typeof(int));
        //    DataColumn col6 = new DataColumn("TlmServerMcastIP", typeof(string));
        //    DataColumn col7 = new DataColumn("TlmServerMcastPort", typeof(int));
        //    ConfigDataSet.Tables["Config"].Columns.AddRange(new DataColumn[] { col1, col2, col3, col4, col5, col6, col7 });

        //    // Set last values to Config file
        //    SetLastConfig();
        //}

        /// <summary>
        /// Define default values to configuration
        /// </summary>
        private void SetDefaultValues()
        {
            this.CheckConnectedInterval = 60000;
            debugLevel = DebugLevel.NONE;
            this.debugFile = @".\DSNdebug";

            this.ProxyServerUsage = false;
            this.ProxyServerAddress = "localhost";
            this.ProxyPort = 80;

            this.DelayDelivery = 50;
            this.CalcDelivery = false;
            this.ByteRatio = 20;

            this.UDPdests = new List<string>();
            this.UDPdests.Add("227.30.30.30");
            this.UDPports = new List<int>();
            this.UDPports.Add(8500);

            this.WebTLMaddress = "tlmweb.jpl.nasa.gov";
            this.SCID = "147";
            this.BaseURI = @"https://<server>/ttcws/";
            this.SFDUsync = "NJPL2I";
            this.RequstTimeout = 5000;
            this.RequestInterval = 720;
            this.RequestRetries = 10;
            this.QueryServers = new List<string>();
            this.QueryServers.Add("Gif_spil1");
         //   this.QueryServers.Add("Gif_spil2");
            this.bufferSize = 1024;
            this.ReadStreamInterval = 0;


            this.LengthAttributeOffset = 12;
            this.LengthAttributeSize = 8;
          


            this.OpenAMuser = "geron";
            this.OpenAMpassword = "Q010=On_Ground";
            this.CookieURI= "/cam/identity/getCookieNameForToken";
            this.TokenIdURI = "/cam/identity/authenticate";
            this.OpenAMserver = "tlmweb.jpl.nasa.gov";
            this.UseAuthentication = false;

             this.PVLdataStart = "TDS Status";

        }

        /// <summary>
        /// Set last values to Config file
        ///// </summary>
        //private void SetLastConfig()
        //{
        //    ConfigDataSet.Tables["Config"].Rows.Clear();
        //    DataRow dr = ConfigDataSet.Tables["Config"].NewRow();

        //    if (bTlmOnline)
        //        dr["JplTelemetryConfig"] = "ONLINE";
        //    else
        //        dr["JplTelemetryConfig"] = "OFFLINE";

        //    dr["WriteTlmToFile"] = bWriteTlmToFile ? "true" : "false";
        //    dr["SendTlmToTlmServer"] = bSendTlmToTlmServer ? "true" : "false";
        //    dr["JplMcastIP"] = jPLMcastIP;
        //    dr["JplMcastPORT"] = jPLMcastPort.ToString();
        //    dr["TlmServerMcastIP"] = tlmServerMcastIP;
        //    dr["TlmServerMcastPort"] = tlmServerMcastPort.ToString();

        //    ConfigDataSet.Tables["Config"].Rows.Add(dr);

        //    try
        //    {
        //        //// Check if the Config direcory exists, if not, create it.
        //        //string FileLocation = Path.Combine(appRoot, "Config");
        //        //if (!Directory.Exists(FileLocation))
        //        //    Directory.CreateDirectory(FileLocation);
        //        ConfigDataSet.WriteXml(config_file);
        //    }
        //    catch (Exception ex)
        //    {
        //        string str = ex.Message;
        //    }
        //}

        #endregion Config File

    }
}
