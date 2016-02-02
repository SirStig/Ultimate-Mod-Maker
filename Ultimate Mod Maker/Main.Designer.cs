namespace Ultimate_Mod_Maker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Topics");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Events");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Researches");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Platforms");
            this.GDT = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SInc = new System.Windows.Forms.Button();
            this.MC = new System.Windows.Forms.Button();
            this.quitMain = new System.Windows.Forms.Button();
            this.GDTPanel = new System.Windows.Forms.Panel();
            this.loadButton = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Panel();
            this.finishInfo = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.TextBox();
            this.gdtCustomCodeBox = new System.Windows.Forms.RichTextBox();
            this.customCode = new System.Windows.Forms.Button();
            this.topicPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mature = new System.Windows.Forms.ComboBox();
            this.everyone = new System.Windows.Forms.ComboBox();
            this.young = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.actionBar = new System.Windows.Forms.TrackBar();
            this.adventureBar = new System.Windows.Forms.TrackBar();
            this.RPGBar = new System.Windows.Forms.TrackBar();
            this.simulationBar = new System.Windows.Forms.TrackBar();
            this.strategyBar = new System.Windows.Forms.TrackBar();
            this.casualBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.topicName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modifications = new System.Windows.Forms.TreeView();
            this.gdtModName = new System.Windows.Forms.Label();
            this.gdtModNameBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backGDT = new System.Windows.Forms.Button();
            this.loadGDTMod = new System.Windows.Forms.OpenFileDialog();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.GDTPanel.SuspendLayout();
            this.info.SuspendLayout();
            this.topicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPGBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategyBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casualBar)).BeginInit();
            this.SuspendLayout();
            // 
            // GDT
            // 
            this.GDT.BackgroundImage = global::Ultimate_Mod_Maker.Properties.Resources.GDT;
            this.GDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GDT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GDT.Location = new System.Drawing.Point(122, 411);
            this.GDT.Name = "GDT";
            this.GDT.Size = new System.Drawing.Size(270, 129);
            this.GDT.TabIndex = 0;
            this.GDT.UseVisualStyleBackColor = true;
            this.GDT.Click += new System.EventHandler(this.gdtShowHide);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::Ultimate_Mod_Maker.Properties.Resources.BackGround;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1008, 551);
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(122, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(874, 393);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.TabStop = false;
            this.webBrowser1.Url = new System.Uri("http://ultimatemm.blogspot.com/", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // SInc
            // 
            this.SInc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SInc.BackgroundImage")));
            this.SInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SInc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SInc.Location = new System.Drawing.Point(425, 411);
            this.SInc.Name = "SInc";
            this.SInc.Size = new System.Drawing.Size(270, 129);
            this.SInc.TabIndex = 2;
            this.SInc.UseVisualStyleBackColor = true;
            // 
            // MC
            // 
            this.MC.BackgroundImage = global::Ultimate_Mod_Maker.Properties.Resources.MC;
            this.MC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MC.Location = new System.Drawing.Point(726, 411);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(270, 129);
            this.MC.TabIndex = 3;
            this.MC.UseVisualStyleBackColor = true;
            // 
            // quitMain
            // 
            this.quitMain.BackColor = System.Drawing.Color.Black;
            this.quitMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quitMain.BackgroundImage")));
            this.quitMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitMain.Location = new System.Drawing.Point(0, 449);
            this.quitMain.Name = "quitMain";
            this.quitMain.Size = new System.Drawing.Size(116, 102);
            this.quitMain.TabIndex = 4;
            this.quitMain.UseVisualStyleBackColor = false;
            this.quitMain.Click += new System.EventHandler(this.quitApp);
            // 
            // GDTPanel
            // 
            this.GDTPanel.BackgroundImage = global::Ultimate_Mod_Maker.Properties.Resources.BackGround;
            this.GDTPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GDTPanel.Controls.Add(this.label19);
            this.GDTPanel.Controls.Add(this.loadButton);
            this.GDTPanel.Controls.Add(this.customCode);
            this.GDTPanel.Controls.Add(this.topicPanel);
            this.GDTPanel.Controls.Add(this.modifications);
            this.GDTPanel.Controls.Add(this.gdtModName);
            this.GDTPanel.Controls.Add(this.gdtModNameBox);
            this.GDTPanel.Controls.Add(this.button3);
            this.GDTPanel.Controls.Add(this.button2);
            this.GDTPanel.Controls.Add(this.button1);
            this.GDTPanel.Controls.Add(this.backGDT);
            this.GDTPanel.Controls.Add(this.info);
            this.GDTPanel.Controls.Add(this.gdtCustomCodeBox);
            this.GDTPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GDTPanel.Location = new System.Drawing.Point(0, 0);
            this.GDTPanel.Name = "GDTPanel";
            this.GDTPanel.Size = new System.Drawing.Size(1008, 551);
            this.GDTPanel.TabIndex = 5;
            this.GDTPanel.Visible = false;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadButton.BackColor = System.Drawing.Color.Transparent;
            this.loadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadButton.BackgroundImage")));
            this.loadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loadButton.Enabled = false;
            this.loadButton.FlatAppearance.BorderSize = 0;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadButton.Location = new System.Drawing.Point(815, 0);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(193, 45);
            this.loadButton.TabIndex = 12;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadClicked);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Controls.Add(this.finishInfo);
            this.info.Controls.Add(this.label18);
            this.info.Controls.Add(this.description);
            this.info.Controls.Add(this.label17);
            this.info.Controls.Add(this.url);
            this.info.Controls.Add(this.label16);
            this.info.Controls.Add(this.author);
            this.info.Controls.Add(this.label15);
            this.info.Controls.Add(this.version);
            this.info.Location = new System.Drawing.Point(560, 51);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(461, 339);
            this.info.TabIndex = 11;
            this.info.Visible = false;
            // 
            // finishInfo
            // 
            this.finishInfo.BackColor = System.Drawing.Color.Transparent;
            this.finishInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finishInfo.BackgroundImage")));
            this.finishInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.finishInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.finishInfo.FlatAppearance.BorderSize = 0;
            this.finishInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.finishInfo.Location = new System.Drawing.Point(257, 12);
            this.finishInfo.Name = "finishInfo";
            this.finishInfo.Size = new System.Drawing.Size(192, 35);
            this.finishInfo.TabIndex = 12;
            this.finishInfo.Text = "Create Mod";
            this.finishInfo.UseVisualStyleBackColor = false;
            this.finishInfo.Click += new System.EventHandler(this.finishedInfo);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(97, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "Description";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(98, 180);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(319, 142);
            this.description.TabIndex = 6;
            this.description.Text = "This mod is made by the Ultimate Mod Maker.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(50, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "URL";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(98, 122);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(319, 20);
            this.url.TabIndex = 4;
            this.url.Text = "www.swiftl.weebly.com";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(29, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Authors";
            // 
            // author
            // 
            this.author.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.author.Location = new System.Drawing.Point(98, 77);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(106, 20);
            this.author.TabIndex = 2;
            this.author.Text = "UMM Modder";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(31, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Version";
            // 
            // version
            // 
            this.version.Location = new System.Drawing.Point(98, 28);
            this.version.MaxLength = 5;
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(106, 20);
            this.version.TabIndex = 0;
            this.version.Text = "1";
            this.version.WordWrap = false;
            // 
            // gdtCustomCodeBox
            // 
            this.gdtCustomCodeBox.AcceptsTab = true;
            this.gdtCustomCodeBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.gdtCustomCodeBox.DetectUrls = false;
            this.gdtCustomCodeBox.ForeColor = System.Drawing.SystemColors.Window;
            this.gdtCustomCodeBox.Location = new System.Drawing.Point(-12, 67);
            this.gdtCustomCodeBox.Name = "gdtCustomCodeBox";
            this.gdtCustomCodeBox.Size = new System.Drawing.Size(931, 422);
            this.gdtCustomCodeBox.TabIndex = 0;
            this.gdtCustomCodeBox.Text = "";
            this.gdtCustomCodeBox.Visible = false;
            this.gdtCustomCodeBox.TextChanged += new System.EventHandler(this.customCodeChanged);
            // 
            // customCode
            // 
            this.customCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customCode.BackColor = System.Drawing.Color.Transparent;
            this.customCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customCode.BackgroundImage")));
            this.customCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customCode.FlatAppearance.BorderSize = 0;
            this.customCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customCode.Location = new System.Drawing.Point(219, 50);
            this.customCode.Name = "customCode";
            this.customCode.Size = new System.Drawing.Size(207, 49);
            this.customCode.TabIndex = 10;
            this.customCode.Text = "Source Editor";
            this.customCode.UseVisualStyleBackColor = false;
            this.customCode.Click += new System.EventHandler(this.customCodeClicked);
            // 
            // topicPanel
            // 
            this.topicPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topicPanel.BackColor = System.Drawing.Color.Transparent;
            this.topicPanel.Controls.Add(this.label20);
            this.topicPanel.Controls.Add(this.button4);
            this.topicPanel.Controls.Add(this.label14);
            this.topicPanel.Controls.Add(this.label13);
            this.topicPanel.Controls.Add(this.label12);
            this.topicPanel.Controls.Add(this.mature);
            this.topicPanel.Controls.Add(this.everyone);
            this.topicPanel.Controls.Add(this.young);
            this.topicPanel.Controls.Add(this.label11);
            this.topicPanel.Controls.Add(this.label10);
            this.topicPanel.Controls.Add(this.label9);
            this.topicPanel.Controls.Add(this.label8);
            this.topicPanel.Controls.Add(this.label7);
            this.topicPanel.Controls.Add(this.label6);
            this.topicPanel.Controls.Add(this.label5);
            this.topicPanel.Controls.Add(this.label4);
            this.topicPanel.Controls.Add(this.label3);
            this.topicPanel.Controls.Add(this.actionBar);
            this.topicPanel.Controls.Add(this.adventureBar);
            this.topicPanel.Controls.Add(this.RPGBar);
            this.topicPanel.Controls.Add(this.simulationBar);
            this.topicPanel.Controls.Add(this.strategyBar);
            this.topicPanel.Controls.Add(this.casualBar);
            this.topicPanel.Controls.Add(this.label2);
            this.topicPanel.Controls.Add(this.topicName);
            this.topicPanel.Controls.Add(this.label1);
            this.topicPanel.Location = new System.Drawing.Point(0, 108);
            this.topicPanel.Name = "topicPanel";
            this.topicPanel.Size = new System.Drawing.Size(1008, 443);
            this.topicPanel.TabIndex = 9;
            this.topicPanel.Visible = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(3, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 56);
            this.button4.TabIndex = 11;
            this.button4.Text = "Add Topic";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.addTopicToMods);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(21, 214);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Mature";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(19, 158);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Everyone";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(19, 98);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Young";
            // 
            // mature
            // 
            this.mature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mature.FormattingEnabled = true;
            this.mature.Items.AddRange(new object[] {
            "Amazing",
            "Good",
            "Bad"});
            this.mature.Location = new System.Drawing.Point(19, 237);
            this.mature.Name = "mature";
            this.mature.Size = new System.Drawing.Size(136, 21);
            this.mature.TabIndex = 26;
            this.mature.Text = "Good";
            this.mature.SelectedIndexChanged += new System.EventHandler(this.matureValueSet);
            // 
            // everyone
            // 
            this.everyone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.everyone.FormattingEnabled = true;
            this.everyone.Items.AddRange(new object[] {
            "Amazing",
            "Good",
            "Bad"});
            this.everyone.Location = new System.Drawing.Point(19, 181);
            this.everyone.Name = "everyone";
            this.everyone.Size = new System.Drawing.Size(136, 21);
            this.everyone.TabIndex = 25;
            this.everyone.Text = "Good";
            this.everyone.SelectedIndexChanged += new System.EventHandler(this.everyoneValueSet);
            // 
            // young
            // 
            this.young.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.young.FormattingEnabled = true;
            this.young.Items.AddRange(new object[] {
            "Amazing",
            "Good",
            "Bad"});
            this.young.Location = new System.Drawing.Point(19, 126);
            this.young.Name = "young";
            this.young.Size = new System.Drawing.Size(136, 21);
            this.young.TabIndex = 24;
            this.young.Text = "Good";
            this.young.SelectedIndexChanged += new System.EventHandler(this.youngValueSet);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(918, 117);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Casual";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(767, 117);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Strategy";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(632, 117);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Simulation";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(521, 118);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "RPG";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(361, 117);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Adventure";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(260, 117);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Action";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(224, 400);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bad";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(213, 277);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Good";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(191, 140);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amazing";
            // 
            // actionBar
            // 
            this.actionBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.actionBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.actionBar.LargeChange = 1;
            this.actionBar.Location = new System.Drawing.Point(265, 140);
            this.actionBar.Maximum = 3;
            this.actionBar.Minimum = 1;
            this.actionBar.Name = "actionBar";
            this.actionBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.actionBar.Size = new System.Drawing.Size(45, 291);
            this.actionBar.TabIndex = 8;
            this.actionBar.Value = 2;
            this.actionBar.ValueChanged += new System.EventHandler(this.actionValueSet);
            // 
            // adventureBar
            // 
            this.adventureBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.adventureBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adventureBar.LargeChange = 1;
            this.adventureBar.Location = new System.Drawing.Point(379, 141);
            this.adventureBar.Maximum = 3;
            this.adventureBar.Minimum = 1;
            this.adventureBar.Name = "adventureBar";
            this.adventureBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.adventureBar.Size = new System.Drawing.Size(45, 291);
            this.adventureBar.TabIndex = 7;
            this.adventureBar.Value = 2;
            this.adventureBar.ValueChanged += new System.EventHandler(this.adventureValueSet);
            // 
            // RPGBar
            // 
            this.RPGBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RPGBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RPGBar.LargeChange = 1;
            this.RPGBar.Location = new System.Drawing.Point(516, 141);
            this.RPGBar.Maximum = 3;
            this.RPGBar.Minimum = 1;
            this.RPGBar.Name = "RPGBar";
            this.RPGBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RPGBar.Size = new System.Drawing.Size(45, 291);
            this.RPGBar.TabIndex = 6;
            this.RPGBar.Value = 2;
            this.RPGBar.ValueChanged += new System.EventHandler(this.rpgValueSet);
            // 
            // simulationBar
            // 
            this.simulationBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.simulationBar.LargeChange = 1;
            this.simulationBar.Location = new System.Drawing.Point(651, 140);
            this.simulationBar.Maximum = 3;
            this.simulationBar.Minimum = 1;
            this.simulationBar.Name = "simulationBar";
            this.simulationBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.simulationBar.Size = new System.Drawing.Size(45, 291);
            this.simulationBar.TabIndex = 5;
            this.simulationBar.Value = 2;
            this.simulationBar.ValueChanged += new System.EventHandler(this.simulationValueSet);
            // 
            // strategyBar
            // 
            this.strategyBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.strategyBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.strategyBar.LargeChange = 1;
            this.strategyBar.Location = new System.Drawing.Point(791, 140);
            this.strategyBar.Maximum = 3;
            this.strategyBar.Minimum = 1;
            this.strategyBar.Name = "strategyBar";
            this.strategyBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.strategyBar.Size = new System.Drawing.Size(45, 291);
            this.strategyBar.TabIndex = 4;
            this.strategyBar.Value = 2;
            this.strategyBar.ValueChanged += new System.EventHandler(this.strategyValueSet);
            // 
            // casualBar
            // 
            this.casualBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.casualBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.casualBar.LargeChange = 1;
            this.casualBar.Location = new System.Drawing.Point(932, 140);
            this.casualBar.Maximum = 3;
            this.casualBar.Minimum = 1;
            this.casualBar.Name = "casualBar";
            this.casualBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.casualBar.Size = new System.Drawing.Size(45, 291);
            this.casualBar.TabIndex = 3;
            this.casualBar.Value = 2;
            this.casualBar.ValueChanged += new System.EventHandler(this.casualValueSet);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 346);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Topic Name";
            // 
            // topicName
            // 
            this.topicName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.topicName.BackColor = System.Drawing.SystemColors.Window;
            this.topicName.Location = new System.Drawing.Point(3, 369);
            this.topicName.Name = "topicName";
            this.topicName.Size = new System.Drawing.Size(171, 20);
            this.topicName.TabIndex = 1;
            this.topicName.Text = "Random Topic";
            this.topicName.TextChanged += new System.EventHandler(this.topicChangeName);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Topic:";
            // 
            // modifications
            // 
            this.modifications.BackColor = System.Drawing.Color.Black;
            this.modifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifications.ForeColor = System.Drawing.SystemColors.Info;
            this.modifications.Location = new System.Drawing.Point(3, 105);
            this.modifications.Name = "modifications";
            treeNode5.Name = "Topics";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.Text = "Topics";
            treeNode5.ToolTipText = "The list of topics added";
            treeNode6.Name = "Events";
            treeNode6.Text = "Events";
            treeNode7.Name = "Researches";
            treeNode7.Text = "Researches";
            treeNode8.Name = "Platforms";
            treeNode8.Text = "Platforms";
            this.modifications.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.modifications.Size = new System.Drawing.Size(993, 392);
            this.modifications.TabIndex = 7;
            this.modifications.Visible = false;
            // 
            // gdtModName
            // 
            this.gdtModName.AutoSize = true;
            this.gdtModName.BackColor = System.Drawing.Color.Transparent;
            this.gdtModName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gdtModName.Location = new System.Drawing.Point(64, 9);
            this.gdtModName.Name = "gdtModName";
            this.gdtModName.Size = new System.Drawing.Size(126, 13);
            this.gdtModName.TabIndex = 6;
            this.gdtModName.Text = "Ultimate Mod Maker Mod";
            this.gdtModName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gdtModNameBox
            // 
            this.gdtModNameBox.Location = new System.Drawing.Point(7, 24);
            this.gdtModNameBox.Name = "gdtModNameBox";
            this.gdtModNameBox.Size = new System.Drawing.Size(174, 20);
            this.gdtModNameBox.TabIndex = 5;
            this.gdtModNameBox.TextChanged += new System.EventHandler(this.changeGDTModName);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(12, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add a Topic";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.topicPanelShowHide);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(602, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.finishClicked);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(403, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modifications";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.modificationsClicked);
            // 
            // backGDT
            // 
            this.backGDT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backGDT.BackColor = System.Drawing.Color.Transparent;
            this.backGDT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backGDT.BackgroundImage")));
            this.backGDT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backGDT.FlatAppearance.BorderSize = 0;
            this.backGDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backGDT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backGDT.Location = new System.Drawing.Point(209, 2);
            this.backGDT.Name = "backGDT";
            this.backGDT.Size = new System.Drawing.Size(188, 42);
            this.backGDT.TabIndex = 1;
            this.backGDT.Text = "Back to Menu";
            this.backGDT.UseVisualStyleBackColor = false;
            this.backGDT.Click += new System.EventHandler(this.gdtShowHide);
            // 
            // loadGDTMod
            // 
            this.loadGDTMod.AddExtension = false;
            this.loadGDTMod.Title = "Load a GDT Mod";
            this.loadGDTMod.FileOk += new System.ComponentModel.CancelEventHandler(this.openGDTMod);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(4, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Mod Name:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(206, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(650, 65);
            this.label20.TabIndex = 30;
            this.label20.Text = resources.GetString("label20.Text");
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 551);
            this.Controls.Add(this.GDTPanel);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.GDT);
            this.Controls.Add(this.SInc);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.quitMain);
            this.Controls.Add(this.pictureBox7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 590);
            this.Name = "Main";
            this.Text = "Ultimate Mod Maker";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.GDTPanel.ResumeLayout(false);
            this.GDTPanel.PerformLayout();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.topicPanel.ResumeLayout(false);
            this.topicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPGBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategyBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casualBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GDT;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button SInc;
        private System.Windows.Forms.Button MC;
        private System.Windows.Forms.Button quitMain;
        private System.Windows.Forms.Panel GDTPanel;
        private System.Windows.Forms.Label gdtModName;
        private System.Windows.Forms.TextBox gdtModNameBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backGDT;
        private System.Windows.Forms.TreeView modifications;
        private System.Windows.Forms.Panel topicPanel;
        private System.Windows.Forms.Button customCode;
        private System.Windows.Forms.TextBox topicName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar actionBar;
        private System.Windows.Forms.TrackBar adventureBar;
        private System.Windows.Forms.TrackBar RPGBar;
        private System.Windows.Forms.TrackBar simulationBar;
        private System.Windows.Forms.TrackBar strategyBar;
        private System.Windows.Forms.TrackBar casualBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox young;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox mature;
        private System.Windows.Forms.ComboBox everyone;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox gdtCustomCodeBox;
        private System.Windows.Forms.Panel info;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox version;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button finishInfo;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog loadGDTMod;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

