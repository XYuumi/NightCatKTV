namespace MyKtv_Client
{
    partial class frmSongList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSongList));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvShow = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJqSong = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbFw = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbChong = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChong)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "歌曲名称";
            this.columnHeader1.Width = 575;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "歌手";
            this.columnHeader2.Width = 300;
            // 
            // lvShow
            // 
            this.lvShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvShow.BackgroundImage")));
            this.lvShow.BackgroundImageTiled = true;
            this.lvShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvShow.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvShow.ForeColor = System.Drawing.Color.White;
            this.lvShow.FullRowSelect = true;
            this.lvShow.HideSelection = false;
            this.lvShow.Location = new System.Drawing.Point(1, 59);
            this.lvShow.Margin = new System.Windows.Forms.Padding(4);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(1138, 251);
            this.lvShow.TabIndex = 17;
            this.lvShow.TileSize = new System.Drawing.Size(300, 70);
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.Details;
            this.lvShow.SelectedIndexChanged += new System.EventHandler(this.lvShow_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblJqSong);
            this.panel1.Location = new System.Drawing.Point(-104, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 52);
            this.panel1.TabIndex = 18;
            // 
            // lblJqSong
            // 
            this.lblJqSong.AutoSize = true;
            this.lblJqSong.BackColor = System.Drawing.Color.Transparent;
            this.lblJqSong.Font = new System.Drawing.Font("华文彩云", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJqSong.ForeColor = System.Drawing.Color.Transparent;
            this.lblJqSong.Location = new System.Drawing.Point(601, 8);
            this.lblJqSong.Name = "lblJqSong";
            this.lblJqSong.Size = new System.Drawing.Size(157, 30);
            this.lblJqSong.TabIndex = 3;
            this.lblJqSong.Text = "歌 手 名 称";
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(988, 496);
            this.pbExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(68, 68);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbExit.TabIndex = 22;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbFw
            // 
            this.pbFw.BackColor = System.Drawing.Color.Transparent;
            this.pbFw.Image = ((System.Drawing.Image)(resources.GetObject("pbFw.Image")));
            this.pbFw.Location = new System.Drawing.Point(688, 497);
            this.pbFw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFw.Name = "pbFw";
            this.pbFw.Size = new System.Drawing.Size(68, 68);
            this.pbFw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFw.TabIndex = 21;
            this.pbFw.TabStop = false;
            this.pbFw.Click += new System.EventHandler(this.pbFw_Click);
            // 
            // pbNext
            // 
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(388, 497);
            this.pbNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(68, 68);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbNext.TabIndex = 20;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // pbChong
            // 
            this.pbChong.BackColor = System.Drawing.Color.Transparent;
            this.pbChong.Image = ((System.Drawing.Image)(resources.GetObject("pbChong.Image")));
            this.pbChong.Location = new System.Drawing.Point(88, 496);
            this.pbChong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbChong.Name = "pbChong";
            this.pbChong.Size = new System.Drawing.Size(68, 68);
            this.pbChong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbChong.TabIndex = 19;
            this.pbChong.TabStop = false;
            this.pbChong.Click += new System.EventHandler(this.pbChong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(694, 579);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 116;
            this.label1.Text = "已点";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Aqua;
            this.label10.Location = new System.Drawing.Point(994, 579);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 21);
            this.label10.TabIndex = 115;
            this.label10.Text = "返回";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(394, 579);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 114;
            this.label8.Text = "切歌";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(94, 579);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 113;
            this.label7.Text = "重唱";
            // 
            // frmSongList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbFw);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbChong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmOrderByClientCount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbFw;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbChong;
        public System.Windows.Forms.Label lblJqSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}