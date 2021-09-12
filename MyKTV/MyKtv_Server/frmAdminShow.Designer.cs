namespace MyKtv_Server
{
    partial class frmAdminShow
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdminTypeName = new System.Windows.Forms.TextBox();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.lblAdminPwd = new System.Windows.Forms.Label();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.btnClearAdmin = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.cmsDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.cmsDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdminTypeName);
            this.groupBox2.Controls.Add(this.lblAdminName);
            this.groupBox2.Controls.Add(this.txtTypeID);
            this.groupBox2.Controls.Add(this.lblAdminPwd);
            this.groupBox2.Controls.Add(this.btnUpdateAdmin);
            this.groupBox2.Controls.Add(this.btnDeleteAdmin);
            this.groupBox2.Controls.Add(this.btnClearAdmin);
            this.groupBox2.Controls.Add(this.btnAddAdmin);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(9, 250);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(598, 141);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "管理员信息管理";
            // 
            // txtAdminTypeName
            // 
            this.txtAdminTypeName.Location = new System.Drawing.Point(434, 36);
            this.txtAdminTypeName.Name = "txtAdminTypeName";
            this.txtAdminTypeName.PasswordChar = '•';
            this.txtAdminTypeName.Size = new System.Drawing.Size(139, 26);
            this.txtAdminTypeName.TabIndex = 1;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(342, 39);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(82, 20);
            this.lblAdminName.TabIndex = 12;
            this.lblAdminName.Text = "管理员密码:";
            // 
            // txtTypeID
            // 
            this.txtTypeID.Location = new System.Drawing.Point(114, 36);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(137, 26);
            this.txtTypeID.TabIndex = 0;
            // 
            // lblAdminPwd
            // 
            this.lblAdminPwd.AutoSize = true;
            this.lblAdminPwd.Location = new System.Drawing.Point(25, 39);
            this.lblAdminPwd.Name = "lblAdminPwd";
            this.lblAdminPwd.Size = new System.Drawing.Size(93, 20);
            this.lblAdminPwd.TabIndex = 10;
            this.lblAdminPwd.Text = "管理员名称：";
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.Location = new System.Drawing.Point(174, 87);
            this.btnUpdateAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(98, 33);
            this.btnUpdateAdmin.TabIndex = 3;
            this.btnUpdateAdmin.Text = "修改";
            this.btnUpdateAdmin.UseVisualStyleBackColor = true;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Location = new System.Drawing.Point(328, 87);
            this.btnDeleteAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(98, 33);
            this.btnDeleteAdmin.TabIndex = 4;
            this.btnDeleteAdmin.Text = "删除";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // btnClearAdmin
            // 
            this.btnClearAdmin.Location = new System.Drawing.Point(482, 87);
            this.btnClearAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAdmin.Name = "btnClearAdmin";
            this.btnClearAdmin.Size = new System.Drawing.Size(98, 33);
            this.btnClearAdmin.TabIndex = 5;
            this.btnClearAdmin.Text = "刷新";
            this.btnClearAdmin.UseVisualStyleBackColor = true;
            this.btnClearAdmin.Click += new System.EventHandler(this.btnClearAdmin_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(20, 87);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(98, 33);
            this.btnAddAdmin.TabIndex = 2;
            this.btnAddAdmin.Text = "添加";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvShow);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(598, 229);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管理员信息";
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
            this.AID,
            this.AName,
            this.APwd});
            this.dgvShow.ContextMenuStrip = this.cmsDelete;
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.Location = new System.Drawing.Point(2, 21);
            this.dgvShow.Margin = new System.Windows.Forms.Padding(2);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(594, 206);
            this.dgvShow.TabIndex = 0;
            this.dgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellContentClick);
            this.dgvShow.SelectionChanged += new System.EventHandler(this.dgvShow_SelectionChanged);
            // 
            // cmsDelete
            // 
            this.cmsDelete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiDelete.Text = "删除";
            // 
            // AID
            // 
            this.AID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AID.DataPropertyName = "AID";
            this.AID.FillWeight = 197.9695F;
            this.AID.HeaderText = "管理员编号";
            this.AID.MinimumWidth = 6;
            this.AID.Name = "AID";
            this.AID.ReadOnly = true;
            this.AID.Width = 250;
            // 
            // AName
            // 
            this.AName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AName.DataPropertyName = "AName";
            this.AName.FillWeight = 2.030457F;
            this.AName.HeaderText = "管理员名称";
            this.AName.MinimumWidth = 2;
            this.AName.Name = "AName";
            this.AName.ReadOnly = true;
            // 
            // APwd
            // 
            this.APwd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.APwd.DataPropertyName = "APwd";
            this.APwd.HeaderText = "管理员密码";
            this.APwd.MinimumWidth = 6;
            this.APwd.Name = "APwd";
            this.APwd.ReadOnly = true;
            this.APwd.Visible = false;
            // 
            // frmAdminShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdminShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员信息管理";
            this.Load += new System.EventHandler(this.frmAdminShow_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.cmsDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAdminTypeName;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.Label lblAdminPwd;
        private System.Windows.Forms.Button btnUpdateAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Button btnClearAdmin;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.ContextMenuStrip cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn AID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AName;
        private System.Windows.Forms.DataGridViewTextBoxColumn APwd;
    }
}