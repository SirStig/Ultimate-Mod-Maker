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
            this.GDT = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SInc = new System.Windows.Forms.Button();
            this.MC = new System.Windows.Forms.Button();
            this.quitMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
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
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::Ultimate_Mod_Maker.Properties.Resources.BackGround;
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
            // Main
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 551);
            this.Controls.Add(this.quitMain);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.SInc);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.GDT);
            this.Controls.Add(this.pictureBox7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Ultimate Mod Maker";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GDT;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button SInc;
        private System.Windows.Forms.Button MC;
        private System.Windows.Forms.Button quitMain;
    }
}

