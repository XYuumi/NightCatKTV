using MyKtv_Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyKtv_Server
{
    public partial class frmAdminShow : Form
    {
        public frmAdminShow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdminShow_Load(object sender, EventArgs e)
        {
            ShowAdmin();//刷新dgv显示数据
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            AddAdmin();//调用添加方法
            ShowAdmin();//刷新dgv方法
            ResAndClear();//刷新文本框
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            DeleteAdmin();//调用删除方法
            ShowAdmin();//刷新dgv
            ResAndClear();//刷新文本框
        }

        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            UpdateAdmin();//调用删除方法
            ShowAdmin();//刷新dgv
            ResAndClear();//刷新文本框
        }

        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAdmin_Click(object sender, EventArgs e)
        {
            ShowAdmin();//刷新dgv
            ResAndClear();//刷新文本框
        }

        /// <summary>
        /// 绑定下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvShow_SelectionChanged(object sender, EventArgs e)
        {
            //判断选中行数
            if (this.dgvShow.SelectedRows.Count > 0)
            {
                //将选中行数据转换为文本形式显示在文本框中
                this.txtTypeID.Text = this.dgvShow.SelectedRows[0].Cells["AName"].Value.ToString();
                this.txtAdminTypeName.Text = this.dgvShow.SelectedRows[0].Cells["APwd"].Value.ToString();
            }
        }

        //-----------------------------------------------------------以下为调用方法

        /// <summary>
        /// 删除数据方法
        /// </summary>
        private void DeleteAdmin()
        {
            //判断是否选中
            //if (this.dgvShow.SelectedRows.Count > 0)
            //{
                //将选中第0行数据以字符串类型存入变量
                string wdnmd = this.dgvShow.SelectedRows[0].Cells[0].Value.ToString();
                //执行删除sql语句
                string sqlStr = "delete from AdminInfo where AID='{0}'";
                sqlStr = string.Format(sqlStr, wdnmd);
                //判断根据影响行数返回结果
                int result = DBHelper.getNonQuery(sqlStr);
                if (result > 0)
                {
                    MessageBox.Show("操作成功！", "提示");
                }
                else
                {
                    MessageBox.Show("操作失败，您未选中数据！", "提示");
                }
            //}
        }

        /// <summary>
        /// 添加数据方法
        /// </summary>
        private void AddAdmin()
        {
            //执行添加sql语句
            string sqlStr = "insert into AdminInfo values('{0}','{1}')";
            sqlStr = string.Format(sqlStr, this.txtTypeID.Text, this.txtAdminTypeName.Text);
            //判断
            int result = DBHelper.getNonQuery(sqlStr);
            if (result > 0)
            {
                MessageBox.Show("操作成功！", "提示");
            }
            else
            {
                MessageBox.Show("操作成功！", "提示");
            }
        }

        /// <summary>
        /// 修改数据方法
        /// </summary>
        private void UpdateAdmin()
        {
            //将选中第0行数据以字符串类型存入变量
            string wdnmd = this.dgvShow.SelectedRows[0].Cells[0].Value.ToString();
            //执行修改语句sql
            string sqlStr = "update AdminInfo set AName = '{0}', APwd = '{1}' where AID = {2}";
            sqlStr = string.Format(sqlStr, this.txtTypeID.Text, this.txtAdminTypeName.Text, wdnmd);
            //判断
            int result = DBHelper.getNonQuery(sqlStr);
            if (result > 0)
            {
                MessageBox.Show("操作成功！", "提示");
            }
            else
            {
                MessageBox.Show("操作失败，您未选中数据！", "提示");
            }
        }

        /// <summary>
        /// 显示dgv方法
        /// </summary>
        private void ShowAdmin()
        {
            //执行sql查询语句
            string sqlStr = "select AID,AName,APwd from AdminInfo";
            //将结果显示在dgv中
            this.dgvShow.DataSource = DBHelper.getTable(sqlStr);
        }

        /// <summary>
        /// 清空文本框
        /// </summary>
        private void ResAndClear()
        {
            this.txtTypeID.Text = "";
            this.txtAdminTypeName.Text = "";
        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
