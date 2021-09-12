namespace MyKtv_Client
{
    partial class frmStarList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStarList));
            this.pbRelSong = new System.Windows.Forms.PictureBox();
            this.pbNextSong = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJqSong = new System.Windows.Forms.Label();
            this.lvShow = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRelSong
            // 
            this.pbRelSong.BackColor = System.Drawing.Color.Transparent;
            this.pbRelSong.Image = ((System.Drawing.Image)(resources.GetObject("pbRelSong.Image")));
            this.pbRelSong.Location = new System.Drawing.Point(83, 494);
            this.pbRelSong.Margin = new System.Windows.Forms.Padding(2);
            this.pbRelSong.Name = "pbRelSong";
            this.pbRelSong.Size = new System.Drawing.Size(68, 68);
            this.pbRelSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRelSong.TabIndex = 24;
            this.pbRelSong.TabStop = false;
            this.pbRelSong.Click += new System.EventHandler(this.pbRelSong_Click);
            // 
            // pbNextSong
            // 
            this.pbNextSong.BackColor = System.Drawing.Color.Transparent;
            this.pbNextSong.Image = ((System.Drawing.Image)(resources.GetObject("pbNextSong.Image")));
            this.pbNextSong.Location = new System.Drawing.Point(383, 494);
            this.pbNextSong.Margin = new System.Windows.Forms.Padding(2);
            this.pbNextSong.Name = "pbNextSong";
            this.pbNextSong.Size = new System.Drawing.Size(68, 68);
            this.pbNextSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbNextSong.TabIndex = 23;
            this.pbNextSong.TabStop = false;
            this.pbNextSong.Click += new System.EventHandler(this.pbNextSong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(683, 494);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(983, 494);
            this.pbExit.Margin = new System.Windows.Forms.Padding(2);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(68, 68);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbExit.TabIndex = 21;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblJqSong);
            this.panel1.Location = new System.Drawing.Point(-111, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 52);
            this.panel1.TabIndex = 26;
            // 
            // lblJqSong
            // 
            this.lblJqSong.AutoSize = true;
            this.lblJqSong.BackColor = System.Drawing.Color.Transparent;
            this.lblJqSong.Font = new System.Drawing.Font("华文彩云", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblJqSong.ForeColor = System.Drawing.Color.Transparent;
            this.lblJqSong.Location = new System.Drawing.Point(613, 9);
            this.lblJqSong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJqSong.Name = "lblJqSong";
            this.lblJqSong.Size = new System.Drawing.Size(133, 30);
            this.lblJqSong.TabIndex = 1;
            this.lblJqSong.Text = "歌手列表";
            this.lblJqSong.Click += new System.EventHandler(this.lblJqSong_Click);
            // 
            // lvShow
            // 
            this.lvShow.BackColor = System.Drawing.Color.SteelBlue;
            this.lvShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvShow.BackgroundImage")));
            this.lvShow.BackgroundImageTiled = true;
            this.lvShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvShow.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvShow.ForeColor = System.Drawing.Color.White;
            this.lvShow.FullRowSelect = true;
            this.lvShow.HideSelection = false;
            this.lvShow.LargeImageList = this.imageList1;
            this.lvShow.Location = new System.Drawing.Point(12, 57);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(1128, 296);
            this.lvShow.TabIndex = 25;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.SelectedIndexChanged += new System.EventHandler(this.lvShow_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Avril Ramona Lavigne .jpg");
            this.imageList1.Images.SetKeyName(1, "bobo.jpg");
            this.imageList1.Images.SetKeyName(2, "default.jpg");
            this.imageList1.Images.SetKeyName(3, "fa941c0b43b1ece027e87f642e8dc4a067b6975b162ed-Upsjxa_fw658.jpg");
            this.imageList1.Images.SetKeyName(4, "Michael Jackson.jpg");
            this.imageList1.Images.SetKeyName(5, "RADWIMPS.jpg");
            this.imageList1.Images.SetKeyName(6, "super junior.jpg");
            this.imageList1.Images.SetKeyName(7, "thQL2ZPDU7.jpg");
            this.imageList1.Images.SetKeyName(8, "timg.jpg");
            this.imageList1.Images.SetKeyName(9, "timg1.jpg");
            this.imageList1.Images.SetKeyName(10, "timg6OU13L29.jpg");
            this.imageList1.Images.SetKeyName(11, "timgB786XU8O.jpg");
            this.imageList1.Images.SetKeyName(12, "timgEISEQIJ0.jpg");
            this.imageList1.Images.SetKeyName(13, "timgN9MS3300.jpg");
            this.imageList1.Images.SetKeyName(14, "untitled.png");
            this.imageList1.Images.SetKeyName(15, "untitled2.png");
            this.imageList1.Images.SetKeyName(16, "安室奈美惠.jpg");
            this.imageList1.Images.SetKeyName(17, "侧田.jpg");
            this.imageList1.Images.SetKeyName(18, "初音未来.jpg");
            this.imageList1.Images.SetKeyName(19, "东方神起.jpg");
            this.imageList1.Images.SetKeyName(20, "方大同.jpg");
            this.imageList1.Images.SetKeyName(21, "何韵诗.jpg");
            this.imageList1.Images.SetKeyName(22, "后街男孩.jpg");
            this.imageList1.Images.SetKeyName(23, "后弦.jpg");
            this.imageList1.Images.SetKeyName(24, "花泽香菜.jpg");
            this.imageList1.Images.SetKeyName(25, "界面3.jpg");
            this.imageList1.Images.SetKeyName(26, "乐正绫.jpg");
            this.imageList1.Images.SetKeyName(27, "李谷一.jpg");
            this.imageList1.Images.SetKeyName(28, "李孝利.jpg");
            this.imageList1.Images.SetKeyName(29, "李宇春.jpg");
            this.imageList1.Images.SetKeyName(30, "李云松.jpg");
            this.imageList1.Images.SetKeyName(31, "林肯公园.jpg");
            this.imageList1.Images.SetKeyName(32, "洛天依.jpg");
            this.imageList1.Images.SetKeyName(33, "米津玄师.jpg");
            this.imageList1.Images.SetKeyName(34, "那英.jpg");
            this.imageList1.Images.SetKeyName(35, "双笙.jpg");
            this.imageList1.Images.SetKeyName(36, "苏打绿.jpg");
            this.imageList1.Images.SetKeyName(37, "索隆549016fdfaaf5167a8.png");
            this.imageList1.Images.SetKeyName(38, "王若琳.jpg");
            this.imageList1.Images.SetKeyName(39, "小沈阳.jpg");
            this.imageList1.Images.SetKeyName(40, "许嵩.jpg");
            this.imageList1.Images.SetKeyName(41, "薛之谦.jpg");
            this.imageList1.Images.SetKeyName(42, "言和.jpg");
            this.imageList1.Images.SetKeyName(43, "暂无图片.jpg");
            this.imageList1.Images.SetKeyName(44, "暂无图片_1.jpg");
            this.imageList1.Images.SetKeyName(45, "张国荣.jpg");
            this.imageList1.Images.SetKeyName(46, "张学友.jpg");
            this.imageList1.Images.SetKeyName(47, "周杰伦.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(689, 573);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 112;
            this.label1.Text = "已点";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(989, 573);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 21);
            this.label10.TabIndex = 111;
            this.label10.Text = "返回";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(389, 573);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 110;
            this.label8.Text = "切歌";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(89, 573);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 109;
            this.label7.Text = "重唱";
            // 
            // frmStarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.pbRelSong);
            this.Controls.Add(this.pbNextSong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbExit);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStarList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRelSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRelSong;
        private System.Windows.Forms.PictureBox pbNextSong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblJqSong;
    }
}