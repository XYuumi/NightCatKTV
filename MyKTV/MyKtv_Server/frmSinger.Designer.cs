namespace MyKtv_Server
{
    partial class frmSinger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSingerType = new System.Windows.Forms.Button();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.btnYl = new System.Windows.Forms.Button();
            this.pbSinger = new System.Windows.Forms.PictureBox();
            this.btnSx = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.txtSingerID = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSingerName = new System.Windows.Forms.Label();
            this.lblSingerType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSingerID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.SingerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdPic = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSinger)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSingerType);
            this.groupBox1.Controls.Add(this.txtPhoto);
            this.groupBox1.Controls.Add(this.btnYl);
            this.groupBox1.Controls.Add(this.pbSinger);
            this.groupBox1.Controls.Add(this.btnSx);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.txtSingerName);
            this.groupBox1.Controls.Add(this.txtSingerID);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblSingerName);
            this.groupBox1.Controls.Add(this.lblSingerType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSingerID);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "歌手管理";
            // 
            // btnSingerType
            // 
            this.btnSingerType.Location = new System.Drawing.Point(26, 269);
            this.btnSingerType.Margin = new System.Windows.Forms.Padding(2);
            this.btnSingerType.Name = "btnSingerType";
            this.btnSingerType.Size = new System.Drawing.Size(198, 50);
            this.btnSingerType.TabIndex = 8;
            this.btnSingerType.Text = "添加歌手类型";
            this.btnSingerType.UseVisualStyleBackColor = true;
            this.btnSingerType.Click += new System.EventHandler(this.btnSingerType_Click);
            // 
            // txtPhoto
            // 
            this.txtPhoto.Enabled = false;
            this.txtPhoto.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhoto.Location = new System.Drawing.Point(554, 269);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(194, 23);
            this.txtPhoto.TabIndex = 15;
            this.txtPhoto.TabStop = false;
            this.txtPhoto.TextChanged += new System.EventHandler(this.txtPhoto_TextChanged);
            // 
            // btnYl
            // 
            this.btnYl.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnYl.Location = new System.Drawing.Point(554, 298);
            this.btnYl.Name = "btnYl";
            this.btnYl.Size = new System.Drawing.Size(197, 23);
            this.btnYl.TabIndex = 9;
            this.btnYl.Text = "游览";
            this.btnYl.UseVisualStyleBackColor = true;
            this.btnYl.Click += new System.EventHandler(this.btnYl_Click);
            // 
            // pbSinger
            // 
            this.pbSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSinger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSinger.Location = new System.Drawing.Point(529, 8);
            this.pbSinger.Name = "pbSinger";
            this.pbSinger.Size = new System.Drawing.Size(239, 255);
            this.pbSinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSinger.TabIndex = 13;
            this.pbSinger.TabStop = false;
            // 
            // btnSx
            // 
            this.btnSx.Location = new System.Drawing.Point(424, 207);
            this.btnSx.Name = "btnSx";
            this.btnSx.Size = new System.Drawing.Size(78, 33);
            this.btnSx.TabIndex = 7;
            this.btnSx.Text = "刷新";
            this.btnSx.UseVisualStyleBackColor = true;
            this.btnSx.Click += new System.EventHandler(this.btnSx_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(292, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 33);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(152, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "男",
            "女",
            "组合"});
            this.cboGender.Location = new System.Drawing.Point(363, 117);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(133, 25);
            this.cboGender.TabIndex = 3;
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(91, 117);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(133, 25);
            this.cboType.TabIndex = 2;
            // 
            // txtSingerName
            // 
            this.txtSingerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSingerName.Location = new System.Drawing.Point(363, 55);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(133, 23);
            this.txtSingerName.TabIndex = 1;
            // 
            // txtSingerID
            // 
            this.txtSingerID.Enabled = false;
            this.txtSingerID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSingerID.Location = new System.Drawing.Point(91, 55);
            this.txtSingerID.Name = "txtSingerID";
            this.txtSingerID.Size = new System.Drawing.Size(133, 23);
            this.txtSingerID.TabIndex = 0;
            this.txtSingerID.TextChanged += new System.EventHandler(this.txtSingerID_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGender.Location = new System.Drawing.Point(278, 119);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(90, 21);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "歌手性别：";
            // 
            // lblSingerName
            // 
            this.lblSingerName.AutoSize = true;
            this.lblSingerName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSingerName.Location = new System.Drawing.Point(278, 56);
            this.lblSingerName.Name = "lblSingerName";
            this.lblSingerName.Size = new System.Drawing.Size(90, 21);
            this.lblSingerName.TabIndex = 3;
            this.lblSingerName.Text = "歌手名称：";
            // 
            // lblSingerType
            // 
            this.lblSingerType.AutoSize = true;
            this.lblSingerType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSingerType.Location = new System.Drawing.Point(6, 119);
            this.lblSingerType.Name = "lblSingerType";
            this.lblSingerType.Size = new System.Drawing.Size(90, 21);
            this.lblSingerType.TabIndex = 2;
            this.lblSingerType.Text = "歌手类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // lblSingerID
            // 
            this.lblSingerID.AutoSize = true;
            this.lblSingerID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSingerID.Location = new System.Drawing.Point(6, 56);
            this.lblSingerID.Name = "lblSingerID";
            this.lblSingerID.Size = new System.Drawing.Size(90, 21);
            this.lblSingerID.TabIndex = 0;
            this.lblSingerID.Text = "歌手编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvShow);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "歌手信息";
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AllowUserToResizeColumns = false;
            this.dgvShow.AllowUserToResizeRows = false;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SingerID,
            this.SingerName,
            this.SingerTypeID,
            this.SingerTypeName,
            this.Gender,
            this.Photo});
            this.dgvShow.ContextMenuStrip = this.cmsMain;
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.Location = new System.Drawing.Point(3, 22);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(768, 206);
            this.dgvShow.TabIndex = 0;
            this.dgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellContentClick);
            this.dgvShow.SelectionChanged += new System.EventHandler(this.dgvShow_SelectionChanged);
            // 
            // SingerID
            // 
            this.SingerID.DataPropertyName = "SingerID";
            this.SingerID.HeaderText = "歌手编号";
            this.SingerID.MinimumWidth = 6;
            this.SingerID.Name = "SingerID";
            this.SingerID.ReadOnly = true;
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "SingerName";
            this.SingerName.HeaderText = "歌手名称";
            this.SingerName.MinimumWidth = 6;
            this.SingerName.Name = "SingerName";
            this.SingerName.ReadOnly = true;
            // 
            // SingerTypeID
            // 
            this.SingerTypeID.DataPropertyName = "SingerTypeID";
            this.SingerTypeID.HeaderText = "歌手类型编号";
            this.SingerTypeID.MinimumWidth = 6;
            this.SingerTypeID.Name = "SingerTypeID";
            this.SingerTypeID.ReadOnly = true;
            this.SingerTypeID.Visible = false;
            // 
            // SingerTypeName
            // 
            this.SingerTypeName.DataPropertyName = "SingerTypeName";
            this.SingerTypeName.HeaderText = "歌手类型";
            this.SingerTypeName.MinimumWidth = 6;
            this.SingerTypeName.Name = "SingerTypeName";
            this.SingerTypeName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "歌手性别";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Photo
            // 
            this.Photo.DataPropertyName = "Photo";
            this.Photo.HeaderText = "照片文件名";
            this.Photo.MinimumWidth = 6;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            // 
            // cmsMain
            // 
            this.cmsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // ofdPic
            // 
            this.ofdPic.FileName = "openFileDialog1";
            this.ofdPic.Filter = "JPG文件|*.jpg|PNG文件|*.png|所有文件|*.*";
            // 
            // frmSinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 585);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSinger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV后台管理系统-歌手管理";
            this.Load += new System.EventHandler(this.frmSinger_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSinger)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSx;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.TextBox txtSingerID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSingerName;
        private System.Windows.Forms.Label lblSingerType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSingerID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.PictureBox pbSinger;
        private System.Windows.Forms.Button btnYl;
        private System.Windows.Forms.OpenFileDialog ofdPic;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.Button btnSingerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photo;
    }
}