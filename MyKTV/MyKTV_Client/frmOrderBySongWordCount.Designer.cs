namespace MyKtv_Client
{
    partial class frmOrderBySongWordCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderBySongWordCount));
            this.lvShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMore = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnfrmOrderBySongWordCount = new System.Windows.Forms.Button();
            this.pbYIDian = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbNextSong = new System.Windows.Forms.PictureBox();
            this.pbRelSong = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbYIDian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelSong)).BeginInit();
            this.SuspendLayout();
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
            this.lvShow.Location = new System.Drawing.Point(560, 29);
            this.lvShow.Margin = new System.Windows.Forms.Padding(4);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(557, 588);
            this.lvShow.TabIndex = 16;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.Details;
            this.lvShow.SelectedIndexChanged += new System.EventHandler(this.lvShow_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "歌曲名称";
            this.columnHeader1.Width = 266;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "歌手";
            this.columnHeader2.Width = 290;
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.Transparent;
            this.btnMore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMore.BackgroundImage")));
            this.btnMore.FlatAppearance.BorderSize = 0;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnMore.ForeColor = System.Drawing.Color.Transparent;
            this.btnMore.Location = new System.Drawing.Point(90, 386);
            this.btnMore.Margin = new System.Windows.Forms.Padding(4);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(401, 59);
            this.btnMore.TabIndex = 15;
            this.btnMore.Text = "更多";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("幼圆", 20F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn3.Location = new System.Drawing.Point(79, 203);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(192, 54);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "三字歌曲";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4.BackgroundImage")));
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("幼圆", 20F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn4.Location = new System.Drawing.Point(320, 203);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(192, 54);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "四字歌曲";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5.BackgroundImage")));
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("幼圆", 20F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn5.Location = new System.Drawing.Point(79, 295);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(192, 54);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "五字歌曲";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn6.BackgroundImage")));
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("幼圆", 20F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn6.Location = new System.Drawing.Point(320, 295);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(192, 54);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "六字歌曲";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("幼圆", 20F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn2.Location = new System.Drawing.Point(320, 111);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(192, 54);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "两字歌曲";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnfrmOrderBySongWordCount
            // 
            this.btnfrmOrderBySongWordCount.BackColor = System.Drawing.Color.Transparent;
            this.btnfrmOrderBySongWordCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfrmOrderBySongWordCount.BackgroundImage")));
            this.btnfrmOrderBySongWordCount.FlatAppearance.BorderSize = 0;
            this.btnfrmOrderBySongWordCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfrmOrderBySongWordCount.Font = new System.Drawing.Font("幼圆", 20F, System.Drawing.FontStyle.Bold);
            this.btnfrmOrderBySongWordCount.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnfrmOrderBySongWordCount.Location = new System.Drawing.Point(79, 111);
            this.btnfrmOrderBySongWordCount.Margin = new System.Windows.Forms.Padding(4);
            this.btnfrmOrderBySongWordCount.Name = "btnfrmOrderBySongWordCount";
            this.btnfrmOrderBySongWordCount.Size = new System.Drawing.Size(192, 54);
            this.btnfrmOrderBySongWordCount.TabIndex = 9;
            this.btnfrmOrderBySongWordCount.Text = "一字歌曲";
            this.btnfrmOrderBySongWordCount.UseVisualStyleBackColor = false;
            this.btnfrmOrderBySongWordCount.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pbYIDian
            // 
            this.pbYIDian.BackColor = System.Drawing.Color.Transparent;
            this.pbYIDian.Image = ((System.Drawing.Image)(resources.GetObject("pbYIDian.Image")));
            this.pbYIDian.Location = new System.Drawing.Point(471, 499);
            this.pbYIDian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbYIDian.Name = "pbYIDian";
            this.pbYIDian.Size = new System.Drawing.Size(68, 68);
            this.pbYIDian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbYIDian.TabIndex = 17;
            this.pbYIDian.TabStop = false;
            this.pbYIDian.Click += new System.EventHandler(this.pbYIDian_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 499);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbNextSong
            // 
            this.pbNextSong.BackColor = System.Drawing.Color.Transparent;
            this.pbNextSong.Image = ((System.Drawing.Image)(resources.GetObject("pbNextSong.Image")));
            this.pbNextSong.Location = new System.Drawing.Point(177, 499);
            this.pbNextSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbNextSong.Name = "pbNextSong";
            this.pbNextSong.Size = new System.Drawing.Size(68, 68);
            this.pbNextSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbNextSong.TabIndex = 19;
            this.pbNextSong.TabStop = false;
            this.pbNextSong.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbRelSong
            // 
            this.pbRelSong.BackColor = System.Drawing.Color.Transparent;
            this.pbRelSong.Image = ((System.Drawing.Image)(resources.GetObject("pbRelSong.Image")));
            this.pbRelSong.Location = new System.Drawing.Point(32, 499);
            this.pbRelSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRelSong.Name = "pbRelSong";
            this.pbRelSong.Size = new System.Drawing.Size(68, 68);
            this.pbRelSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRelSong.TabIndex = 20;
            this.pbRelSong.TabStop = false;
            this.pbRelSong.Click += new System.EventHandler(this.pbRelSong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("华文彩云", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(169, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 50);
            this.label6.TabIndex = 26;
            this.label6.Text = "字数点歌";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(329, 569);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "已点";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(466, 569);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "主界面";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(187, 569);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "切歌";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(40, 569);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "重唱";
            // 
            // frmOrderBySongWordCount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbRelSong);
            this.Controls.Add(this.pbNextSong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbYIDian);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnfrmOrderBySongWordCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderBySongWordCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmOrderBySongWordCount_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbYIDian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelSong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOneSong;
        private System.Windows.Forms.Button btnTwoSong;
        private System.Windows.Forms.Button btnTreeSong;
        private System.Windows.Forms.Button btnForeSong;
        private System.Windows.Forms.Button btnFiveSong;
        private System.Windows.Forms.Button btnSixSong;
        private System.Windows.Forms.Button btnSome;
        private System.Windows.Forms.ListView lvSong;
        private System.Windows.Forms.ColumnHeader SongName;
        private System.Windows.Forms.ColumnHeader Singer;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbFw;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbChong;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnfrmOrderBySongWordCount;
        private System.Windows.Forms.PictureBox pbYIDian;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbNextSong;
        private System.Windows.Forms.PictureBox pbRelSong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}