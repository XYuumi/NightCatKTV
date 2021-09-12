namespace MyKtv_Server
{
    partial class frmResource
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
            this.lblSingerPic = new System.Windows.Forms.Label();
            this.txtPicutre = new System.Windows.Forms.TextBox();
            this.lblposter = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtposter = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBaoCun = new System.Windows.Forms.Button();
            this.btnChong = new System.Windows.Forms.Button();
            this.fbdSingerPic = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSingerPic = new System.Windows.Forms.Button();
            this.btnSongPic = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.fbdSongPic = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdfile = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblSingerPic
            // 
            this.lblSingerPic.AutoSize = true;
            this.lblSingerPic.Location = new System.Drawing.Point(62, 38);
            this.lblSingerPic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSingerPic.Name = "lblSingerPic";
            this.lblSingerPic.Size = new System.Drawing.Size(113, 12);
            this.lblSingerPic.TabIndex = 0;
            this.lblSingerPic.Text = "歌手图片资源文件：";
            // 
            // txtPicutre
            // 
            this.txtPicutre.Location = new System.Drawing.Point(172, 35);
            this.txtPicutre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPicutre.Name = "txtPicutre";
            this.txtPicutre.Size = new System.Drawing.Size(186, 21);
            this.txtPicutre.TabIndex = 1;
            this.txtPicutre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblposter
            // 
            this.lblposter.AutoSize = true;
            this.lblposter.Location = new System.Drawing.Point(62, 82);
            this.lblposter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblposter.Name = "lblposter";
            this.lblposter.Size = new System.Drawing.Size(89, 12);
            this.lblposter.TabIndex = 2;
            this.lblposter.Text = "歌曲海报文件：";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(62, 127);
            this.lblFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(89, 12);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "歌曲文件资源：";
            // 
            // txtposter
            // 
            this.txtposter.Location = new System.Drawing.Point(170, 80);
            this.txtposter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtposter.Name = "txtposter";
            this.txtposter.Size = new System.Drawing.Size(186, 21);
            this.txtposter.TabIndex = 5;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(170, 125);
            this.txtFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(186, 21);
            this.txtFile.TabIndex = 6;
            // 
            // btnBaoCun
            // 
            this.btnBaoCun.Location = new System.Drawing.Point(119, 174);
            this.btnBaoCun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBaoCun.Name = "btnBaoCun";
            this.btnBaoCun.Size = new System.Drawing.Size(56, 23);
            this.btnBaoCun.TabIndex = 7;
            this.btnBaoCun.Text = "保存";
            this.btnBaoCun.UseVisualStyleBackColor = true;
            this.btnBaoCun.Click += new System.EventHandler(this.btnBaoCun_Click);
            // 
            // btnChong
            // 
            this.btnChong.Location = new System.Drawing.Point(268, 174);
            this.btnChong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChong.Name = "btnChong";
            this.btnChong.Size = new System.Drawing.Size(56, 23);
            this.btnChong.TabIndex = 8;
            this.btnChong.Text = "重置";
            this.btnChong.UseVisualStyleBackColor = true;
            this.btnChong.Click += new System.EventHandler(this.btnChong_Click);
            // 
            // btnSingerPic
            // 
            this.btnSingerPic.Location = new System.Drawing.Point(380, 38);
            this.btnSingerPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSingerPic.Name = "btnSingerPic";
            this.btnSingerPic.Size = new System.Drawing.Size(56, 18);
            this.btnSingerPic.TabIndex = 9;
            this.btnSingerPic.Text = "...";
            this.btnSingerPic.UseVisualStyleBackColor = true;
            this.btnSingerPic.Click += new System.EventHandler(this.btnSingerPic_Click);
            // 
            // btnSongPic
            // 
            this.btnSongPic.Location = new System.Drawing.Point(380, 79);
            this.btnSongPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSongPic.Name = "btnSongPic";
            this.btnSongPic.Size = new System.Drawing.Size(56, 18);
            this.btnSongPic.TabIndex = 10;
            this.btnSongPic.Text = "...";
            this.btnSongPic.UseVisualStyleBackColor = true;
            this.btnSongPic.Click += new System.EventHandler(this.btnSongPic_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(380, 124);
            this.btnFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(56, 18);
            this.btnFile.TabIndex = 11;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 225);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnSongPic);
            this.Controls.Add(this.btnSingerPic);
            this.Controls.Add(this.btnChong);
            this.Controls.Add(this.btnBaoCun);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtposter);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblposter);
            this.Controls.Add(this.txtPicutre);
            this.Controls.Add(this.lblSingerPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyKtv-资源项目管理";
            this.Load += new System.EventHandler(this.frmResource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSingerPic;
        private System.Windows.Forms.TextBox txtPicutre;
        private System.Windows.Forms.Label lblposter;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtposter;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnBaoCun;
        private System.Windows.Forms.Button btnChong;
        private System.Windows.Forms.FolderBrowserDialog fbdSingerPic;
        private System.Windows.Forms.Button btnSingerPic;
        private System.Windows.Forms.Button btnSongPic;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.FolderBrowserDialog fbdSongPic;
        private System.Windows.Forms.FolderBrowserDialog fbdfile;
    }
}