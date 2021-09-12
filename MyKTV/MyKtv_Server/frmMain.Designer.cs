namespace MyKtv_Server
{
    partial class frmMain
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
            this.ssS = new System.Windows.Forms.StatusStrip();
            this.tsslLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStrip = new System.Windows.Forms.ToolStrip();
            this.msStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiJiBen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSingerType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSingerAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSongType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSongAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAdminNews = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResource = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssS.SuspendLayout();
            this.msStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssS
            // 
            this.ssS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLoginName});
            this.ssS.Location = new System.Drawing.Point(0, 517);
            this.ssS.Name = "ssS";
            this.ssS.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.ssS.Size = new System.Drawing.Size(656, 22);
            this.ssS.TabIndex = 2;
            this.ssS.Text = "statusStrip1";
            // 
            // tsslLoginName
            // 
            this.tsslLoginName.Name = "tsslLoginName";
            this.tsslLoginName.Size = new System.Drawing.Size(56, 17);
            this.tsslLoginName.Text = "登录名：";
            // 
            // tsStrip
            // 
            this.tsStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsStrip.Location = new System.Drawing.Point(0, 25);
            this.tsStrip.Name = "tsStrip";
            this.tsStrip.Size = new System.Drawing.Size(656, 25);
            this.tsStrip.TabIndex = 7;
            this.tsStrip.Text = "toolStrip1";
            // 
            // msStrip
            // 
            this.msStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiJiBen,
            this.tsmiSinger,
            this.tsmiSong,
            this.tsmiAdmin,
            this.tsmiHelp});
            this.msStrip.Location = new System.Drawing.Point(0, 0);
            this.msStrip.Name = "msStrip";
            this.msStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msStrip.Size = new System.Drawing.Size(656, 25);
            this.msStrip.TabIndex = 8;
            this.msStrip.Text = "menuStrip1";
            // 
            // tsmiJiBen
            // 
            this.tsmiJiBen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiJiBen.Name = "tsmiJiBen";
            this.tsmiJiBen.Size = new System.Drawing.Size(44, 21);
            this.tsmiJiBen.Text = "基本";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.tsmiExit.Size = new System.Drawing.Size(172, 22);
            this.tsmiExit.Text = "退出（&X）";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiSinger
            // 
            this.tsmiSinger.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSingerType,
            this.tsmiSingerAdmin});
            this.tsmiSinger.Name = "tsmiSinger";
            this.tsmiSinger.Size = new System.Drawing.Size(68, 21);
            this.tsmiSinger.Text = "歌手管理";
            this.tsmiSinger.Click += new System.EventHandler(this.歌手类型管理ToolStripMenuItem_Click);
            // 
            // tsmiSingerType
            // 
            this.tsmiSingerType.Name = "tsmiSingerType";
            this.tsmiSingerType.Size = new System.Drawing.Size(148, 22);
            this.tsmiSingerType.Text = "歌手类型管理";
            this.tsmiSingerType.Click += new System.EventHandler(this.tsmiSingerType_Click);
            // 
            // tsmiSingerAdmin
            // 
            this.tsmiSingerAdmin.Name = "tsmiSingerAdmin";
            this.tsmiSingerAdmin.Size = new System.Drawing.Size(148, 22);
            this.tsmiSingerAdmin.Text = "歌手管理";
            this.tsmiSingerAdmin.Click += new System.EventHandler(this.tsmiSingerAdmin_Click);
            // 
            // tsmiSong
            // 
            this.tsmiSong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSongType,
            this.tsmiSongAdmin});
            this.tsmiSong.Name = "tsmiSong";
            this.tsmiSong.Size = new System.Drawing.Size(68, 21);
            this.tsmiSong.Text = "歌曲管理";
            // 
            // tsmiSongType
            // 
            this.tsmiSongType.Name = "tsmiSongType";
            this.tsmiSongType.Size = new System.Drawing.Size(148, 22);
            this.tsmiSongType.Text = "歌曲类型管理";
            this.tsmiSongType.Click += new System.EventHandler(this.tsmiSongType_Click);
            // 
            // tsmiSongAdmin
            // 
            this.tsmiSongAdmin.Name = "tsmiSongAdmin";
            this.tsmiSongAdmin.Size = new System.Drawing.Size(148, 22);
            this.tsmiSongAdmin.Text = "歌曲管理";
            this.tsmiSongAdmin.Click += new System.EventHandler(this.tsmiSongAdmin_Click);
            // 
            // tsmiAdmin
            // 
            this.tsmiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tsmiAdminNews,
            this.tsmiResource});
            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(80, 21);
            this.tsmiAdmin.Text = "管理员管理";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiAdminNews
            // 
            this.tsmiAdminNews.Name = "tsmiAdminNews";
            this.tsmiAdminNews.Size = new System.Drawing.Size(148, 22);
            this.tsmiAdminNews.Text = "管理信息管理";
            this.tsmiAdminNews.Click += new System.EventHandler(this.tsmiAdminNews_Click);
            // 
            // tsmiResource
            // 
            this.tsmiResource.Name = "tsmiResource";
            this.tsmiResource.Size = new System.Drawing.Size(148, 22);
            this.tsmiResource.Text = "资源项目管理";
            this.tsmiResource.Click += new System.EventHandler(this.tsmiResource_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 21);
            this.tsmiHelp.Text = "帮助";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(124, 22);
            this.tsmiAbout.Text = "关于我们";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 539);
            this.Controls.Add(this.tsStrip);
            this.Controls.Add(this.ssS);
            this.Controls.Add(this.msStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV-后台管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ssS.ResumeLayout(false);
            this.ssS.PerformLayout();
            this.msStrip.ResumeLayout(false);
            this.msStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssS;
        public System.Windows.Forms.ToolStripStatusLabel tsslLoginName;
        private System.Windows.Forms.ToolStrip tsStrip;
        private System.Windows.Forms.MenuStrip msStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiJiBen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSinger;
        private System.Windows.Forms.ToolStripMenuItem tsmiSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiSingerType;
        private System.Windows.Forms.ToolStripMenuItem tsmiSongType;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdminNews;
        private System.Windows.Forms.ToolStripMenuItem tsmiResource;
        private System.Windows.Forms.ToolStripMenuItem tsmiSingerAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiSongAdmin;
    }
}