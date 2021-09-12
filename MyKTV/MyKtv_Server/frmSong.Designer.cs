namespace MyKTV_Server
{
    partial class frmSong
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
            this.grbSonginfo = new System.Windows.Forms.GroupBox();
            this.dgvSonginfo = new System.Windows.Forms.DataGridView();
            this.SongID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Songab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongWordCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSong = new System.Windows.Forms.GroupBox();
            this.btnLeixin = new System.Windows.Forms.Button();
            this.btnGeshou = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.cboGeQvLeiXing = new System.Windows.Forms.ComboBox();
            this.cboGeShouMing = new System.Windows.Forms.ComboBox();
            this.txtGeQvWanJian = new System.Windows.Forms.TextBox();
            this.txtPinYin = new System.Windows.Forms.TextBox();
            this.txtGeQvMing = new System.Windows.Forms.TextBox();
            this.lblGeQvWanJian = new System.Windows.Forms.Label();
            this.lblGeShouMing = new System.Windows.Forms.Label();
            this.lblPinYin = new System.Windows.Forms.Label();
            this.lblDianJiNv = new System.Windows.Forms.Label();
            this.btnQinKong = new System.Windows.Forms.Button();
            this.btnShanChu = new System.Windows.Forms.Button();
            this.btnXiuGai = new System.Windows.Forms.Button();
            this.btnTianJia = new System.Windows.Forms.Button();
            this.txtZiShu = new System.Windows.Forms.TextBox();
            this.txtGeQvID = new System.Windows.Forms.TextBox();
            this.txtDianJiNv = new System.Windows.Forms.TextBox();
            this.lblZiShu = new System.Windows.Forms.Label();
            this.lblGeQvID = new System.Windows.Forms.Label();
            this.lblGeQvLeiXing = new System.Windows.Forms.Label();
            this.lblGeQvMing = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.grbSonginfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonginfo)).BeginInit();
            this.grbSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSonginfo
            // 
            this.grbSonginfo.Controls.Add(this.dgvSonginfo);
            this.grbSonginfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grbSonginfo.Location = new System.Drawing.Point(13, 14);
            this.grbSonginfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSonginfo.Name = "grbSonginfo";
            this.grbSonginfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSonginfo.Size = new System.Drawing.Size(912, 329);
            this.grbSonginfo.TabIndex = 0;
            this.grbSonginfo.TabStop = false;
            this.grbSonginfo.Text = "歌曲信息";
            // 
            // dgvSonginfo
            // 
            this.dgvSonginfo.AllowUserToAddRows = false;
            this.dgvSonginfo.AllowUserToDeleteRows = false;
            this.dgvSonginfo.AllowUserToResizeColumns = false;
            this.dgvSonginfo.AllowUserToResizeRows = false;
            this.dgvSonginfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSonginfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvSonginfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonginfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongID,
            this.SongName,
            this.Songab,
            this.SongWordCount,
            this.SongTypeID,
            this.SingerName,
            this.SongTypeName,
            this.Url,
            this.ClientCount});
            this.dgvSonginfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSonginfo.Location = new System.Drawing.Point(3, 20);
            this.dgvSonginfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSonginfo.MultiSelect = false;
            this.dgvSonginfo.Name = "dgvSonginfo";
            this.dgvSonginfo.ReadOnly = true;
            this.dgvSonginfo.RowHeadersVisible = false;
            this.dgvSonginfo.RowTemplate.Height = 23;
            this.dgvSonginfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSonginfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSonginfo.Size = new System.Drawing.Size(906, 305);
            this.dgvSonginfo.TabIndex = 0;
            this.dgvSonginfo.SelectionChanged += new System.EventHandler(this.dgvSonginfo_SelectionChanged);
            // 
            // SongID
            // 
            this.SongID.DataPropertyName = "SongID";
            this.SongID.HeaderText = "歌曲编号";
            this.SongID.Name = "SongID";
            this.SongID.ReadOnly = true;
            // 
            // SongName
            // 
            this.SongName.DataPropertyName = "SongName";
            this.SongName.HeaderText = "歌曲名称";
            this.SongName.Name = "SongName";
            this.SongName.ReadOnly = true;
            // 
            // Songab
            // 
            this.Songab.DataPropertyName = "Songab";
            this.Songab.HeaderText = "拼音缩写";
            this.Songab.Name = "Songab";
            this.Songab.ReadOnly = true;
            // 
            // SongWordCount
            // 
            this.SongWordCount.DataPropertyName = "SongWordCount";
            this.SongWordCount.HeaderText = "字数";
            this.SongWordCount.Name = "SongWordCount";
            this.SongWordCount.ReadOnly = true;
            // 
            // SongTypeID
            // 
            this.SongTypeID.DataPropertyName = "SongTypeID";
            this.SongTypeID.HeaderText = "歌手编号";
            this.SongTypeID.Name = "SongTypeID";
            this.SongTypeID.ReadOnly = true;
            this.SongTypeID.Visible = false;
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "SingerName";
            this.SingerName.HeaderText = "歌手名称";
            this.SingerName.Name = "SingerName";
            this.SingerName.ReadOnly = true;
            // 
            // SongTypeName
            // 
            this.SongTypeName.DataPropertyName = "SongTypeName";
            this.SongTypeName.HeaderText = "类型名称";
            this.SongTypeName.Name = "SongTypeName";
            this.SongTypeName.ReadOnly = true;
            // 
            // Url
            // 
            this.Url.DataPropertyName = "Url";
            this.Url.HeaderText = "歌曲文件名";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            // 
            // ClientCount
            // 
            this.ClientCount.DataPropertyName = "ClientCount";
            this.ClientCount.HeaderText = "点击率";
            this.ClientCount.Name = "ClientCount";
            this.ClientCount.ReadOnly = true;
            // 
            // grbSong
            // 
            this.grbSong.Controls.Add(this.btnLeixin);
            this.grbSong.Controls.Add(this.btnGeshou);
            this.grbSong.Controls.Add(this.btn1);
            this.grbSong.Controls.Add(this.cboGeQvLeiXing);
            this.grbSong.Controls.Add(this.cboGeShouMing);
            this.grbSong.Controls.Add(this.txtGeQvWanJian);
            this.grbSong.Controls.Add(this.txtPinYin);
            this.grbSong.Controls.Add(this.txtGeQvMing);
            this.grbSong.Controls.Add(this.lblGeQvWanJian);
            this.grbSong.Controls.Add(this.lblGeShouMing);
            this.grbSong.Controls.Add(this.lblPinYin);
            this.grbSong.Controls.Add(this.lblDianJiNv);
            this.grbSong.Controls.Add(this.btnQinKong);
            this.grbSong.Controls.Add(this.btnShanChu);
            this.grbSong.Controls.Add(this.btnXiuGai);
            this.grbSong.Controls.Add(this.btnTianJia);
            this.grbSong.Controls.Add(this.txtZiShu);
            this.grbSong.Controls.Add(this.txtGeQvID);
            this.grbSong.Controls.Add(this.txtDianJiNv);
            this.grbSong.Controls.Add(this.lblZiShu);
            this.grbSong.Controls.Add(this.lblGeQvID);
            this.grbSong.Controls.Add(this.lblGeQvLeiXing);
            this.grbSong.Controls.Add(this.lblGeQvMing);
            this.grbSong.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grbSong.Location = new System.Drawing.Point(17, 351);
            this.grbSong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSong.Name = "grbSong";
            this.grbSong.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSong.Size = new System.Drawing.Size(908, 204);
            this.grbSong.TabIndex = 1;
            this.grbSong.TabStop = false;
            this.grbSong.Text = "歌曲管理";
            // 
            // btnLeixin
            // 
            this.btnLeixin.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLeixin.Location = new System.Drawing.Point(11, 162);
            this.btnLeixin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLeixin.Name = "btnLeixin";
            this.btnLeixin.Size = new System.Drawing.Size(110, 36);
            this.btnLeixin.TabIndex = 9;
            this.btnLeixin.Text = "添加类型";
            this.btnLeixin.UseVisualStyleBackColor = true;
            this.btnLeixin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGeshou
            // 
            this.btnGeshou.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGeshou.Location = new System.Drawing.Point(162, 162);
            this.btnGeshou.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGeshou.Name = "btnGeshou";
            this.btnGeshou.Size = new System.Drawing.Size(110, 36);
            this.btnGeshou.TabIndex = 10;
            this.btnGeshou.Text = "添加歌手";
            this.btnGeshou.UseVisualStyleBackColor = true;
            this.btnGeshou.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("宋体", 8F);
            this.btn1.Location = new System.Drawing.Point(811, 117);
            this.btn1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(37, 23);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "•••";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // cboGeQvLeiXing
            // 
            this.cboGeQvLeiXing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGeQvLeiXing.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboGeQvLeiXing.FormattingEnabled = true;
            this.cboGeQvLeiXing.Location = new System.Drawing.Point(414, 70);
            this.cboGeQvLeiXing.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboGeQvLeiXing.Name = "cboGeQvLeiXing";
            this.cboGeQvLeiXing.Size = new System.Drawing.Size(146, 25);
            this.cboGeQvLeiXing.TabIndex = 4;
            // 
            // cboGeShouMing
            // 
            this.cboGeShouMing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGeShouMing.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboGeShouMing.FormattingEnabled = true;
            this.cboGeShouMing.Location = new System.Drawing.Point(659, 70);
            this.cboGeShouMing.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboGeShouMing.Name = "cboGeShouMing";
            this.cboGeShouMing.Size = new System.Drawing.Size(146, 25);
            this.cboGeShouMing.TabIndex = 5;
            // 
            // txtGeQvWanJian
            // 
            this.txtGeQvWanJian.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGeQvWanJian.Location = new System.Drawing.Point(414, 117);
            this.txtGeQvWanJian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGeQvWanJian.Name = "txtGeQvWanJian";
            this.txtGeQvWanJian.ReadOnly = true;
            this.txtGeQvWanJian.Size = new System.Drawing.Size(379, 23);
            this.txtGeQvWanJian.TabIndex = 7;
            // 
            // txtPinYin
            // 
            this.txtPinYin.Font = new System.Drawing.Font("宋体", 9F);
            this.txtPinYin.Location = new System.Drawing.Point(143, 117);
            this.txtPinYin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPinYin.Name = "txtPinYin";
            this.txtPinYin.Size = new System.Drawing.Size(149, 21);
            this.txtPinYin.TabIndex = 6;
            // 
            // txtGeQvMing
            // 
            this.txtGeQvMing.Font = new System.Drawing.Font("宋体", 9F);
            this.txtGeQvMing.Location = new System.Drawing.Point(414, 27);
            this.txtGeQvMing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGeQvMing.Name = "txtGeQvMing";
            this.txtGeQvMing.Size = new System.Drawing.Size(149, 21);
            this.txtGeQvMing.TabIndex = 1;
            // 
            // lblGeQvWanJian
            // 
            this.lblGeQvWanJian.AutoSize = true;
            this.lblGeQvWanJian.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGeQvWanJian.Location = new System.Drawing.Point(325, 117);
            this.lblGeQvWanJian.Name = "lblGeQvWanJian";
            this.lblGeQvWanJian.Size = new System.Drawing.Size(74, 21);
            this.lblGeQvWanJian.TabIndex = 15;
            this.lblGeQvWanJian.Text = "歌曲文件";
            // 
            // lblGeShouMing
            // 
            this.lblGeShouMing.AutoSize = true;
            this.lblGeShouMing.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGeShouMing.Location = new System.Drawing.Point(580, 72);
            this.lblGeShouMing.Name = "lblGeShouMing";
            this.lblGeShouMing.Size = new System.Drawing.Size(74, 21);
            this.lblGeShouMing.TabIndex = 14;
            this.lblGeShouMing.Text = "歌手名称";
            // 
            // lblPinYin
            // 
            this.lblPinYin.AutoSize = true;
            this.lblPinYin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPinYin.Location = new System.Drawing.Point(63, 117);
            this.lblPinYin.Name = "lblPinYin";
            this.lblPinYin.Size = new System.Drawing.Size(74, 21);
            this.lblPinYin.TabIndex = 13;
            this.lblPinYin.Text = "歌曲拼音";
            // 
            // lblDianJiNv
            // 
            this.lblDianJiNv.AutoSize = true;
            this.lblDianJiNv.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDianJiNv.Location = new System.Drawing.Point(63, 72);
            this.lblDianJiNv.Name = "lblDianJiNv";
            this.lblDianJiNv.Size = new System.Drawing.Size(68, 21);
            this.lblDianJiNv.TabIndex = 12;
            this.lblDianJiNv.Text = "点 击 率";
            // 
            // btnQinKong
            // 
            this.btnQinKong.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQinKong.Location = new System.Drawing.Point(769, 162);
            this.btnQinKong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQinKong.Name = "btnQinKong";
            this.btnQinKong.Size = new System.Drawing.Size(113, 36);
            this.btnQinKong.TabIndex = 14;
            this.btnQinKong.Text = "清  空";
            this.btnQinKong.UseVisualStyleBackColor = true;
            this.btnQinKong.Click += new System.EventHandler(this.btnQinKong_Click);
            // 
            // btnShanChu
            // 
            this.btnShanChu.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShanChu.Location = new System.Drawing.Point(616, 162);
            this.btnShanChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShanChu.Name = "btnShanChu";
            this.btnShanChu.Size = new System.Drawing.Size(113, 36);
            this.btnShanChu.TabIndex = 13;
            this.btnShanChu.Text = "删  除";
            this.btnShanChu.UseVisualStyleBackColor = true;
            this.btnShanChu.Click += new System.EventHandler(this.btnShanChu_Click);
            // 
            // btnXiuGai
            // 
            this.btnXiuGai.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnXiuGai.Location = new System.Drawing.Point(463, 162);
            this.btnXiuGai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXiuGai.Name = "btnXiuGai";
            this.btnXiuGai.Size = new System.Drawing.Size(113, 36);
            this.btnXiuGai.TabIndex = 12;
            this.btnXiuGai.Text = "修  改";
            this.btnXiuGai.UseVisualStyleBackColor = true;
            this.btnXiuGai.Click += new System.EventHandler(this.btnXiuGai_Click);
            // 
            // btnTianJia
            // 
            this.btnTianJia.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTianJia.Location = new System.Drawing.Point(312, 162);
            this.btnTianJia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTianJia.Name = "btnTianJia";
            this.btnTianJia.Size = new System.Drawing.Size(110, 36);
            this.btnTianJia.TabIndex = 11;
            this.btnTianJia.Text = "添  加";
            this.btnTianJia.UseVisualStyleBackColor = true;
            this.btnTianJia.Click += new System.EventHandler(this.btnTianJia_Click);
            // 
            // txtZiShu
            // 
            this.txtZiShu.Font = new System.Drawing.Font("宋体", 9F);
            this.txtZiShu.Location = new System.Drawing.Point(659, 27);
            this.txtZiShu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtZiShu.Name = "txtZiShu";
            this.txtZiShu.Size = new System.Drawing.Size(146, 21);
            this.txtZiShu.TabIndex = 2;
            // 
            // txtGeQvID
            // 
            this.txtGeQvID.Enabled = false;
            this.txtGeQvID.Font = new System.Drawing.Font("宋体", 9F);
            this.txtGeQvID.Location = new System.Drawing.Point(143, 27);
            this.txtGeQvID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGeQvID.Name = "txtGeQvID";
            this.txtGeQvID.ReadOnly = true;
            this.txtGeQvID.Size = new System.Drawing.Size(149, 21);
            this.txtGeQvID.TabIndex = 0;
            // 
            // txtDianJiNv
            // 
            this.txtDianJiNv.Font = new System.Drawing.Font("宋体", 9F);
            this.txtDianJiNv.Location = new System.Drawing.Point(143, 72);
            this.txtDianJiNv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDianJiNv.Name = "txtDianJiNv";
            this.txtDianJiNv.Size = new System.Drawing.Size(149, 21);
            this.txtDianJiNv.TabIndex = 3;
            // 
            // lblZiShu
            // 
            this.lblZiShu.AutoSize = true;
            this.lblZiShu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblZiShu.Location = new System.Drawing.Point(580, 27);
            this.lblZiShu.Name = "lblZiShu";
            this.lblZiShu.Size = new System.Drawing.Size(74, 21);
            this.lblZiShu.TabIndex = 3;
            this.lblZiShu.Text = "歌曲字数";
            // 
            // lblGeQvID
            // 
            this.lblGeQvID.AutoSize = true;
            this.lblGeQvID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGeQvID.Location = new System.Drawing.Point(63, 27);
            this.lblGeQvID.Name = "lblGeQvID";
            this.lblGeQvID.Size = new System.Drawing.Size(74, 21);
            this.lblGeQvID.TabIndex = 2;
            this.lblGeQvID.Text = "歌曲编号";
            // 
            // lblGeQvLeiXing
            // 
            this.lblGeQvLeiXing.AutoSize = true;
            this.lblGeQvLeiXing.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGeQvLeiXing.Location = new System.Drawing.Point(323, 72);
            this.lblGeQvLeiXing.Name = "lblGeQvLeiXing";
            this.lblGeQvLeiXing.Size = new System.Drawing.Size(74, 21);
            this.lblGeQvLeiXing.TabIndex = 1;
            this.lblGeQvLeiXing.Text = "歌曲类型";
            // 
            // lblGeQvMing
            // 
            this.lblGeQvMing.AutoSize = true;
            this.lblGeQvMing.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGeQvMing.Location = new System.Drawing.Point(323, 27);
            this.lblGeQvMing.Name = "lblGeQvMing";
            this.lblGeQvMing.Size = new System.Drawing.Size(74, 21);
            this.lblGeQvMing.TabIndex = 0;
            this.lblGeQvMing.Text = "歌曲名称";
            // 
            // ofd1
            // 
            this.ofd1.Filter = "mp4文件|*.mp4|mp3文件|*.mp3|所有文件|*.*";
            // 
            // frmSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 568);
            this.Controls.Add(this.grbSong);
            this.Controls.Add(this.grbSonginfo);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV点歌系统——歌曲管理";
            this.Load += new System.EventHandler(this.frmSong_Load);
            this.grbSonginfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonginfo)).EndInit();
            this.grbSong.ResumeLayout(false);
            this.grbSong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSonginfo;
        private System.Windows.Forms.DataGridView dgvSonginfo;
        private System.Windows.Forms.GroupBox grbSong;
        private System.Windows.Forms.Button btnQinKong;
        private System.Windows.Forms.Button btnShanChu;
        private System.Windows.Forms.Button btnXiuGai;
        private System.Windows.Forms.Button btnTianJia;
        private System.Windows.Forms.TextBox txtZiShu;
        private System.Windows.Forms.TextBox txtGeQvID;
        private System.Windows.Forms.TextBox txtDianJiNv;
        private System.Windows.Forms.Label lblZiShu;
        private System.Windows.Forms.Label lblGeQvLeiXing;
        private System.Windows.Forms.Label lblGeQvMing;
        private System.Windows.Forms.Label lblGeQvID;
        private System.Windows.Forms.TextBox txtGeQvWanJian;
        private System.Windows.Forms.TextBox txtPinYin;
        private System.Windows.Forms.TextBox txtGeQvMing;
        private System.Windows.Forms.Label lblGeQvWanJian;
        private System.Windows.Forms.Label lblGeShouMing;
        private System.Windows.Forms.Label lblPinYin;
        private System.Windows.Forms.Label lblDianJiNv;
        private System.Windows.Forms.ComboBox cboGeQvLeiXing;
        private System.Windows.Forms.ComboBox cboGeShouMing;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btnLeixin;
        private System.Windows.Forms.Button btnGeshou;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Songab;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongWordCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCount;
    }
}