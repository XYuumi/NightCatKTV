using System;
using System.ComponentModel;

namespace MyKTV_Server
{
    partial class frmSongType
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
            this.gbo2 = new System.Windows.Forms.GroupBox();
            this.btnTuiChu = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShuaXin = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSongType = new System.Windows.Forms.TextBox();
            this.lblSongType = new System.Windows.Forms.Label();
            this.txtSongTypeID = new System.Windows.Forms.TextBox();
            this.lblSongTypeID = new System.Windows.Forms.Label();
            this.btnAdde = new System.Windows.Forms.Button();
            this.gbo1 = new System.Windows.Forms.GroupBox();
            this.dgvSongTypeinfo = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SongTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbo2.SuspendLayout();
            this.gbo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongTypeinfo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbo2
            // 
            this.gbo2.Controls.Add(this.btnTuiChu);
            this.gbo2.Controls.Add(this.btnDelete);
            this.gbo2.Controls.Add(this.btnShuaXin);
            this.gbo2.Controls.Add(this.btnUpdate);
            this.gbo2.Controls.Add(this.txtSongType);
            this.gbo2.Controls.Add(this.lblSongType);
            this.gbo2.Controls.Add(this.txtSongTypeID);
            this.gbo2.Controls.Add(this.lblSongTypeID);
            this.gbo2.Controls.Add(this.btnAdde);
            this.gbo2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbo2.Location = new System.Drawing.Point(9, 332);
            this.gbo2.Margin = new System.Windows.Forms.Padding(2);
            this.gbo2.Name = "gbo2";
            this.gbo2.Padding = new System.Windows.Forms.Padding(2);
            this.gbo2.Size = new System.Drawing.Size(646, 143);
            this.gbo2.TabIndex = 3;
            this.gbo2.TabStop = false;
            this.gbo2.Text = "歌曲类型管理";
            // 
            // btnTuiChu
            // 
            this.btnTuiChu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTuiChu.Location = new System.Drawing.Point(21, 98);
            this.btnTuiChu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTuiChu.Name = "btnTuiChu";
            this.btnTuiChu.Size = new System.Drawing.Size(74, 29);
            this.btnTuiChu.TabIndex = 2;
            this.btnTuiChu.Text = "返回";
            this.btnTuiChu.UseVisualStyleBackColor = true;
            this.btnTuiChu.Click += new System.EventHandler(this.btnTuiChu_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(408, 98);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShuaXin
            // 
            this.btnShuaXin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShuaXin.Location = new System.Drawing.Point(537, 98);
            this.btnShuaXin.Margin = new System.Windows.Forms.Padding(2);
            this.btnShuaXin.Name = "btnShuaXin";
            this.btnShuaXin.Size = new System.Drawing.Size(74, 29);
            this.btnShuaXin.TabIndex = 5;
            this.btnShuaXin.Text = "刷新";
            this.btnShuaXin.UseVisualStyleBackColor = true;
            this.btnShuaXin.Click += new System.EventHandler(this.btnShuaXin_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(279, 98);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 29);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSongType
            // 
            this.txtSongType.Location = new System.Drawing.Point(428, 46);
            this.txtSongType.Margin = new System.Windows.Forms.Padding(2);
            this.txtSongType.Name = "txtSongType";
            this.txtSongType.Size = new System.Drawing.Size(186, 26);
            this.txtSongType.TabIndex = 1;
            // 
            // lblSongType
            // 
            this.lblSongType.AutoSize = true;
            this.lblSongType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSongType.Location = new System.Drawing.Point(334, 48);
            this.lblSongType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSongType.Name = "lblSongType";
            this.lblSongType.Size = new System.Drawing.Size(90, 21);
            this.lblSongType.TabIndex = 3;
            this.lblSongType.Text = "类型名称：";
            // 
            // txtSongTypeID
            // 
            this.txtSongTypeID.Enabled = false;
            this.txtSongTypeID.Location = new System.Drawing.Point(118, 46);
            this.txtSongTypeID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSongTypeID.Name = "txtSongTypeID";
            this.txtSongTypeID.Size = new System.Drawing.Size(186, 26);
            this.txtSongTypeID.TabIndex = 0;
            this.txtSongTypeID.TextChanged += new System.EventHandler(this.txtSongTypeID_TextChanged);
            // 
            // lblSongTypeID
            // 
            this.lblSongTypeID.AutoSize = true;
            this.lblSongTypeID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSongTypeID.Location = new System.Drawing.Point(28, 48);
            this.lblSongTypeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSongTypeID.Name = "lblSongTypeID";
            this.lblSongTypeID.Size = new System.Drawing.Size(90, 21);
            this.lblSongTypeID.TabIndex = 1;
            this.lblSongTypeID.Text = "类型编号：";
            // 
            // btnAdde
            // 
            this.btnAdde.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdde.Location = new System.Drawing.Point(150, 98);
            this.btnAdde.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdde.Name = "btnAdde";
            this.btnAdde.Size = new System.Drawing.Size(74, 29);
            this.btnAdde.TabIndex = 3;
            this.btnAdde.Text = "添加";
            this.btnAdde.UseVisualStyleBackColor = true;
            this.btnAdde.Click += new System.EventHandler(this.btnAdde_Click);
            // 
            // gbo1
            // 
            this.gbo1.Controls.Add(this.dgvSongTypeinfo);
            this.gbo1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbo1.Location = new System.Drawing.Point(9, 10);
            this.gbo1.Margin = new System.Windows.Forms.Padding(2);
            this.gbo1.Name = "gbo1";
            this.gbo1.Padding = new System.Windows.Forms.Padding(2);
            this.gbo1.Size = new System.Drawing.Size(646, 318);
            this.gbo1.TabIndex = 2;
            this.gbo1.TabStop = false;
            this.gbo1.Text = "歌曲类型信息";
            // 
            // dgvSongTypeinfo
            // 
            this.dgvSongTypeinfo.AllowUserToAddRows = false;
            this.dgvSongTypeinfo.AllowUserToDeleteRows = false;
            this.dgvSongTypeinfo.AllowUserToResizeColumns = false;
            this.dgvSongTypeinfo.AllowUserToResizeRows = false;
            this.dgvSongTypeinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongTypeinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSongTypeinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongTypeinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongTypeID,
            this.SongTypeName});
            this.dgvSongTypeinfo.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSongTypeinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSongTypeinfo.Location = new System.Drawing.Point(2, 21);
            this.dgvSongTypeinfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSongTypeinfo.MultiSelect = false;
            this.dgvSongTypeinfo.Name = "dgvSongTypeinfo";
            this.dgvSongTypeinfo.ReadOnly = true;
            this.dgvSongTypeinfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSongTypeinfo.RowHeadersVisible = false;
            this.dgvSongTypeinfo.RowTemplate.Height = 27;
            this.dgvSongTypeinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSongTypeinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongTypeinfo.Size = new System.Drawing.Size(642, 295);
            this.dgvSongTypeinfo.TabIndex = 0;
            this.dgvSongTypeinfo.SelectionChanged += new System.EventHandler(this.dgvSongTypeinfo_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // SongTypeID
            // 
            this.SongTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SongTypeID.DataPropertyName = "SongTypeID";
            this.SongTypeID.HeaderText = "类型编号";
            this.SongTypeID.Name = "SongTypeID";
            this.SongTypeID.ReadOnly = true;
            this.SongTypeID.Width = 250;
            // 
            // SongTypeName
            // 
            this.SongTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SongTypeName.DataPropertyName = "SongTypeName";
            this.SongTypeName.HeaderText = "类型名称";
            this.SongTypeName.Name = "SongTypeName";
            this.SongTypeName.ReadOnly = true;
            // 
            // frmSongType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 486);
            this.Controls.Add(this.gbo2);
            this.Controls.Add(this.gbo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSongType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV点歌系统——歌曲类型管理";
            this.Load += new System.EventHandler(this.frmSongType_Load);
            this.gbo2.ResumeLayout(false);
            this.gbo2.PerformLayout();
            this.gbo1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongTypeinfo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbo2;
        private System.Windows.Forms.Button btnTuiChu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShuaXin;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSongType;
        private System.Windows.Forms.Label lblSongType;
        private System.Windows.Forms.TextBox txtSongTypeID;
        private System.Windows.Forms.Label lblSongTypeID;
        private System.Windows.Forms.Button btnAdde;
        private System.Windows.Forms.GroupBox gbo1;
        private System.Windows.Forms.DataGridView dgvSongTypeinfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTypeName;
    }
}