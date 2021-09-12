namespace MyKtv_Server
{
    partial class frmSingerType
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
            this.dgvSingerType = new System.Windows.Forms.DataGridView();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSx = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSingerTypeName = new System.Windows.Forms.TextBox();
            this.lblSingerTypeName = new System.Windows.Forms.Label();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.SingerTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingerType)).BeginInit();
            this.cmsMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSingerType);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(650, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "歌手类型";
            // 
            // dgvSingerType
            // 
            this.dgvSingerType.AllowUserToAddRows = false;
            this.dgvSingerType.AllowUserToDeleteRows = false;
            this.dgvSingerType.AllowUserToResizeColumns = false;
            this.dgvSingerType.AllowUserToResizeRows = false;
            this.dgvSingerType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSingerType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSingerType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSingerType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SingerTypeID,
            this.SingerTypeName});
            this.dgvSingerType.ContextMenuStrip = this.cmsMain;
            this.dgvSingerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSingerType.Location = new System.Drawing.Point(2, 21);
            this.dgvSingerType.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSingerType.MultiSelect = false;
            this.dgvSingerType.Name = "dgvSingerType";
            this.dgvSingerType.ReadOnly = true;
            this.dgvSingerType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSingerType.RowHeadersVisible = false;
            this.dgvSingerType.RowHeadersWidth = 51;
            this.dgvSingerType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSingerType.RowTemplate.Height = 27;
            this.dgvSingerType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSingerType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSingerType.Size = new System.Drawing.Size(646, 210);
            this.dgvSingerType.TabIndex = 0;
            this.dgvSingerType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSingerType_CellContentClick);
            this.dgvSingerType.SelectionChanged += new System.EventHandler(this.dgvSingerType_SelectionChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSx);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtSingerTypeName);
            this.groupBox2.Controls.Add(this.lblSingerTypeName);
            this.groupBox2.Controls.Add(this.txtTypeID);
            this.groupBox2.Controls.Add(this.lblTypeID);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(11, 258);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(650, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "歌手类型管理";
            // 
            // btnSx
            // 
            this.btnSx.Location = new System.Drawing.Point(531, 95);
            this.btnSx.Name = "btnSx";
            this.btnSx.Size = new System.Drawing.Size(75, 31);
            this.btnSx.TabIndex = 5;
            this.btnSx.Text = "刷新";
            this.btnSx.UseVisualStyleBackColor = true;
            this.btnSx.Click += new System.EventHandler(this.btnSx_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(191, 95);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSingerTypeName
            // 
            this.txtSingerTypeName.Location = new System.Drawing.Point(461, 34);
            this.txtSingerTypeName.Name = "txtSingerTypeName";
            this.txtSingerTypeName.Size = new System.Drawing.Size(147, 26);
            this.txtSingerTypeName.TabIndex = 1;
            // 
            // lblSingerTypeName
            // 
            this.lblSingerTypeName.AutoSize = true;
            this.lblSingerTypeName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSingerTypeName.Location = new System.Drawing.Point(365, 36);
            this.lblSingerTypeName.Name = "lblSingerTypeName";
            this.lblSingerTypeName.Size = new System.Drawing.Size(90, 21);
            this.lblSingerTypeName.TabIndex = 8;
            this.lblSingerTypeName.Text = "类型名称：";
            // 
            // txtTypeID
            // 
            this.txtTypeID.Enabled = false;
            this.txtTypeID.Location = new System.Drawing.Point(113, 33);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(151, 26);
            this.txtTypeID.TabIndex = 0;
            this.txtTypeID.TextChanged += new System.EventHandler(this.txtTypeID_TextChanged);
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTypeID.Location = new System.Drawing.Point(17, 36);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(90, 21);
            this.lblTypeID.TabIndex = 6;
            this.lblTypeID.Text = "类型编号：";
            // 
            // SingerTypeID
            // 
            this.SingerTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SingerTypeID.DataPropertyName = "SingerTypeID";
            this.SingerTypeID.HeaderText = "歌手类型编号";
            this.SingerTypeID.MinimumWidth = 6;
            this.SingerTypeID.Name = "SingerTypeID";
            this.SingerTypeID.ReadOnly = true;
            this.SingerTypeID.Width = 250;
            // 
            // SingerTypeName
            // 
            this.SingerTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SingerTypeName.DataPropertyName = "SingerTypeName";
            this.SingerTypeName.HeaderText = "类型名称";
            this.SingerTypeName.MinimumWidth = 6;
            this.SingerTypeName.Name = "SingerTypeName";
            this.SingerTypeName.ReadOnly = true;
            // 
            // frmSingerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSingerType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV后台管理系统";
            this.Load += new System.EventHandler(this.frmSingerType_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingerType)).EndInit();
            this.cmsMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSingerType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSingerTypeName;
        private System.Windows.Forms.Label lblSingerTypeName;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.Label lblTypeID;
        private System.Windows.Forms.Button btnSx;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerTypeName;
    }
}