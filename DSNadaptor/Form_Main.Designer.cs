namespace DSNadaptor
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_left = new System.Windows.Forms.Panel();
            this.button_SFTP = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_APItest = new System.Windows.Forms.Button();
            this.button_manual = new System.Windows.Forms.Button();
            this.button_DSN = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.tabControl_tabs = new System.Windows.Forms.TabControl();
            this.tabPage_dsn = new System.Windows.Forms.TabPage();
            this.textBox_DSS = new System.Windows.Forms.TextBox();
            this.label_dss = new System.Windows.Forms.Label();
            this.label_queryEnd = new System.Windows.Forms.Label();
            this.label_queryStart = new System.Windows.Forms.Label();
            this.dateTimePicker_queryEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_queryStart = new System.Windows.Forms.DateTimePicker();
            this.comboBox_QueryServers = new System.Windows.Forms.ComboBox();
            this.label_queryServers = new System.Windows.Forms.Label();
            this.panel_connections = new System.Windows.Forms.Panel();
            this.progressBar_queryLoopEnd = new System.Windows.Forms.ProgressBar();
            this.label_SFDUsent = new System.Windows.Forms.Label();
            this.label_SfduRead = new System.Windows.Forms.Label();
            this.pictureBox_web = new System.Windows.Forms.PictureBox();
            this.label_queueCount = new System.Windows.Forms.Label();
            this.pictureBox_adaptor = new System.Windows.Forms.PictureBox();
            this.label_queuesize = new System.Windows.Forms.Label();
            this.label_adaptor = new System.Windows.Forms.Label();
            this.pictureBox_adapt2scc = new System.Windows.Forms.PictureBox();
            this.label_tlmWeb = new System.Windows.Forms.Label();
            this.pictureBox_web2adapt = new System.Windows.Forms.PictureBox();
            this.pictureBox_scc = new System.Windows.Forms.PictureBox();
            this.pictureBox_adapt2web = new System.Windows.Forms.PictureBox();
            this.label_TLMdest = new System.Windows.Forms.Label();
            this.button_listen = new System.Windows.Forms.Button();
            this.pictureBox_request = new System.Windows.Forms.PictureBox();
            this.label_ValidRequest = new System.Windows.Forms.Label();
            this.textBox_server = new System.Windows.Forms.TextBox();
            this.pictureBox_ping = new System.Windows.Forms.PictureBox();
            this.label_ping = new System.Windows.Forms.Label();
            this.pictureBox_authenticated = new System.Windows.Forms.PictureBox();
            this.label_authenticated = new System.Windows.Forms.Label();
            this.pictureBox_localIP = new System.Windows.Forms.PictureBox();
            this.label_localIP = new System.Windows.Forms.Label();
            this.pictureBox_connected = new System.Windows.Forms.PictureBox();
            this.label_connected = new System.Windows.Forms.Label();
            this.tabPage_testapi = new System.Windows.Forms.TabPage();
            this.button_FTP = new System.Windows.Forms.Button();
            this.button_LoadStream = new System.Windows.Forms.Button();
            this.button_GetCookieChrome = new System.Windows.Forms.Button();
            this.button_ExecuteStream = new System.Windows.Forms.Button();
            this.button_PostWithCookie = new System.Windows.Forms.Button();
            this.button_GetToken = new System.Windows.Forms.Button();
            this.button_GetCookie = new System.Windows.Forms.Button();
            this.label_Progress = new System.Windows.Forms.Label();
            this.richTextBox_response = new System.Windows.Forms.RichTextBox();
            this.progressBar_prog = new System.Windows.Forms.ProgressBar();
            this.button_loadFile = new System.Windows.Forms.Button();
            this.button_Parse = new System.Windows.Forms.Button();
            this.checkBox_deliminate = new System.Windows.Forms.CheckBox();
            this.textBox_UDPport = new System.Windows.Forms.TextBox();
            this.textBox_destUDPip = new System.Windows.Forms.TextBox();
            this.label_udpPort = new System.Windows.Forms.Label();
            this.label_destUDP = new System.Windows.Forms.Label();
            this.button_udpTest = new System.Windows.Forms.Button();
            this.label_UDPtest = new System.Windows.Forms.Label();
            this.textBox_testURI = new System.Windows.Forms.TextBox();
            this.textBox_testServer = new System.Windows.Forms.TextBox();
            this.button_testExecute = new System.Windows.Forms.Button();
            this.label_testURI = new System.Windows.Forms.Label();
            this.label_TestServer = new System.Windows.Forms.Label();
            this.label_apiTEST = new System.Windows.Forms.Label();
            this.tabPage_manual = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.panel_openAMSettings = new System.Windows.Forms.Panel();
            this.checkBox_useAu = new System.Windows.Forms.CheckBox();
            this.textBox_AuURI = new System.Windows.Forms.TextBox();
            this.label_UseAU = new System.Windows.Forms.Label();
            this.label_AUuri = new System.Windows.Forms.Label();
            this.textBox_CookieURI = new System.Windows.Forms.TextBox();
            this.label_Cookie = new System.Windows.Forms.Label();
            this.textBox_AMpassword = new System.Windows.Forms.TextBox();
            this.label_AMpassword = new System.Windows.Forms.Label();
            this.textBox_AMuser = new System.Windows.Forms.TextBox();
            this.label_AMuser = new System.Windows.Forms.Label();
            this.textBox_AMserver = new System.Windows.Forms.TextBox();
            this.label_OpenAMserver = new System.Windows.Forms.Label();
            this.label_AuSettings = new System.Windows.Forms.Label();
            this.panel_metadatasettings = new System.Windows.Forms.Panel();
            this.numericUpDown_MonitorInterval = new System.Windows.Forms.NumericUpDown();
            this.label_CheckCOnnected = new System.Windows.Forms.Label();
            this.label_metadata = new System.Windows.Forms.Label();
            this.panel_UDPsettings = new System.Windows.Forms.Panel();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_ms = new System.Windows.Forms.Label();
            this.numericUpDown_byteratio = new System.Windows.Forms.NumericUpDown();
            this.label_ByteRatio = new System.Windows.Forms.Label();
            this.checkBox_calcDelay = new System.Windows.Forms.CheckBox();
            this.label_CalcDelay = new System.Windows.Forms.Label();
            this.numericUpDown_deliveryDelay = new System.Windows.Forms.NumericUpDown();
            this.label_DeliveryDelay = new System.Windows.Forms.Label();
            this.dataGridView_ports = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_addresses = new System.Windows.Forms.DataGridView();
            this.Column_addresses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_UDPports = new System.Windows.Forms.Label();
            this.label_udpAddresses = new System.Windows.Forms.Label();
            this.label_udpSettings = new System.Windows.Forms.Label();
            this.panel_restAPI = new System.Windows.Forms.Panel();
            this.dataGridView_queryServers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_queryServer = new System.Windows.Forms.Label();
            this.textBox_SFDUsync = new System.Windows.Forms.TextBox();
            this.label_sfdusync = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.numericUpDown_RequestRetry = new System.Windows.Forms.NumericUpDown();
            this.label_Retries = new System.Windows.Forms.Label();
            this.label_reqinms = new System.Windows.Forms.Label();
            this.numericUpDown_RequestInterval = new System.Windows.Forms.NumericUpDown();
            this.label_RequestInterval = new System.Windows.Forms.Label();
            this.label_reqMs = new System.Windows.Forms.Label();
            this.numericUpDown_RequestTimeout = new System.Windows.Forms.NumericUpDown();
            this.label_RequestTimeout = new System.Windows.Forms.Label();
            this.label_baseURIcomment = new System.Windows.Forms.Label();
            this.textBox_BaseURI = new System.Windows.Forms.TextBox();
            this.label_BaseURI = new System.Windows.Forms.Label();
            this.textBox_SCID = new System.Windows.Forms.TextBox();
            this.label_SpacecraftID = new System.Windows.Forms.Label();
            this.textBox_webTLMaddress = new System.Windows.Forms.TextBox();
            this.label_webTLMserver = new System.Windows.Forms.Label();
            this.label_APIrest = new System.Windows.Forms.Label();
            this.panel_proxy = new System.Windows.Forms.Panel();
            this.numericUpDown_port = new System.Windows.Forms.NumericUpDown();
            this.label_proxyport = new System.Windows.Forms.Label();
            this.checkBox_useProxy = new System.Windows.Forms.CheckBox();
            this.label_useProxy = new System.Windows.Forms.Label();
            this.textBox_proxyaddress = new System.Windows.Forms.TextBox();
            this.label_proxyServer = new System.Windows.Forms.Label();
            this.label_proxySettings = new System.Windows.Forms.Label();
            this.tabPage_SFTP = new System.Windows.Forms.TabPage();
            this.label1_SFDU_queue = new System.Windows.Forms.Label();
            this.objectListView_queued = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label_Loading = new System.Windows.Forms.Label();
            this.label_SFDU_PROG = new System.Windows.Forms.Label();
            this.button_sendLoadedFile = new System.Windows.Forms.Button();
            this.label_SFDU_FILENAME = new System.Windows.Forms.Label();
            this.objectListView_SFTPlist = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn_FileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_FileDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_refresh = new System.Windows.Forms.Button();
            this.listView_log = new System.Windows.Forms.ListView();
            this.columnHeader_timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.button_quit = new System.Windows.Forms.Button();
            this.timer_checkConnected = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog_load = new System.Windows.Forms.OpenFileDialog();
            this.timer_LoopAgain = new System.Windows.Forms.Timer(this.components);
            this.timer_CheckSFTP = new System.Windows.Forms.Timer(this.components);
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_main.SuspendLayout();
            this.tabControl_tabs.SuspendLayout();
            this.tabPage_dsn.SuspendLayout();
            this.panel_connections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_web)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_adaptor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_adapt2scc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_web2adapt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_scc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_adapt2web)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_request)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_authenticated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_localIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_connected)).BeginInit();
            this.tabPage_testapi.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.panel_openAMSettings.SuspendLayout();
            this.panel_metadatasettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MonitorInterval)).BeginInit();
            this.panel_UDPsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_byteratio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_deliveryDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_addresses)).BeginInit();
            this.panel_restAPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_queryServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RequestRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RequestInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RequestTimeout)).BeginInit();
            this.panel_proxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port)).BeginInit();
            this.tabPage_SFTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_queued)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_SFTPlist)).BeginInit();
            this.panel_toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.White;
            this.panel_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_left.Controls.Add(this.button_SFTP);
            this.panel_left.Controls.Add(this.button_settings);
            this.panel_left.Controls.Add(this.button_APItest);
            this.panel_left.Controls.Add(this.button_manual);
            this.panel_left.Controls.Add(this.button_DSN);
            this.panel_left.Controls.Add(this.pictureBox_logo);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(150, 650);
            this.panel_left.TabIndex = 1;
            // 
            // button_SFTP
            // 
            this.button_SFTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SFTP.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_SFTP.FlatAppearance.BorderSize = 0;
            this.button_SFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SFTP.Image = global::DSNadaptor.Properties.Resources.big_ssss_512;
            this.button_SFTP.Location = new System.Drawing.Point(0, 551);
            this.button_SFTP.Name = "button_SFTP";
            this.button_SFTP.Size = new System.Drawing.Size(148, 95);
            this.button_SFTP.TabIndex = 6;
            this.button_SFTP.Text = "SFTP";
            this.button_SFTP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_SFTP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_SFTP.UseVisualStyleBackColor = true;
            this.button_SFTP.Click += new System.EventHandler(this.button_SFTP_Click);
            // 
            // button_settings
            // 
            this.button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_settings.Image = global::DSNadaptor.Properties.Resources.Windows_Settings_app_icon;
            this.button_settings.Location = new System.Drawing.Point(0, 456);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(148, 95);
            this.button_settings.TabIndex = 5;
            this.button_settings.Text = "Settings";
            this.button_settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_APItest
            // 
            this.button_APItest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_APItest.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_APItest.FlatAppearance.BorderSize = 0;
            this.button_APItest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_APItest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_APItest.Image = global::DSNadaptor.Properties.Resources.test;
            this.button_APItest.Location = new System.Drawing.Point(0, 361);
            this.button_APItest.Name = "button_APItest";
            this.button_APItest.Size = new System.Drawing.Size(148, 95);
            this.button_APItest.TabIndex = 4;
            this.button_APItest.Text = "API Test";
            this.button_APItest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_APItest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_APItest.UseVisualStyleBackColor = true;
            this.button_APItest.Click += new System.EventHandler(this.button_APItest_Click);
            // 
            // button_manual
            // 
            this.button_manual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_manual.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_manual.FlatAppearance.BorderSize = 0;
            this.button_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manual.Image = global::DSNadaptor.Properties.Resources.Icons8_Ios7_Gaming_Joystick;
            this.button_manual.Location = new System.Drawing.Point(0, 266);
            this.button_manual.Name = "button_manual";
            this.button_manual.Size = new System.Drawing.Size(148, 95);
            this.button_manual.TabIndex = 3;
            this.button_manual.Text = "Manual";
            this.button_manual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_manual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_manual.UseVisualStyleBackColor = true;
            this.button_manual.Click += new System.EventHandler(this.button_manual_Click);
            // 
            // button_DSN
            // 
            this.button_DSN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_DSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DSN.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_DSN.FlatAppearance.BorderSize = 0;
            this.button_DSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DSN.Image = global::DSNadaptor.Properties.Resources.dish;
            this.button_DSN.Location = new System.Drawing.Point(0, 171);
            this.button_DSN.Name = "button_DSN";
            this.button_DSN.Size = new System.Drawing.Size(148, 95);
            this.button_DSN.TabIndex = 2;
            this.button_DSN.Text = "DSN";
            this.button_DSN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_DSN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_DSN.UseVisualStyleBackColor = false;
            this.button_DSN.Click += new System.EventHandler(this.button_DSN_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(148, 171);
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.Click += new System.EventHandler(this.pictureBox_logo_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.LightBlue;
            this.panel_main.Controls.Add(this.tabControl_tabs);
            this.panel_main.Controls.Add(this.listView_log);
            this.panel_main.Controls.Add(this.panel_toolbar);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(150, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(783, 650);
            this.panel_main.TabIndex = 3;
            // 
            // tabControl_tabs
            // 
            this.tabControl_tabs.Controls.Add(this.tabPage_dsn);
            this.tabControl_tabs.Controls.Add(this.tabPage_testapi);
            this.tabControl_tabs.Controls.Add(this.tabPage_manual);
            this.tabControl_tabs.Controls.Add(this.tabPageSettings);
            this.tabControl_tabs.Controls.Add(this.tabPage_SFTP);
            this.tabControl_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_tabs.Location = new System.Drawing.Point(0, 39);
            this.tabControl_tabs.Name = "tabControl_tabs";
            this.tabControl_tabs.SelectedIndex = 0;
            this.tabControl_tabs.Size = new System.Drawing.Size(783, 468);
            this.tabControl_tabs.TabIndex = 10;
            // 
            // tabPage_dsn
            // 
            this.tabPage_dsn.Controls.Add(this.textBox_DSS);
            this.tabPage_dsn.Controls.Add(this.label_dss);
            this.tabPage_dsn.Controls.Add(this.label_queryEnd);
            this.tabPage_dsn.Controls.Add(this.label_queryStart);
            this.tabPage_dsn.Controls.Add(this.dateTimePicker_queryEnd);
            this.tabPage_dsn.Controls.Add(this.dateTimePicker_queryStart);
            this.tabPage_dsn.Controls.Add(this.comboBox_QueryServers);
            this.tabPage_dsn.Controls.Add(this.label_queryServers);
            this.tabPage_dsn.Controls.Add(this.panel_connections);
            this.tabPage_dsn.Controls.Add(this.button_listen);
            this.tabPage_dsn.Controls.Add(this.pictureBox_request);
            this.tabPage_dsn.Controls.Add(this.label_ValidRequest);
            this.tabPage_dsn.Controls.Add(this.textBox_server);
            this.tabPage_dsn.Controls.Add(this.pictureBox_ping);
            this.tabPage_dsn.Controls.Add(this.label_ping);
            this.tabPage_dsn.Controls.Add(this.pictureBox_authenticated);
            this.tabPage_dsn.Controls.Add(this.label_authenticated);
            this.tabPage_dsn.Controls.Add(this.pictureBox_localIP);
            this.tabPage_dsn.Controls.Add(this.label_localIP);
            this.tabPage_dsn.Controls.Add(this.pictureBox_connected);
            this.tabPage_dsn.Controls.Add(this.label_connected);
            this.tabPage_dsn.Location = new System.Drawing.Point(4, 22);
            this.tabPage_dsn.Name = "tabPage_dsn";
            this.tabPage_dsn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_dsn.Size = new System.Drawing.Size(775, 442);
            this.tabPage_dsn.TabIndex = 0;
            this.tabPage_dsn.Text = "DSN";
            this.tabPage_dsn.UseVisualStyleBackColor = true;
            // 
            // textBox_DSS
            // 
            this.textBox_DSS.Location = new System.Drawing.Point(87, 219);
            this.textBox_DSS.Name = "textBox_DSS";
            this.textBox_DSS.Size = new System.Drawing.Size(100, 20);
            this.textBox_DSS.TabIndex = 31;
            this.textBox_DSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_DSS_KeyPress);
            // 
            // label_dss
            // 
            this.label_dss.AutoSize = true;
            this.label_dss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dss.Location = new System.Drawing.Point(38, 217);
            this.label_dss.Name = "label_dss";
            this.label_dss.Size = new System.Drawing.Size(43, 20);
            this.label_dss.TabIndex = 30;
            this.label_dss.Text = "DSS";
            // 
            // label_queryEnd
            // 
            this.label_queryEnd.AutoSize = true;
            this.label_queryEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_queryEnd.Location = new System.Drawing.Point(465, 216);
            this.label_queryEnd.Name = "label_queryEnd";
            this.label_queryEnd.Size = new System.Drawing.Size(84, 20);
            this.label_queryEnd.TabIndex = 29;
            this.label_queryEnd.Text = "Query End";
            // 
            // label_queryStart
            // 
            this.label_queryStart.AutoSize = true;
            this.label_queryStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_queryStart.Location = new System.Drawing.Point(465, 190);
            this.label_queryStart.Name = "label_queryStart";
            this.label_queryStart.Size = new System.Drawing.Size(90, 20);
            this.label_queryStart.TabIndex = 28;
            this.label_queryStart.Text = "Query Start";
            // 
            // dateTimePicker_queryEnd
            // 
            this.dateTimePicker_queryEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_queryEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimePicker_queryEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_queryEnd.Location = new System.Drawing.Point(571, 216);
            this.dateTimePicker_queryEnd.Name = "dateTimePicker_queryEnd";
            this.dateTimePicker_queryEnd.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker_queryEnd.TabIndex = 27;
            // 
            // dateTimePicker_queryStart
            // 
            this.dateTimePicker_queryStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_queryStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimePicker_queryStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_queryStart.Location = new System.Drawing.Point(571, 190);
            this.dateTimePicker_queryStart.Name = "dateTimePicker_queryStart";
            this.dateTimePicker_queryStart.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker_queryStart.TabIndex = 26;
            // 
            // comboBox_QueryServers
            // 
            this.comboBox_QueryServers.FormattingEnabled = true;
            this.comboBox_QueryServers.Location = new System.Drawing.Point(572, 163);
            this.comboBox_QueryServers.Name = "comboBox_QueryServers";
            this.comboBox_QueryServers.Size = new System.Drawing.Size(142, 21);
            this.comboBox_QueryServers.TabIndex = 25;
            // 
            // label_queryServers
            // 
            this.label_queryServers.AutoSize = true;
            this.label_queryServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_queryServers.Location = new System.Drawing.Point(465, 161);
            this.label_queryServers.Name = "label_queryServers";
            this.label_queryServers.Size = new System.Drawing.Size(101, 20);
            this.label_queryServers.TabIndex = 24;
            this.label_queryServers.Text = "Query Server";
            // 
            // panel_connections
            // 
            this.panel_connections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_connections.Controls.Add(this.progressBar_queryLoopEnd);
            this.panel_connections.Controls.Add(this.label_SFDUsent);
            this.panel_connections.Controls.Add(this.label_SfduRead);
            this.panel_connections.Controls.Add(this.pictureBox_web);
            this.panel_connections.Controls.Add(this.label_queueCount);
            this.panel_connections.Controls.Add(this.pictureBox_adaptor);
            this.panel_connections.Controls.Add(this.label_queuesize);
            this.panel_connections.Controls.Add(this.label_adaptor);
            this.panel_connections.Controls.Add(this.pictureBox_adapt2scc);
            this.panel_connections.Controls.Add(this.label_tlmWeb);
            this.panel_connections.Controls.Add(this.pictureBox_web2adapt);
            this.panel_connections.Controls.Add(this.pictureBox_scc);
            this.panel_connections.Controls.Add(this.pictureBox_adapt2web);
            this.panel_connections.Controls.Add(this.label_TLMdest);
            this.panel_connections.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_connections.Location = new System.Drawing.Point(3, 318);
            this.panel_connections.Name = "panel_connections";
            this.panel_connections.Size = new System.Drawing.Size(769, 121);
            this.panel_connections.TabIndex = 23;
            // 
            // progressBar_queryLoopEnd
            // 
            this.progressBar_queryLoopEnd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_queryLoopEnd.Location = new System.Drawing.Point(0, 109);
            this.progressBar_queryLoopEnd.Name = "progressBar_queryLoopEnd";
            this.progressBar_queryLoopEnd.Size = new System.Drawing.Size(767, 10);
            this.progressBar_queryLoopEnd.TabIndex = 26;
            // 
            // label_SFDUsent
            // 
            this.label_SFDUsent.AutoSize = true;
            this.label_SFDUsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SFDUsent.Location = new System.Drawing.Point(535, 22);
            this.label_SFDUsent.Name = "label_SFDUsent";
            this.label_SFDUsent.Size = new System.Drawing.Size(0, 16);
            this.label_SFDUsent.TabIndex = 25;
            // 
            // label_SfduRead
            // 
            this.label_SfduRead.AutoSize = true;
            this.label_SfduRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SfduRead.Location = new System.Drawing.Point(219, 96);
            this.label_SfduRead.Name = "label_SfduRead";
            this.label_SfduRead.Size = new System.Drawing.Size(0, 16);
            this.label_SfduRead.TabIndex = 24;
            // 
            // pictureBox_web
            // 
            this.pictureBox_web.BackgroundImage = global::DSNadaptor.Properties.Resources.web;
            this.pictureBox_web.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_web.Location = new System.Drawing.Point(38, 32);
            this.pictureBox_web.Name = "pictureBox_web";
            this.pictureBox_web.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_web.TabIndex = 14;
            this.pictureBox_web.TabStop = false;
            // 
            // label_queueCount
            // 
            this.label_queueCount.AutoSize = true;
            this.label_queueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_queueCount.Location = new System.Drawing.Point(398, 9);
            this.label_queueCount.Name = "label_queueCount";
            this.label_queueCount.Size = new System.Drawing.Size(0, 16);
            this.label_queueCount.TabIndex = 22;
            // 
            // pictureBox_adaptor
            // 
            this.pictureBox_adaptor.BackgroundImage = global::DSNadaptor.Properties.Resources.adaptor;
            this.pictureBox_adaptor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_adaptor.Location = new System.Drawing.Point(350, 32);
            this.pictureBox_adaptor.Name = "pictureBox_adaptor";
            this.pictureBox_adaptor.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_adaptor.TabIndex = 12;
            this.pictureBox_adaptor.TabStop = false;
            // 
            // label_queuesize
            // 
            this.label_queuesize.AutoSize = true;
            this.label_queuesize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_queuesize.Location = new System.Drawing.Point(345, 9);
            this.label_queuesize.Name = "label_queuesize";
            this.label_queuesize.Size = new System.Drawing.Size(51, 16);
            this.label_queuesize.TabIndex = 21;
            this.label_queuesize.Text = "Queue:";
            // 
            // label_adaptor
            // 
            this.label_adaptor.AutoSize = true;
            this.label_adaptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adaptor.Location = new System.Drawing.Point(340, 85);
            this.label_adaptor.Name = "label_adaptor";
            this.label_adaptor.Size = new System.Drawing.Size(66, 20);
            this.label_adaptor.TabIndex = 13;
            this.label_adaptor.Text = "Adaptor";
            // 
            // pictureBox_adapt2scc
            // 
            this.pictureBox_adapt2scc.BackgroundImage = global::DSNadaptor.Properties.Resources.arrow;
            this.pictureBox_adapt2scc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_adapt2scc.Location = new System.Drawing.Point(422, 41);
            this.pictureBox_adapt2scc.Name = "pictureBox_adapt2scc";
            this.pictureBox_adapt2scc.Size = new System.Drawing.Size(214, 32);
            this.pictureBox_adapt2scc.TabIndex = 20;
            this.pictureBox_adapt2scc.TabStop = false;
            this.pictureBox_adapt2scc.BackgroundImageChanged += new System.EventHandler(this.pictureBox_adapt2scc_BackgroundImageChanged);
            // 
            // label_tlmWeb
            // 
            this.label_tlmWeb.AutoSize = true;
            this.label_tlmWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tlmWeb.Location = new System.Drawing.Point(23, 85);
            this.label_tlmWeb.Name = "label_tlmWeb";
            this.label_tlmWeb.Size = new System.Drawing.Size(77, 20);
            this.label_tlmWeb.TabIndex = 15;
            this.label_tlmWeb.Text = "TLM Web";
            // 
            // pictureBox_web2adapt
            // 
            this.pictureBox_web2adapt.BackgroundImage = global::DSNadaptor.Properties.Resources.arrow;
            this.pictureBox_web2adapt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_web2adapt.Location = new System.Drawing.Point(119, 61);
            this.pictureBox_web2adapt.Name = "pictureBox_web2adapt";
            this.pictureBox_web2adapt.Size = new System.Drawing.Size(214, 32);
            this.pictureBox_web2adapt.TabIndex = 19;
            this.pictureBox_web2adapt.TabStop = false;
            this.pictureBox_web2adapt.BackgroundImageChanged += new System.EventHandler(this.pictureBox_adapt2scc_BackgroundImageChanged);
            // 
            // pictureBox_scc
            // 
            this.pictureBox_scc.BackgroundImage = global::DSNadaptor.Properties.Resources.monitor;
            this.pictureBox_scc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_scc.Location = new System.Drawing.Point(649, 32);
            this.pictureBox_scc.Name = "pictureBox_scc";
            this.pictureBox_scc.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_scc.TabIndex = 16;
            this.pictureBox_scc.TabStop = false;
            // 
            // pictureBox_adapt2web
            // 
            this.pictureBox_adapt2web.BackgroundImage = global::DSNadaptor.Properties.Resources.arrow;
            this.pictureBox_adapt2web.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_adapt2web.Location = new System.Drawing.Point(99, 25);
            this.pictureBox_adapt2web.Name = "pictureBox_adapt2web";
            this.pictureBox_adapt2web.Size = new System.Drawing.Size(214, 32);
            this.pictureBox_adapt2web.TabIndex = 18;
            this.pictureBox_adapt2web.TabStop = false;
            // 
            // label_TLMdest
            // 
            this.label_TLMdest.AutoSize = true;
            this.label_TLMdest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TLMdest.Location = new System.Drawing.Point(651, 85);
            this.label_TLMdest.Name = "label_TLMdest";
            this.label_TLMdest.Size = new System.Drawing.Size(78, 20);
            this.label_TLMdest.TabIndex = 17;
            this.label_TLMdest.Text = "TLM Dest";
            // 
            // button_listen
            // 
            this.button_listen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_listen.FlatAppearance.BorderSize = 0;
            this.button_listen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_listen.Image = global::DSNadaptor.Properties.Resources.dish;
            this.button_listen.Location = new System.Drawing.Point(311, 134);
            this.button_listen.Name = "button_listen";
            this.button_listen.Size = new System.Drawing.Size(148, 103);
            this.button_listen.TabIndex = 11;
            this.button_listen.Text = "Initiate";
            this.button_listen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_listen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_listen.UseVisualStyleBackColor = true;
            this.button_listen.Click += new System.EventHandler(this.button_listen_Click);
            // 
            // pictureBox_request
            // 
            this.pictureBox_request.BackgroundImage = global::DSNadaptor.Properties.Resources.radio_unchecked;
            this.pictureBox_request.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_request.Location = new System.Drawing.Point(621, 67);
            this.pictureBox_request.Name = "pictureBox_request";
            this.pictureBox_request.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_request.TabIndex = 10;
            this.pictureBox_request.TabStop = false;
            // 
            // label_ValidRequest
            // 
            this.label_ValidRequest.AutoSize = true;
            this.label_ValidRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValidRequest.Location = new System.Drawing.Point(449, 70);
            this.label_ValidRequest.Name = "label_ValidRequest";
            this.label_ValidRequest.Size = new System.Drawing.Size(109, 20);
            this.label_ValidRequest.TabIndex = 9;
            this.label_ValidRequest.Text = "Valid Request";
            // 
            // textBox_server
            // 
            this.textBox_server.Enabled = false;
            this.textBox_server.Location = new System.Drawing.Point(230, 107);
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.Size = new System.Drawing.Size(100, 20);
            this.textBox_server.TabIndex = 8;
            // 
            // pictureBox_ping
            // 
            this.pictureBox_ping.BackgroundImage = global::DSNadaptor.Properties.Resources.radio_unchecked;
            this.pictureBox_ping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_ping.Location = new System.Drawing.Point(194, 102);
            this.pictureBox_ping.Name = "pictureBox_ping";
            this.pictureBox_ping.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_ping.TabIndex = 7;
            this.pictureBox_ping.TabStop = false;
            // 
            // label_ping
            // 
            this.label_ping.AutoSize = true;
            this.label_ping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ping.Location = new System.Drawing.Point(22, 105);
            this.label_ping.Name = "label_ping";
            this.label_ping.Size = new System.Drawing.Size(78, 20);
            this.label_ping.TabIndex = 6;
            this.label_ping.Text = "Ping DSN";
            // 
            // pictureBox_authenticated
            // 
            this.pictureBox_authenticated.BackgroundImage = global::DSNadaptor.Properties.Resources.radio_unchecked;
            this.pictureBox_authenticated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_authenticated.Location = new System.Drawing.Point(621, 35);
            this.pictureBox_authenticated.Name = "pictureBox_authenticated";
            this.pictureBox_authenticated.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_authenticated.TabIndex = 5;
            this.pictureBox_authenticated.TabStop = false;
            // 
            // label_authenticated
            // 
            this.label_authenticated.AutoSize = true;
            this.label_authenticated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_authenticated.Location = new System.Drawing.Point(449, 38);
            this.label_authenticated.Name = "label_authenticated";
            this.label_authenticated.Size = new System.Drawing.Size(109, 20);
            this.label_authenticated.TabIndex = 4;
            this.label_authenticated.Text = "Authenticated";
            // 
            // pictureBox_localIP
            // 
            this.pictureBox_localIP.BackgroundImage = global::DSNadaptor.Properties.Resources.radio_unchecked;
            this.pictureBox_localIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_localIP.Location = new System.Drawing.Point(194, 32);
            this.pictureBox_localIP.Name = "pictureBox_localIP";
            this.pictureBox_localIP.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_localIP.TabIndex = 3;
            this.pictureBox_localIP.TabStop = false;
            // 
            // label_localIP
            // 
            this.label_localIP.AutoSize = true;
            this.label_localIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_localIP.Location = new System.Drawing.Point(22, 35);
            this.label_localIP.Name = "label_localIP";
            this.label_localIP.Size = new System.Drawing.Size(66, 20);
            this.label_localIP.TabIndex = 2;
            this.label_localIP.Text = "Local IP";
            // 
            // pictureBox_connected
            // 
            this.pictureBox_connected.BackgroundImage = global::DSNadaptor.Properties.Resources.radio_unchecked;
            this.pictureBox_connected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_connected.Location = new System.Drawing.Point(194, 67);
            this.pictureBox_connected.Name = "pictureBox_connected";
            this.pictureBox_connected.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_connected.TabIndex = 1;
            this.pictureBox_connected.TabStop = false;
            // 
            // label_connected
            // 
            this.label_connected.AutoSize = true;
            this.label_connected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connected.Location = new System.Drawing.Point(22, 70);
            this.label_connected.Name = "label_connected";
            this.label_connected.Size = new System.Drawing.Size(67, 20);
            this.label_connected.TabIndex = 0;
            this.label_connected.Text = "Network";
            // 
            // tabPage_testapi
            // 
            this.tabPage_testapi.Controls.Add(this.button_FTP);
            this.tabPage_testapi.Controls.Add(this.button_LoadStream);
            this.tabPage_testapi.Controls.Add(this.button_GetCookieChrome);
            this.tabPage_testapi.Controls.Add(this.button_ExecuteStream);
            this.tabPage_testapi.Controls.Add(this.button_PostWithCookie);
            this.tabPage_testapi.Controls.Add(this.button_GetToken);
            this.tabPage_testapi.Controls.Add(this.button_GetCookie);
            this.tabPage_testapi.Controls.Add(this.label_Progress);
            this.tabPage_testapi.Controls.Add(this.richTextBox_response);
            this.tabPage_testapi.Controls.Add(this.progressBar_prog);
            this.tabPage_testapi.Controls.Add(this.button_loadFile);
            this.tabPage_testapi.Controls.Add(this.button_Parse);
            this.tabPage_testapi.Controls.Add(this.checkBox_deliminate);
            this.tabPage_testapi.Controls.Add(this.textBox_UDPport);
            this.tabPage_testapi.Controls.Add(this.textBox_destUDPip);
            this.tabPage_testapi.Controls.Add(this.label_udpPort);
            this.tabPage_testapi.Controls.Add(this.label_destUDP);
            this.tabPage_testapi.Controls.Add(this.button_udpTest);
            this.tabPage_testapi.Controls.Add(this.label_UDPtest);
            this.tabPage_testapi.Controls.Add(this.textBox_testURI);
            this.tabPage_testapi.Controls.Add(this.textBox_testServer);
            this.tabPage_testapi.Controls.Add(this.button_testExecute);
            this.tabPage_testapi.Controls.Add(this.label_testURI);
            this.tabPage_testapi.Controls.Add(this.label_TestServer);
            this.tabPage_testapi.Controls.Add(this.label_apiTEST);
            this.tabPage_testapi.Location = new System.Drawing.Point(4, 22);
            this.tabPage_testapi.Name = "tabPage_testapi";
            this.tabPage_testapi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_testapi.Size = new System.Drawing.Size(775, 442);
            this.tabPage_testapi.TabIndex = 1;
            this.tabPage_testapi.Text = "Test API";
            this.tabPage_testapi.UseVisualStyleBackColor = true;
            // 
            // button_FTP
            // 
            this.button_FTP.Location = new System.Drawing.Point(682, 148);
            this.button_FTP.Name = "button_FTP";
            this.button_FTP.Size = new System.Drawing.Size(75, 26);
            this.button_FTP.TabIndex = 25;
            this.button_FTP.Text = "List FTP";
            this.button_FTP.UseVisualStyleBackColor = true;
            this.button_FTP.Click += new System.EventHandler(this.button_FTP_Click);
            // 
            // button_LoadStream
            // 
            this.button_LoadStream.Location = new System.Drawing.Point(583, 119);
            this.button_LoadStream.Name = "button_LoadStream";
            this.button_LoadStream.Size = new System.Drawing.Size(75, 26);
            this.button_LoadStream.TabIndex = 24;
            this.button_LoadStream.Text = "Load Stream";
            this.button_LoadStream.UseVisualStyleBackColor = true;
            this.button_LoadStream.Click += new System.EventHandler(this.button_LoadStream_Click);
            // 
            // button_GetCookieChrome
            // 
            this.button_GetCookieChrome.Location = new System.Drawing.Point(242, 6);
            this.button_GetCookieChrome.Name = "button_GetCookieChrome";
            this.button_GetCookieChrome.Size = new System.Drawing.Size(106, 43);
            this.button_GetCookieChrome.TabIndex = 23;
            this.button_GetCookieChrome.Text = "Get Cookie Chrome";
            this.button_GetCookieChrome.UseVisualStyleBackColor = true;
            this.button_GetCookieChrome.Click += new System.EventHandler(this.button_GetCookieChrome_Click);
            // 
            // button_ExecuteStream
            // 
            this.button_ExecuteStream.Location = new System.Drawing.Point(242, 54);
            this.button_ExecuteStream.Name = "button_ExecuteStream";
            this.button_ExecuteStream.Size = new System.Drawing.Size(106, 26);
            this.button_ExecuteStream.TabIndex = 22;
            this.button_ExecuteStream.Text = "Get Stream";
            this.button_ExecuteStream.UseVisualStyleBackColor = true;
            this.button_ExecuteStream.Click += new System.EventHandler(this.button_ExecuteStream_Click);
            // 
            // button_PostWithCookie
            // 
            this.button_PostWithCookie.Location = new System.Drawing.Point(242, 150);
            this.button_PostWithCookie.Name = "button_PostWithCookie";
            this.button_PostWithCookie.Size = new System.Drawing.Size(106, 26);
            this.button_PostWithCookie.TabIndex = 21;
            this.button_PostWithCookie.Text = "Execute Cookie";
            this.button_PostWithCookie.UseVisualStyleBackColor = true;
            this.button_PostWithCookie.Click += new System.EventHandler(this.button_PostWithCookie_Click_1);
            // 
            // button_GetToken
            // 
            this.button_GetToken.Location = new System.Drawing.Point(242, 118);
            this.button_GetToken.Name = "button_GetToken";
            this.button_GetToken.Size = new System.Drawing.Size(106, 26);
            this.button_GetToken.TabIndex = 20;
            this.button_GetToken.Text = "Get Token";
            this.button_GetToken.UseVisualStyleBackColor = true;
            this.button_GetToken.Click += new System.EventHandler(this.button_PostWithCookie_Click);
            // 
            // button_GetCookie
            // 
            this.button_GetCookie.Location = new System.Drawing.Point(242, 86);
            this.button_GetCookie.Name = "button_GetCookie";
            this.button_GetCookie.Size = new System.Drawing.Size(106, 26);
            this.button_GetCookie.TabIndex = 19;
            this.button_GetCookie.Text = "Get Cookie";
            this.button_GetCookie.UseVisualStyleBackColor = true;
            this.button_GetCookie.Click += new System.EventHandler(this.button_ExecuteWeb_Click);
            // 
            // label_Progress
            // 
            this.label_Progress.AutoSize = true;
            this.label_Progress.Location = new System.Drawing.Point(529, 149);
            this.label_Progress.Name = "label_Progress";
            this.label_Progress.Size = new System.Drawing.Size(0, 13);
            this.label_Progress.TabIndex = 18;
            // 
            // richTextBox_response
            // 
            this.richTextBox_response.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_response.Location = new System.Drawing.Point(3, 252);
            this.richTextBox_response.Name = "richTextBox_response";
            this.richTextBox_response.Size = new System.Drawing.Size(769, 164);
            this.richTextBox_response.TabIndex = 17;
            this.richTextBox_response.Text = "";
            // 
            // progressBar_prog
            // 
            this.progressBar_prog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_prog.Location = new System.Drawing.Point(3, 416);
            this.progressBar_prog.Name = "progressBar_prog";
            this.progressBar_prog.Size = new System.Drawing.Size(769, 23);
            this.progressBar_prog.TabIndex = 16;
            // 
            // button_loadFile
            // 
            this.button_loadFile.Location = new System.Drawing.Point(421, 119);
            this.button_loadFile.Name = "button_loadFile";
            this.button_loadFile.Size = new System.Drawing.Size(75, 26);
            this.button_loadFile.TabIndex = 15;
            this.button_loadFile.Text = "Load";
            this.button_loadFile.UseVisualStyleBackColor = true;
            this.button_loadFile.Click += new System.EventHandler(this.button_loadFile_Click);
            // 
            // button_Parse
            // 
            this.button_Parse.Location = new System.Drawing.Point(134, 119);
            this.button_Parse.Name = "button_Parse";
            this.button_Parse.Size = new System.Drawing.Size(102, 26);
            this.button_Parse.TabIndex = 14;
            this.button_Parse.Text = "Parse JSON";
            this.button_Parse.UseVisualStyleBackColor = true;
            this.button_Parse.Click += new System.EventHandler(this.button_Parse_Click);
            // 
            // checkBox_deliminate
            // 
            this.checkBox_deliminate.AutoSize = true;
            this.checkBox_deliminate.Location = new System.Drawing.Point(409, 148);
            this.checkBox_deliminate.Name = "checkBox_deliminate";
            this.checkBox_deliminate.Size = new System.Drawing.Size(107, 17);
            this.checkBox_deliminate.TabIndex = 13;
            this.checkBox_deliminate.Text = "Deliminate SFDU";
            this.checkBox_deliminate.UseVisualStyleBackColor = true;
            // 
            // textBox_UDPport
            // 
            this.textBox_UDPport.Location = new System.Drawing.Point(493, 88);
            this.textBox_UDPport.Name = "textBox_UDPport";
            this.textBox_UDPport.Size = new System.Drawing.Size(100, 20);
            this.textBox_UDPport.TabIndex = 12;
            // 
            // textBox_destUDPip
            // 
            this.textBox_destUDPip.Location = new System.Drawing.Point(493, 65);
            this.textBox_destUDPip.Name = "textBox_destUDPip";
            this.textBox_destUDPip.Size = new System.Drawing.Size(100, 20);
            this.textBox_destUDPip.TabIndex = 10;
            // 
            // label_udpPort
            // 
            this.label_udpPort.AutoSize = true;
            this.label_udpPort.Location = new System.Drawing.Point(406, 89);
            this.label_udpPort.Name = "label_udpPort";
            this.label_udpPort.Size = new System.Drawing.Size(26, 13);
            this.label_udpPort.TabIndex = 11;
            this.label_udpPort.Text = "Port";
            // 
            // label_destUDP
            // 
            this.label_destUDP.AutoSize = true;
            this.label_destUDP.Location = new System.Drawing.Point(406, 69);
            this.label_destUDP.Name = "label_destUDP";
            this.label_destUDP.Size = new System.Drawing.Size(73, 13);
            this.label_destUDP.TabIndex = 9;
            this.label_destUDP.Text = "Destination IP";
            // 
            // button_udpTest
            // 
            this.button_udpTest.Location = new System.Drawing.Point(502, 119);
            this.button_udpTest.Name = "button_udpTest";
            this.button_udpTest.Size = new System.Drawing.Size(75, 26);
            this.button_udpTest.TabIndex = 8;
            this.button_udpTest.Text = "Distribute";
            this.button_udpTest.UseVisualStyleBackColor = true;
            this.button_udpTest.Click += new System.EventHandler(this.button_udpTest_Click);
            // 
            // label_UDPtest
            // 
            this.label_UDPtest.AutoSize = true;
            this.label_UDPtest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UDPtest.Location = new System.Drawing.Point(483, 21);
            this.label_UDPtest.Name = "label_UDPtest";
            this.label_UDPtest.Size = new System.Drawing.Size(112, 25);
            this.label_UDPtest.TabIndex = 7;
            this.label_UDPtest.Text = "UDP Test";
            // 
            // textBox_testURI
            // 
            this.textBox_testURI.Location = new System.Drawing.Point(69, 89);
            this.textBox_testURI.Name = "textBox_testURI";
            this.textBox_testURI.Size = new System.Drawing.Size(146, 20);
            this.textBox_testURI.TabIndex = 4;
            // 
            // textBox_testServer
            // 
            this.textBox_testServer.Location = new System.Drawing.Point(69, 66);
            this.textBox_testServer.Name = "textBox_testServer";
            this.textBox_testServer.Size = new System.Drawing.Size(146, 20);
            this.textBox_testServer.TabIndex = 2;
            // 
            // button_testExecute
            // 
            this.button_testExecute.Location = new System.Drawing.Point(53, 119);
            this.button_testExecute.Name = "button_testExecute";
            this.button_testExecute.Size = new System.Drawing.Size(75, 26);
            this.button_testExecute.TabIndex = 5;
            this.button_testExecute.Text = "Execute";
            this.button_testExecute.UseVisualStyleBackColor = true;
            this.button_testExecute.Click += new System.EventHandler(this.button_testExecute_Click);
            // 
            // label_testURI
            // 
            this.label_testURI.AutoSize = true;
            this.label_testURI.Location = new System.Drawing.Point(3, 93);
            this.label_testURI.Name = "label_testURI";
            this.label_testURI.Size = new System.Drawing.Size(26, 13);
            this.label_testURI.TabIndex = 3;
            this.label_testURI.Text = "URI";
            // 
            // label_TestServer
            // 
            this.label_TestServer.AutoSize = true;
            this.label_TestServer.Location = new System.Drawing.Point(3, 70);
            this.label_TestServer.Name = "label_TestServer";
            this.label_TestServer.Size = new System.Drawing.Size(53, 13);
            this.label_TestServer.TabIndex = 1;
            this.label_TestServer.Text = "Base URI";
            // 
            // label_apiTEST
            // 
            this.label_apiTEST.AutoSize = true;
            this.label_apiTEST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apiTEST.Location = new System.Drawing.Point(6, 21);
            this.label_apiTEST.Name = "label_apiTEST";
            this.label_apiTEST.Size = new System.Drawing.Size(101, 25);
            this.label_apiTEST.TabIndex = 0;
            this.label_apiTEST.Text = "API Test";
            // 
            // tabPage_manual
            // 
            this.tabPage_manual.Location = new System.Drawing.Point(4, 22);
            this.tabPage_manual.Name = "tabPage_manual";
            this.tabPage_manual.Size = new System.Drawing.Size(775, 442);
            this.tabPage_manual.TabIndex = 2;
            this.tabPage_manual.Text = "Manual";
            this.tabPage_manual.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.panel_openAMSettings);
            this.tabPageSettings.Controls.Add(this.panel_metadatasettings);
            this.tabPageSettings.Controls.Add(this.panel_UDPsettings);
            this.tabPageSettings.Controls.Add(this.panel_restAPI);
            this.tabPageSettings.Controls.Add(this.panel_proxy);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(775, 442);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // panel_openAMSettings
            // 
            this.panel_openAMSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_openAMSettings.Controls.Add(this.checkBox_useAu);
            this.panel_openAMSettings.Controls.Add(this.textBox_AuURI);
            this.panel_openAMSettings.Controls.Add(this.label_UseAU);
            this.panel_openAMSettings.Controls.Add(this.label_AUuri);
            this.panel_openAMSettings.Controls.Add(this.textBox_CookieURI);
            this.panel_openAMSettings.Controls.Add(this.label_Cookie);
            this.panel_openAMSettings.Controls.Add(this.textBox_AMpassword);
            this.panel_openAMSettings.Controls.Add(this.label_AMpassword);
            this.panel_openAMSettings.Controls.Add(this.textBox_AMuser);
            this.panel_openAMSettings.Controls.Add(this.label_AMuser);
            this.panel_openAMSettings.Controls.Add(this.textBox_AMserver);
            this.panel_openAMSettings.Controls.Add(this.label_OpenAMserver);
            this.panel_openAMSettings.Controls.Add(this.label_AuSettings);
            this.panel_openAMSettings.Location = new System.Drawing.Point(285, 180);
            this.panel_openAMSettings.Name = "panel_openAMSettings";
            this.panel_openAMSettings.Size = new System.Drawing.Size(182, 184);
            this.panel_openAMSettings.TabIndex = 22;
            // 
            // checkBox_useAu
            // 
            this.checkBox_useAu.AutoSize = true;
            this.checkBox_useAu.Location = new System.Drawing.Point(108, 35);
            this.checkBox_useAu.Name = "checkBox_useAu";
            this.checkBox_useAu.Size = new System.Drawing.Size(15, 14);
            this.checkBox_useAu.TabIndex = 8;
            this.checkBox_useAu.UseVisualStyleBackColor = true;
            // 
            // textBox_AuURI
            // 
            this.textBox_AuURI.Location = new System.Drawing.Point(79, 158);
            this.textBox_AuURI.Name = "textBox_AuURI";
            this.textBox_AuURI.Size = new System.Drawing.Size(98, 20);
            this.textBox_AuURI.TabIndex = 32;
            // 
            // label_UseAU
            // 
            this.label_UseAU.AutoSize = true;
            this.label_UseAU.Location = new System.Drawing.Point(0, 35);
            this.label_UseAU.Name = "label_UseAU";
            this.label_UseAU.Size = new System.Drawing.Size(103, 13);
            this.label_UseAU.TabIndex = 7;
            this.label_UseAU.Text = "Use Authentication?";
            // 
            // label_AUuri
            // 
            this.label_AUuri.AutoSize = true;
            this.label_AUuri.Location = new System.Drawing.Point(0, 161);
            this.label_AUuri.Name = "label_AUuri";
            this.label_AUuri.Size = new System.Drawing.Size(51, 13);
            this.label_AUuri.TabIndex = 31;
            this.label_AUuri.Text = "Auth URI";
            // 
            // textBox_CookieURI
            // 
            this.textBox_CookieURI.Location = new System.Drawing.Point(79, 133);
            this.textBox_CookieURI.Name = "textBox_CookieURI";
            this.textBox_CookieURI.Size = new System.Drawing.Size(98, 20);
            this.textBox_CookieURI.TabIndex = 30;
            // 
            // label_Cookie
            // 
            this.label_Cookie.AutoSize = true;
            this.label_Cookie.Location = new System.Drawing.Point(0, 136);
            this.label_Cookie.Name = "label_Cookie";
            this.label_Cookie.Size = new System.Drawing.Size(62, 13);
            this.label_Cookie.TabIndex = 29;
            this.label_Cookie.Text = "Cookie URI";
            // 
            // textBox_AMpassword
            // 
            this.textBox_AMpassword.Location = new System.Drawing.Point(79, 107);
            this.textBox_AMpassword.Name = "textBox_AMpassword";
            this.textBox_AMpassword.PasswordChar = '*';
            this.textBox_AMpassword.Size = new System.Drawing.Size(98, 20);
            this.textBox_AMpassword.TabIndex = 28;
            this.textBox_AMpassword.UseSystemPasswordChar = true;
            // 
            // label_AMpassword
            // 
            this.label_AMpassword.AutoSize = true;
            this.label_AMpassword.Location = new System.Drawing.Point(0, 110);
            this.label_AMpassword.Name = "label_AMpassword";
            this.label_AMpassword.Size = new System.Drawing.Size(72, 13);
            this.label_AMpassword.TabIndex = 27;
            this.label_AMpassword.Text = "AM Password";
            // 
            // textBox_AMuser
            // 
            this.textBox_AMuser.Location = new System.Drawing.Point(79, 84);
            this.textBox_AMuser.Name = "textBox_AMuser";
            this.textBox_AMuser.Size = new System.Drawing.Size(98, 20);
            this.textBox_AMuser.TabIndex = 26;
            // 
            // label_AMuser
            // 
            this.label_AMuser.AutoSize = true;
            this.label_AMuser.Location = new System.Drawing.Point(0, 87);
            this.label_AMuser.Name = "label_AMuser";
            this.label_AMuser.Size = new System.Drawing.Size(74, 13);
            this.label_AMuser.TabIndex = 25;
            this.label_AMuser.Text = "AM Username";
            // 
            // textBox_AMserver
            // 
            this.textBox_AMserver.Location = new System.Drawing.Point(79, 61);
            this.textBox_AMserver.Name = "textBox_AMserver";
            this.textBox_AMserver.Size = new System.Drawing.Size(98, 20);
            this.textBox_AMserver.TabIndex = 24;
            // 
            // label_OpenAMserver
            // 
            this.label_OpenAMserver.AutoSize = true;
            this.label_OpenAMserver.Location = new System.Drawing.Point(0, 64);
            this.label_OpenAMserver.Name = "label_OpenAMserver";
            this.label_OpenAMserver.Size = new System.Drawing.Size(57, 13);
            this.label_OpenAMserver.TabIndex = 23;
            this.label_OpenAMserver.Text = "AM Server";
            // 
            // label_AuSettings
            // 
            this.label_AuSettings.AutoSize = true;
            this.label_AuSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AuSettings.Location = new System.Drawing.Point(3, 4);
            this.label_AuSettings.Name = "label_AuSettings";
            this.label_AuSettings.Size = new System.Drawing.Size(158, 24);
            this.label_AuSettings.TabIndex = 21;
            this.label_AuSettings.Text = "OpenAM Settings";
            // 
            // panel_metadatasettings
            // 
            this.panel_metadatasettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_metadatasettings.Controls.Add(this.numericUpDown_MonitorInterval);
            this.panel_metadatasettings.Controls.Add(this.label_CheckCOnnected);
            this.panel_metadatasettings.Controls.Add(this.label_metadata);
            this.panel_metadatasettings.Location = new System.Drawing.Point(285, 115);
            this.panel_metadatasettings.Name = "panel_metadatasettings";
            this.panel_metadatasettings.Size = new System.Drawing.Size(182, 61);
            this.panel_metadatasettings.TabIndex = 9;
            // 
            // numericUpDown_MonitorInterval
            // 
            this.numericUpDown_MonitorInterval.Location = new System.Drawing.Point(103, 32);
            this.numericUpDown_MonitorInterval.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDown_MonitorInterval.Name = "numericUpDown_MonitorInterval";
            this.numericUpDown_MonitorInterval.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown_MonitorInterval.TabIndex = 7;
            // 
            // label_CheckCOnnected
            // 
            this.label_CheckCOnnected.AutoSize = true;
            this.label_CheckCOnnected.Location = new System.Drawing.Point(3, 34);
            this.label_CheckCOnnected.Name = "label_CheckCOnnected";
            this.label_CheckCOnnected.Size = new System.Drawing.Size(80, 13);
            this.label_CheckCOnnected.TabIndex = 21;
            this.label_CheckCOnnected.Text = "Montior Interval";
            // 
            // label_metadata
            // 
            this.label_metadata.AutoSize = true;
            this.label_metadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_metadata.Location = new System.Drawing.Point(3, 6);
            this.label_metadata.Name = "label_metadata";
            this.label_metadata.Size = new System.Drawing.Size(157, 24);
            this.label_metadata.TabIndex = 21;
            this.label_metadata.Text = "Metadata Settings";
            // 
            // panel_UDPsettings
            // 
            this.panel_UDPsettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_UDPsettings.Controls.Add(this.button_Clear);
            this.panel_UDPsettings.Controls.Add(this.label_ms);
            this.panel_UDPsettings.Controls.Add(this.numericUpDown_byteratio);
            this.panel_UDPsettings.Controls.Add(this.label_ByteRatio);
            this.panel_UDPsettings.Controls.Add(this.checkBox_calcDelay);
            this.panel_UDPsettings.Controls.Add(this.label_CalcDelay);
            this.panel_UDPsettings.Controls.Add(this.numericUpDown_deliveryDelay);
            this.panel_UDPsettings.Controls.Add(this.label_DeliveryDelay);
            this.panel_UDPsettings.Controls.Add(this.dataGridView_ports);
            this.panel_UDPsettings.Controls.Add(this.dataGridView_addresses);
            this.panel_UDPsettings.Controls.Add(this.label_UDPports);
            this.panel_UDPsettings.Controls.Add(this.label_udpAddresses);
            this.panel_UDPsettings.Controls.Add(this.label_udpSettings);
            this.panel_UDPsettings.Location = new System.Drawing.Point(473, 8);
            this.panel_UDPsettings.Name = "panel_UDPsettings";
            this.panel_UDPsettings.Size = new System.Drawing.Size(294, 356);
            this.panel_UDPsettings.TabIndex = 8;
            // 
            // button_Clear
            // 
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Location = new System.Drawing.Point(236, 108);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(50, 21);
            this.button_Clear.TabIndex = 23;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_ms
            // 
            this.label_ms.AutoSize = true;
            this.label_ms.Location = new System.Drawing.Point(256, 40);
            this.label_ms.Name = "label_ms";
            this.label_ms.Size = new System.Drawing.Size(20, 13);
            this.label_ms.TabIndex = 12;
            this.label_ms.Text = "ms";
            // 
            // numericUpDown_byteratio
            // 
            this.numericUpDown_byteratio.Location = new System.Drawing.Point(150, 82);
            this.numericUpDown_byteratio.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDown_byteratio.Name = "numericUpDown_byteratio";
            this.numericUpDown_byteratio.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_byteratio.TabIndex = 11;
            // 
            // label_ByteRatio
            // 
            this.label_ByteRatio.AutoSize = true;
            this.label_ByteRatio.Location = new System.Drawing.Point(4, 82);
            this.label_ByteRatio.Name = "label_ByteRatio";
            this.label_ByteRatio.Size = new System.Drawing.Size(46, 13);
            this.label_ByteRatio.TabIndex = 10;
            this.label_ByteRatio.Text = "Byte/ms";
            // 
            // checkBox_calcDelay
            // 
            this.checkBox_calcDelay.AutoSize = true;
            this.checkBox_calcDelay.Location = new System.Drawing.Point(150, 62);
            this.checkBox_calcDelay.Name = "checkBox_calcDelay";
            this.checkBox_calcDelay.Size = new System.Drawing.Size(15, 14);
            this.checkBox_calcDelay.TabIndex = 7;
            this.checkBox_calcDelay.UseVisualStyleBackColor = true;
            this.checkBox_calcDelay.CheckedChanged += new System.EventHandler(this.checkBox_calcDelay_CheckedChanged);
            // 
            // label_CalcDelay
            // 
            this.label_CalcDelay.AutoSize = true;
            this.label_CalcDelay.Location = new System.Drawing.Point(4, 58);
            this.label_CalcDelay.Name = "label_CalcDelay";
            this.label_CalcDelay.Size = new System.Drawing.Size(81, 13);
            this.label_CalcDelay.TabIndex = 9;
            this.label_CalcDelay.Text = "Calculate Delay";
            // 
            // numericUpDown_deliveryDelay
            // 
            this.numericUpDown_deliveryDelay.Location = new System.Drawing.Point(150, 35);
            this.numericUpDown_deliveryDelay.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDown_deliveryDelay.Name = "numericUpDown_deliveryDelay";
            this.numericUpDown_deliveryDelay.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_deliveryDelay.TabIndex = 7;
            // 
            // label_DeliveryDelay
            // 
            this.label_DeliveryDelay.AutoSize = true;
            this.label_DeliveryDelay.Location = new System.Drawing.Point(4, 35);
            this.label_DeliveryDelay.Name = "label_DeliveryDelay";
            this.label_DeliveryDelay.Size = new System.Drawing.Size(75, 13);
            this.label_DeliveryDelay.TabIndex = 8;
            this.label_DeliveryDelay.Text = "Delivery Delay";
            // 
            // dataGridView_ports
            // 
            this.dataGridView_ports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView_ports.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_ports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ports.ColumnHeadersVisible = false;
            this.dataGridView_ports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView_ports.Location = new System.Drawing.Point(149, 129);
            this.dataGridView_ports.Name = "dataGridView_ports";
            this.dataGridView_ports.RowHeadersVisible = false;
            this.dataGridView_ports.Size = new System.Drawing.Size(137, 215);
            this.dataGridView_ports.TabIndex = 7;
            this.dataGridView_ports.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_queryServers_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Ports";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridView_addresses
            // 
            this.dataGridView_addresses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView_addresses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_addresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_addresses.ColumnHeadersVisible = false;
            this.dataGridView_addresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_addresses});
            this.dataGridView_addresses.Location = new System.Drawing.Point(6, 129);
            this.dataGridView_addresses.Name = "dataGridView_addresses";
            this.dataGridView_addresses.RowHeadersVisible = false;
            this.dataGridView_addresses.Size = new System.Drawing.Size(137, 215);
            this.dataGridView_addresses.TabIndex = 6;
            this.dataGridView_addresses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_queryServers_CellDoubleClick);
            // 
            // Column_addresses
            // 
            this.Column_addresses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_addresses.HeaderText = "Addresses";
            this.Column_addresses.Name = "Column_addresses";
            // 
            // label_UDPports
            // 
            this.label_UDPports.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_UDPports.AutoSize = true;
            this.label_UDPports.Location = new System.Drawing.Point(146, 108);
            this.label_UDPports.Name = "label_UDPports";
            this.label_UDPports.Size = new System.Drawing.Size(31, 13);
            this.label_UDPports.TabIndex = 5;
            this.label_UDPports.Text = "Ports";
            // 
            // label_udpAddresses
            // 
            this.label_udpAddresses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_udpAddresses.AutoSize = true;
            this.label_udpAddresses.Location = new System.Drawing.Point(2, 110);
            this.label_udpAddresses.Name = "label_udpAddresses";
            this.label_udpAddresses.Size = new System.Drawing.Size(56, 13);
            this.label_udpAddresses.TabIndex = 1;
            this.label_udpAddresses.Text = "Addresses";
            // 
            // label_udpSettings
            // 
            this.label_udpSettings.AutoSize = true;
            this.label_udpSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_udpSettings.Location = new System.Drawing.Point(3, 5);
            this.label_udpSettings.Name = "label_udpSettings";
            this.label_udpSettings.Size = new System.Drawing.Size(119, 24);
            this.label_udpSettings.TabIndex = 0;
            this.label_udpSettings.Text = "UDP Settings";
            // 
            // panel_restAPI
            // 
            this.panel_restAPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_restAPI.Controls.Add(this.dataGridView_queryServers);
            this.panel_restAPI.Controls.Add(this.label_queryServer);
            this.panel_restAPI.Controls.Add(this.textBox_SFDUsync);
            this.panel_restAPI.Controls.Add(this.label_sfdusync);
            this.panel_restAPI.Controls.Add(this.button_save);
            this.panel_restAPI.Controls.Add(this.numericUpDown_RequestRetry);
            this.panel_restAPI.Controls.Add(this.label_Retries);
            this.panel_restAPI.Controls.Add(this.label_reqinms);
            this.panel_restAPI.Controls.Add(this.numericUpDown_RequestInterval);
            this.panel_restAPI.Controls.Add(this.label_RequestInterval);
            this.panel_restAPI.Controls.Add(this.label_reqMs);
            this.panel_restAPI.Controls.Add(this.numericUpDown_RequestTimeout);
            this.panel_restAPI.Controls.Add(this.label_RequestTimeout);
            this.panel_restAPI.Controls.Add(this.label_baseURIcomment);
            this.panel_restAPI.Controls.Add(this.textBox_BaseURI);
            this.panel_restAPI.Controls.Add(this.label_BaseURI);
            this.panel_restAPI.Controls.Add(this.textBox_SCID);
            this.panel_restAPI.Controls.Add(this.label_SpacecraftID);
            this.panel_restAPI.Controls.Add(this.textBox_webTLMaddress);
            this.panel_restAPI.Controls.Add(this.label_webTLMserver);
            this.panel_restAPI.Controls.Add(this.label_APIrest);
            this.panel_restAPI.Location = new System.Drawing.Point(6, 8);
            this.panel_restAPI.Name = "panel_restAPI";
            this.panel_restAPI.Size = new System.Drawing.Size(273, 356);
            this.panel_restAPI.TabIndex = 7;
            // 
            // dataGridView_queryServers
            // 
            this.dataGridView_queryServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView_queryServers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_queryServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_queryServers.ColumnHeadersVisible = false;
            this.dataGridView_queryServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dataGridView_queryServers.Location = new System.Drawing.Point(127, 81);
            this.dataGridView_queryServers.Name = "dataGridView_queryServers";
            this.dataGridView_queryServers.RowHeadersVisible = false;
            this.dataGridView_queryServers.Size = new System.Drawing.Size(143, 67);
            this.dataGridView_queryServers.TabIndex = 22;
            this.dataGridView_queryServers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_queryServers_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Addresses";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label_queryServer
            // 
            this.label_queryServer.AutoSize = true;
            this.label_queryServer.Location = new System.Drawing.Point(2, 82);
            this.label_queryServer.Name = "label_queryServer";
            this.label_queryServer.Size = new System.Drawing.Size(69, 13);
            this.label_queryServer.TabIndex = 21;
            this.label_queryServer.Text = "Query Server";
            // 
            // textBox_SFDUsync
            // 
            this.textBox_SFDUsync.Location = new System.Drawing.Point(127, 285);
            this.textBox_SFDUsync.Name = "textBox_SFDUsync";
            this.textBox_SFDUsync.Size = new System.Drawing.Size(141, 20);
            this.textBox_SFDUsync.TabIndex = 20;
            // 
            // label_sfdusync
            // 
            this.label_sfdusync.AutoSize = true;
            this.label_sfdusync.Location = new System.Drawing.Point(3, 290);
            this.label_sfdusync.Name = "label_sfdusync";
            this.label_sfdusync.Size = new System.Drawing.Size(61, 13);
            this.label_sfdusync.TabIndex = 19;
            this.label_sfdusync.Text = "SFDU sync";
            // 
            // button_save
            // 
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Location = new System.Drawing.Point(191, 328);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // numericUpDown_RequestRetry
            // 
            this.numericUpDown_RequestRetry.Location = new System.Drawing.Point(129, 260);
            this.numericUpDown_RequestRetry.Maximum = new decimal(new int[] {
            128000,
            0,
            0,
            0});
            this.numericUpDown_RequestRetry.Name = "numericUpDown_RequestRetry";
            this.numericUpDown_RequestRetry.Size = new System.Drawing.Size(113, 20);
            this.numericUpDown_RequestRetry.TabIndex = 18;
            // 
            // label_Retries
            // 
            this.label_Retries.AutoSize = true;
            this.label_Retries.Location = new System.Drawing.Point(3, 262);
            this.label_Retries.Name = "label_Retries";
            this.label_Retries.Size = new System.Drawing.Size(83, 13);
            this.label_Retries.TabIndex = 17;
            this.label_Retries.Text = "Request Retries";
            // 
            // label_reqinms
            // 
            this.label_reqinms.AutoSize = true;
            this.label_reqinms.Location = new System.Drawing.Point(246, 241);
            this.label_reqinms.Name = "label_reqinms";
            this.label_reqinms.Size = new System.Drawing.Size(23, 13);
            this.label_reqinms.TabIndex = 16;
            this.label_reqinms.Text = "min";
            // 
            // numericUpDown_RequestInterval
            // 
            this.numericUpDown_RequestInterval.Location = new System.Drawing.Point(129, 237);
            this.numericUpDown_RequestInterval.Maximum = new decimal(new int[] {
            128000,
            0,
            0,
            0});
            this.numericUpDown_RequestInterval.Name = "numericUpDown_RequestInterval";
            this.numericUpDown_RequestInterval.Size = new System.Drawing.Size(113, 20);
            this.numericUpDown_RequestInterval.TabIndex = 15;
            // 
            // label_RequestInterval
            // 
            this.label_RequestInterval.AutoSize = true;
            this.label_RequestInterval.Location = new System.Drawing.Point(4, 239);
            this.label_RequestInterval.Name = "label_RequestInterval";
            this.label_RequestInterval.Size = new System.Drawing.Size(85, 13);
            this.label_RequestInterval.TabIndex = 14;
            this.label_RequestInterval.Text = "Request Interval";
            // 
            // label_reqMs
            // 
            this.label_reqMs.AutoSize = true;
            this.label_reqMs.Location = new System.Drawing.Point(246, 212);
            this.label_reqMs.Name = "label_reqMs";
            this.label_reqMs.Size = new System.Drawing.Size(20, 13);
            this.label_reqMs.TabIndex = 13;
            this.label_reqMs.Text = "ms";
            // 
            // numericUpDown_RequestTimeout
            // 
            this.numericUpDown_RequestTimeout.Location = new System.Drawing.Point(129, 210);
            this.numericUpDown_RequestTimeout.Maximum = new decimal(new int[] {
            128000,
            0,
            0,
            0});
            this.numericUpDown_RequestTimeout.Name = "numericUpDown_RequestTimeout";
            this.numericUpDown_RequestTimeout.Size = new System.Drawing.Size(113, 20);
            this.numericUpDown_RequestTimeout.TabIndex = 7;
            // 
            // label_RequestTimeout
            // 
            this.label_RequestTimeout.AutoSize = true;
            this.label_RequestTimeout.Location = new System.Drawing.Point(4, 212);
            this.label_RequestTimeout.Name = "label_RequestTimeout";
            this.label_RequestTimeout.Size = new System.Drawing.Size(88, 13);
            this.label_RequestTimeout.TabIndex = 10;
            this.label_RequestTimeout.Text = "Request Timeout";
            // 
            // label_baseURIcomment
            // 
            this.label_baseURIcomment.AutoSize = true;
            this.label_baseURIcomment.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_baseURIcomment.Location = new System.Drawing.Point(17, 181);
            this.label_baseURIcomment.Name = "label_baseURIcomment";
            this.label_baseURIcomment.Size = new System.Drawing.Size(210, 12);
            this.label_baseURIcomment.TabIndex = 9;
            this.label_baseURIcomment.Text = "* <server> will be replaced with WebTLM Address";
            // 
            // textBox_BaseURI
            // 
            this.textBox_BaseURI.Location = new System.Drawing.Point(129, 154);
            this.textBox_BaseURI.Name = "textBox_BaseURI";
            this.textBox_BaseURI.Size = new System.Drawing.Size(141, 20);
            this.textBox_BaseURI.TabIndex = 8;
            // 
            // label_BaseURI
            // 
            this.label_BaseURI.AutoSize = true;
            this.label_BaseURI.Location = new System.Drawing.Point(4, 159);
            this.label_BaseURI.Name = "label_BaseURI";
            this.label_BaseURI.Size = new System.Drawing.Size(53, 13);
            this.label_BaseURI.TabIndex = 7;
            this.label_BaseURI.Text = "Base URI";
            // 
            // textBox_SCID
            // 
            this.textBox_SCID.Location = new System.Drawing.Point(129, 55);
            this.textBox_SCID.Name = "textBox_SCID";
            this.textBox_SCID.Size = new System.Drawing.Size(141, 20);
            this.textBox_SCID.TabIndex = 6;
            // 
            // label_SpacecraftID
            // 
            this.label_SpacecraftID.AutoSize = true;
            this.label_SpacecraftID.Location = new System.Drawing.Point(3, 55);
            this.label_SpacecraftID.Name = "label_SpacecraftID";
            this.label_SpacecraftID.Size = new System.Drawing.Size(35, 13);
            this.label_SpacecraftID.TabIndex = 5;
            this.label_SpacecraftID.Text = "SC-ID";
            // 
            // textBox_webTLMaddress
            // 
            this.textBox_webTLMaddress.Location = new System.Drawing.Point(129, 30);
            this.textBox_webTLMaddress.Name = "textBox_webTLMaddress";
            this.textBox_webTLMaddress.Size = new System.Drawing.Size(141, 20);
            this.textBox_webTLMaddress.TabIndex = 2;
            // 
            // label_webTLMserver
            // 
            this.label_webTLMserver.AutoSize = true;
            this.label_webTLMserver.Location = new System.Drawing.Point(3, 33);
            this.label_webTLMserver.Name = "label_webTLMserver";
            this.label_webTLMserver.Size = new System.Drawing.Size(93, 13);
            this.label_webTLMserver.TabIndex = 1;
            this.label_webTLMserver.Text = "WebTLM Address";
            // 
            // label_APIrest
            // 
            this.label_APIrest.AutoSize = true;
            this.label_APIrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_APIrest.Location = new System.Drawing.Point(3, 5);
            this.label_APIrest.Name = "label_APIrest";
            this.label_APIrest.Size = new System.Drawing.Size(131, 24);
            this.label_APIrest.TabIndex = 0;
            this.label_APIrest.Text = "REST Settings";
            // 
            // panel_proxy
            // 
            this.panel_proxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_proxy.Controls.Add(this.numericUpDown_port);
            this.panel_proxy.Controls.Add(this.label_proxyport);
            this.panel_proxy.Controls.Add(this.checkBox_useProxy);
            this.panel_proxy.Controls.Add(this.label_useProxy);
            this.panel_proxy.Controls.Add(this.textBox_proxyaddress);
            this.panel_proxy.Controls.Add(this.label_proxyServer);
            this.panel_proxy.Controls.Add(this.label_proxySettings);
            this.panel_proxy.Location = new System.Drawing.Point(285, 8);
            this.panel_proxy.Name = "panel_proxy";
            this.panel_proxy.Size = new System.Drawing.Size(182, 103);
            this.panel_proxy.TabIndex = 0;
            // 
            // numericUpDown_port
            // 
            this.numericUpDown_port.Location = new System.Drawing.Point(79, 76);
            this.numericUpDown_port.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDown_port.Name = "numericUpDown_port";
            this.numericUpDown_port.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_port.TabIndex = 6;
            // 
            // label_proxyport
            // 
            this.label_proxyport.AutoSize = true;
            this.label_proxyport.Location = new System.Drawing.Point(3, 76);
            this.label_proxyport.Name = "label_proxyport";
            this.label_proxyport.Size = new System.Drawing.Size(26, 13);
            this.label_proxyport.TabIndex = 5;
            this.label_proxyport.Text = "Port";
            // 
            // checkBox_useProxy
            // 
            this.checkBox_useProxy.AutoSize = true;
            this.checkBox_useProxy.Location = new System.Drawing.Point(79, 32);
            this.checkBox_useProxy.Name = "checkBox_useProxy";
            this.checkBox_useProxy.Size = new System.Drawing.Size(15, 14);
            this.checkBox_useProxy.TabIndex = 4;
            this.checkBox_useProxy.UseVisualStyleBackColor = true;
            this.checkBox_useProxy.CheckedChanged += new System.EventHandler(this.checkBox_useProxy_CheckedChanged);
            // 
            // label_useProxy
            // 
            this.label_useProxy.AutoSize = true;
            this.label_useProxy.Location = new System.Drawing.Point(3, 32);
            this.label_useProxy.Name = "label_useProxy";
            this.label_useProxy.Size = new System.Drawing.Size(61, 13);
            this.label_useProxy.TabIndex = 3;
            this.label_useProxy.Text = "Use Proxy?";
            // 
            // textBox_proxyaddress
            // 
            this.textBox_proxyaddress.Location = new System.Drawing.Point(79, 52);
            this.textBox_proxyaddress.Name = "textBox_proxyaddress";
            this.textBox_proxyaddress.Size = new System.Drawing.Size(100, 20);
            this.textBox_proxyaddress.TabIndex = 2;
            // 
            // label_proxyServer
            // 
            this.label_proxyServer.AutoSize = true;
            this.label_proxyServer.Location = new System.Drawing.Point(3, 52);
            this.label_proxyServer.Name = "label_proxyServer";
            this.label_proxyServer.Size = new System.Drawing.Size(45, 13);
            this.label_proxyServer.TabIndex = 1;
            this.label_proxyServer.Text = "Address";
            // 
            // label_proxySettings
            // 
            this.label_proxySettings.AutoSize = true;
            this.label_proxySettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_proxySettings.Location = new System.Drawing.Point(3, 2);
            this.label_proxySettings.Name = "label_proxySettings";
            this.label_proxySettings.Size = new System.Drawing.Size(129, 24);
            this.label_proxySettings.TabIndex = 0;
            this.label_proxySettings.Text = "Proxy Settings";
            // 
            // tabPage_SFTP
            // 
            this.tabPage_SFTP.Controls.Add(this.label1_SFDU_queue);
            this.tabPage_SFTP.Controls.Add(this.objectListView_queued);
            this.tabPage_SFTP.Controls.Add(this.label_Loading);
            this.tabPage_SFTP.Controls.Add(this.label_SFDU_PROG);
            this.tabPage_SFTP.Controls.Add(this.button_sendLoadedFile);
            this.tabPage_SFTP.Controls.Add(this.label_SFDU_FILENAME);
            this.tabPage_SFTP.Controls.Add(this.objectListView_SFTPlist);
            this.tabPage_SFTP.Controls.Add(this.button_refresh);
            this.tabPage_SFTP.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SFTP.Name = "tabPage_SFTP";
            this.tabPage_SFTP.Size = new System.Drawing.Size(775, 442);
            this.tabPage_SFTP.TabIndex = 4;
            this.tabPage_SFTP.Text = "SFTP";
            this.tabPage_SFTP.UseVisualStyleBackColor = true;
            // 
            // label1_SFDU_queue
            // 
            this.label1_SFDU_queue.AutoSize = true;
            this.label1_SFDU_queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_SFDU_queue.Location = new System.Drawing.Point(454, 45);
            this.label1_SFDU_queue.Name = "label1_SFDU_queue";
            this.label1_SFDU_queue.Size = new System.Drawing.Size(69, 24);
            this.label1_SFDU_queue.TabIndex = 19;
            this.label1_SFDU_queue.Text = "Queue";
            // 
            // objectListView_queued
            // 
            this.objectListView_queued.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.objectListView_queued.AllColumns.Add(this.olvColumn1);
            this.objectListView_queued.AllColumns.Add(this.olvColumn2);
            this.objectListView_queued.AutoArrange = false;
            this.objectListView_queued.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.objectListView_queued.CellEditUseWholeCell = false;
            this.objectListView_queued.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.objectListView_queued.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_queued.HideSelection = false;
            this.objectListView_queued.Location = new System.Drawing.Point(385, 72);
            this.objectListView_queued.Name = "objectListView_queued";
            this.objectListView_queued.ShowGroups = false;
            this.objectListView_queued.Size = new System.Drawing.Size(294, 222);
            this.objectListView_queued.TabIndex = 18;
            this.objectListView_queued.UseCompatibleStateImageBehavior = false;
            this.objectListView_queued.View = System.Windows.Forms.View.Details;
            this.objectListView_queued.DoubleClick += new System.EventHandler(this.objectListView_queued_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "fileName";
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "File Name";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "creationDate";
            this.olvColumn2.FillsFreeSpace = true;
            this.olvColumn2.Text = "Date";
            // 
            // label_Loading
            // 
            this.label_Loading.AutoSize = true;
            this.label_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Loading.Location = new System.Drawing.Point(381, 413);
            this.label_Loading.Name = "label_Loading";
            this.label_Loading.Size = new System.Drawing.Size(93, 24);
            this.label_Loading.TabIndex = 17;
            this.label_Loading.Text = "Loading...";
            this.label_Loading.Visible = false;
            // 
            // label_SFDU_PROG
            // 
            this.label_SFDU_PROG.AutoSize = true;
            this.label_SFDU_PROG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SFDU_PROG.Location = new System.Drawing.Point(455, 329);
            this.label_SFDU_PROG.Name = "label_SFDU_PROG";
            this.label_SFDU_PROG.Size = new System.Drawing.Size(0, 18);
            this.label_SFDU_PROG.TabIndex = 16;
            // 
            // button_sendLoadedFile
            // 
            this.button_sendLoadedFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sendLoadedFile.Location = new System.Drawing.Point(692, 416);
            this.button_sendLoadedFile.Name = "button_sendLoadedFile";
            this.button_sendLoadedFile.Size = new System.Drawing.Size(75, 23);
            this.button_sendLoadedFile.TabIndex = 15;
            this.button_sendLoadedFile.Text = "Send";
            this.button_sendLoadedFile.UseVisualStyleBackColor = true;
            this.button_sendLoadedFile.Click += new System.EventHandler(this.button_sendLoadedFile_Click);
            // 
            // label_SFDU_FILENAME
            // 
            this.label_SFDU_FILENAME.AutoSize = true;
            this.label_SFDU_FILENAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SFDU_FILENAME.Location = new System.Drawing.Point(455, 300);
            this.label_SFDU_FILENAME.Name = "label_SFDU_FILENAME";
            this.label_SFDU_FILENAME.Size = new System.Drawing.Size(0, 18);
            this.label_SFDU_FILENAME.TabIndex = 14;
            // 
            // objectListView_SFTPlist
            // 
            this.objectListView_SFTPlist.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.objectListView_SFTPlist.AllColumns.Add(this.olvColumn_FileName);
            this.objectListView_SFTPlist.AllColumns.Add(this.olvColumn_FileDate);
            this.objectListView_SFTPlist.AutoArrange = false;
            this.objectListView_SFTPlist.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.objectListView_SFTPlist.CellEditUseWholeCell = false;
            this.objectListView_SFTPlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_FileName,
            this.olvColumn_FileDate});
            this.objectListView_SFTPlist.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_SFTPlist.Dock = System.Windows.Forms.DockStyle.Left;
            this.objectListView_SFTPlist.HideSelection = false;
            this.objectListView_SFTPlist.Location = new System.Drawing.Point(0, 0);
            this.objectListView_SFTPlist.Name = "objectListView_SFTPlist";
            this.objectListView_SFTPlist.ShowGroups = false;
            this.objectListView_SFTPlist.Size = new System.Drawing.Size(294, 442);
            this.objectListView_SFTPlist.TabIndex = 12;
            this.objectListView_SFTPlist.UseCompatibleStateImageBehavior = false;
            this.objectListView_SFTPlist.View = System.Windows.Forms.View.Details;
            this.objectListView_SFTPlist.DoubleClick += new System.EventHandler(this.objectListView_SFTPlist_DoubleClick);
            // 
            // olvColumn_FileName
            // 
            this.olvColumn_FileName.AspectName = "fileName";
            this.olvColumn_FileName.FillsFreeSpace = true;
            this.olvColumn_FileName.IsEditable = false;
            this.olvColumn_FileName.Text = "File Name";
            // 
            // olvColumn_FileDate
            // 
            this.olvColumn_FileDate.AspectName = "creationDate";
            this.olvColumn_FileDate.FillsFreeSpace = true;
            this.olvColumn_FileDate.Text = "Date";
            // 
            // button_refresh
            // 
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Location = new System.Drawing.Point(300, 416);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 11;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // listView_log
            // 
            this.listView_log.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView_log.AutoArrange = false;
            this.listView_log.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_timestamp,
            this.columnHeader_text});
            this.listView_log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_log.HideSelection = false;
            this.listView_log.Location = new System.Drawing.Point(0, 507);
            this.listView_log.Name = "listView_log";
            this.listView_log.Size = new System.Drawing.Size(783, 143);
            this.listView_log.TabIndex = 9;
            this.listView_log.UseCompatibleStateImageBehavior = false;
            this.listView_log.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_timestamp
            // 
            this.columnHeader_timestamp.Text = "Date";
            this.columnHeader_timestamp.Width = 130;
            // 
            // columnHeader_text
            // 
            this.columnHeader_text.Text = "Text";
            this.columnHeader_text.Width = 629;
            // 
            // panel_toolbar
            // 
            this.panel_toolbar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_toolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_toolbar.Controls.Add(this.label_title);
            this.panel_toolbar.Controls.Add(this.button_quit);
            this.panel_toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_toolbar.Location = new System.Drawing.Point(0, 0);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(783, 39);
            this.panel_toolbar.TabIndex = 0;
            this.panel_toolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_toolbar_MouseDown);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(5, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(137, 25);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "DSN Adaptor";
            // 
            // button_quit
            // 
            this.button_quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_quit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_quit.FlatAppearance.BorderSize = 0;
            this.button_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quit.Image = global::DSNadaptor.Properties.Resources._11586_200;
            this.button_quit.Location = new System.Drawing.Point(744, 0);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(37, 37);
            this.button_quit.TabIndex = 3;
            this.button_quit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_quit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // timer_checkConnected
            // 
            this.timer_checkConnected.Interval = 10000;
            this.timer_checkConnected.Tick += new System.EventHandler(this.timer_checkConnected_Tick);
            // 
            // openFileDialog_load
            // 
            this.openFileDialog_load.FileName = "*";
            // 
            // timer_LoopAgain
            // 
            this.timer_LoopAgain.Enabled = true;
            this.timer_LoopAgain.Interval = 1000;
            this.timer_LoopAgain.Tick += new System.EventHandler(this.timer_LoopAgain_Tick);
            // 
            // timer_CheckSFTP
            // 
            this.timer_CheckSFTP.Enabled = true;
            this.timer_CheckSFTP.Interval = 1800000;
            this.timer_CheckSFTP.Tick += new System.EventHandler(this.timer_CheckSFTP_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(933, 650);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_left);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_main";
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.tabControl_tabs.ResumeLayout(false);
            this.tabPage_dsn.ResumeLayout(false);
            this.tabPage_dsn.PerformLayout();
            this.panel_connections.ResumeLayout(false);
            this.panel_connections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_web)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_adaptor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_adapt2scc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_web2adapt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_scc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_adapt2web)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_request)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_authenticated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_localIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_connected)).EndInit();
            this.tabPage_testapi.ResumeLayout(false);
            this.tabPage_testapi.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.panel_openAMSettings.ResumeLayout(false);
            this.panel_openAMSettings.PerformLayout();
            this.panel_metadatasettings.ResumeLayout(false);
            this.panel_metadatasettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MonitorInterval)).EndInit();
            this.panel_UDPsettings.ResumeLayout(false);
            this.panel_UDPsettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_byteratio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_deliveryDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_addresses)).EndInit();
            this.panel_restAPI.ResumeLayout(false);
            this.panel_restAPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_queryServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RequestRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RequestInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RequestTimeout)).EndInit();
            this.panel_proxy.ResumeLayout(false);
            this.panel_proxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port)).EndInit();
            this.tabPage_SFTP.ResumeLayout(false);
            this.tabPage_SFTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_queued)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_SFTPlist)).EndInit();
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Button button_DSN;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Timer timer_checkConnected;
        private System.Windows.Forms.TabControl tabControl_tabs;
        private System.Windows.Forms.TabPage tabPage_dsn;
        private System.Windows.Forms.TextBox textBox_server;
        private System.Windows.Forms.PictureBox pictureBox_ping;
        private System.Windows.Forms.Label label_ping;
        private System.Windows.Forms.PictureBox pictureBox_authenticated;
        private System.Windows.Forms.Label label_authenticated;
        private System.Windows.Forms.PictureBox pictureBox_localIP;
        private System.Windows.Forms.Label label_localIP;
        private System.Windows.Forms.PictureBox pictureBox_connected;
        private System.Windows.Forms.Label label_connected;
        private System.Windows.Forms.TabPage tabPage_testapi;
        private System.Windows.Forms.Label label_UDPtest;
        private System.Windows.Forms.TextBox textBox_testURI;
        private System.Windows.Forms.TextBox textBox_testServer;
        private System.Windows.Forms.Button button_testExecute;
        private System.Windows.Forms.Label label_testURI;
        private System.Windows.Forms.Label label_TestServer;
        private System.Windows.Forms.Label label_apiTEST;
        private System.Windows.Forms.ListView listView_log;
        private System.Windows.Forms.ColumnHeader columnHeader_timestamp;
        private System.Windows.Forms.ColumnHeader columnHeader_text;
        private System.Windows.Forms.PictureBox pictureBox_request;
        private System.Windows.Forms.Label label_ValidRequest;
        private System.Windows.Forms.Button button_listen;
        private System.Windows.Forms.Button button_manual;
        private System.Windows.Forms.TabPage tabPage_manual;
        private System.Windows.Forms.PictureBox pictureBox_adaptor;
        private System.Windows.Forms.Label label_adaptor;
        private System.Windows.Forms.Label label_TLMdest;
        private System.Windows.Forms.PictureBox pictureBox_scc;
        private System.Windows.Forms.Label label_tlmWeb;
        private System.Windows.Forms.PictureBox pictureBox_web;
        private System.Windows.Forms.PictureBox pictureBox_adapt2web;
        private System.Windows.Forms.PictureBox pictureBox_adapt2scc;
        private System.Windows.Forms.PictureBox pictureBox_web2adapt;
        private System.Windows.Forms.Label label_queuesize;
        private System.Windows.Forms.Label label_queueCount;
        private System.Windows.Forms.Button button_APItest;
        private System.Windows.Forms.TextBox textBox_UDPport;
        private System.Windows.Forms.TextBox textBox_destUDPip;
        private System.Windows.Forms.Label label_udpPort;
        private System.Windows.Forms.Label label_destUDP;
        private System.Windows.Forms.Button button_udpTest;
        private System.Windows.Forms.Panel panel_connections;
        private System.Windows.Forms.CheckBox checkBox_deliminate;
        private System.Windows.Forms.Button button_Parse;
        private System.Windows.Forms.Button button_loadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog_load;
        private System.Windows.Forms.ProgressBar progressBar_prog;
        private System.Windows.Forms.RichTextBox richTextBox_response;
        private System.Windows.Forms.Label label_Progress;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Panel panel_proxy;
        private System.Windows.Forms.TextBox textBox_proxyaddress;
        private System.Windows.Forms.Label label_proxyServer;
        private System.Windows.Forms.Label label_proxySettings;
        private System.Windows.Forms.CheckBox checkBox_useProxy;
        private System.Windows.Forms.Label label_useProxy;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_proxyport;
        private System.Windows.Forms.Panel panel_restAPI;
        private System.Windows.Forms.TextBox textBox_SCID;
        private System.Windows.Forms.Label label_SpacecraftID;
        private System.Windows.Forms.TextBox textBox_webTLMaddress;
        private System.Windows.Forms.Label label_webTLMserver;
        private System.Windows.Forms.Label label_APIrest;
        private System.Windows.Forms.Panel panel_UDPsettings;
        private System.Windows.Forms.Label label_UDPports;
        private System.Windows.Forms.Label label_udpAddresses;
        private System.Windows.Forms.Label label_udpSettings;
        private System.Windows.Forms.DataGridView dataGridView_addresses;
        private System.Windows.Forms.Label label_DeliveryDelay;
        private System.Windows.Forms.DataGridView dataGridView_ports;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_addresses;
        private System.Windows.Forms.NumericUpDown numericUpDown_port;
        private System.Windows.Forms.NumericUpDown numericUpDown_deliveryDelay;
        private System.Windows.Forms.NumericUpDown numericUpDown_byteratio;
        private System.Windows.Forms.Label label_ByteRatio;
        private System.Windows.Forms.CheckBox checkBox_calcDelay;
        private System.Windows.Forms.Label label_CalcDelay;
        private System.Windows.Forms.Label label_baseURIcomment;
        private System.Windows.Forms.TextBox textBox_BaseURI;
        private System.Windows.Forms.Label label_BaseURI;
        private System.Windows.Forms.Label label_ms;
        private System.Windows.Forms.Label label_reqMs;
        private System.Windows.Forms.NumericUpDown numericUpDown_RequestTimeout;
        private System.Windows.Forms.Label label_RequestTimeout;
        private System.Windows.Forms.Label label_reqinms;
        private System.Windows.Forms.NumericUpDown numericUpDown_RequestInterval;
        private System.Windows.Forms.Label label_RequestInterval;
        private System.Windows.Forms.NumericUpDown numericUpDown_RequestRetry;
        private System.Windows.Forms.Label label_Retries;
        private System.Windows.Forms.Label label_sfdusync;
        private System.Windows.Forms.TextBox textBox_SFDUsync;
        private System.Windows.Forms.Panel panel_metadatasettings;
        private System.Windows.Forms.NumericUpDown numericUpDown_MonitorInterval;
        private System.Windows.Forms.Label label_CheckCOnnected;
        private System.Windows.Forms.Label label_metadata;
        private System.Windows.Forms.Label label_queryServer;
        private System.Windows.Forms.Button button_GetCookie;
        private System.Windows.Forms.Button button_GetToken;
        private System.Windows.Forms.Button button_PostWithCookie;
        private System.Windows.Forms.Panel panel_openAMSettings;
        private System.Windows.Forms.TextBox textBox_AuURI;
        private System.Windows.Forms.Label label_AUuri;
        private System.Windows.Forms.TextBox textBox_CookieURI;
        private System.Windows.Forms.Label label_Cookie;
        private System.Windows.Forms.TextBox textBox_AMpassword;
        private System.Windows.Forms.Label label_AMpassword;
        private System.Windows.Forms.TextBox textBox_AMuser;
        private System.Windows.Forms.Label label_AMuser;
        private System.Windows.Forms.TextBox textBox_AMserver;
        private System.Windows.Forms.Label label_OpenAMserver;
        private System.Windows.Forms.Label label_AuSettings;
        private System.Windows.Forms.CheckBox checkBox_useAu;
        private System.Windows.Forms.Label label_UseAU;
        private System.Windows.Forms.Button button_ExecuteStream;
        private System.Windows.Forms.Button button_GetCookieChrome;
        private System.Windows.Forms.Button button_LoadStream;
        private System.Windows.Forms.Label label_SfduRead;
        private System.Windows.Forms.DataGridView dataGridView_queryServers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox comboBox_QueryServers;
        private System.Windows.Forms.Label label_queryServers;
        private System.Windows.Forms.Label label_SFDUsent;
        private System.Windows.Forms.ProgressBar progressBar_queryLoopEnd;
        private System.Windows.Forms.Timer timer_LoopAgain;
        private System.Windows.Forms.DateTimePicker dateTimePicker_queryStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker_queryEnd;
        private System.Windows.Forms.Label label_queryEnd;
        private System.Windows.Forms.Label label_queryStart;
        private System.Windows.Forms.TextBox textBox_DSS;
        private System.Windows.Forms.Label label_dss;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_FTP;
        private System.Windows.Forms.Button button_SFTP;
        private System.Windows.Forms.TabPage tabPage_SFTP;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Timer timer_CheckSFTP;
        private BrightIdeasSoftware.ObjectListView objectListView_SFTPlist;
        private BrightIdeasSoftware.OLVColumn olvColumn_FileName;
        private BrightIdeasSoftware.OLVColumn olvColumn_FileDate;
        private System.Windows.Forms.Label label_SFDU_FILENAME;
        private System.Windows.Forms.Button button_sendLoadedFile;
        private System.Windows.Forms.Label label_SFDU_PROG;
        private System.Windows.Forms.Label label_Loading;
        private System.Windows.Forms.Label label1_SFDU_queue;
        private BrightIdeasSoftware.ObjectListView objectListView_queued;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
    }
}

