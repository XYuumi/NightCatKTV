using MyKtv_Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MyKtv_Server
{
    public partial class frmSingerType : Form
    {
        public frmSingerType()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开窗体的加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSingerType_Load(object sender, EventArgs e)
        {
            //加载数据到dgv中，调用加载方法
            ShowSingerType();
        }


        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSingerType();//调用添加方法
            ShowSingerType();//调用刷新方法
        }

        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSingerType();//调用修改方法
            ShowSingerType();//调用刷新方法
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSingerType();//调用删除方法
            ShowSingerType();//调用刷新方法
        }

        /// <summary>
        /// 右键删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            //判断选中行数是否大于0
            if (this.dgvSingerType.SelectedRows.Count > 0)
            {
                //执行sql语句，删除
                string sqlStr = "delete from SingerType where SingerTypeID={0}";
                //获取选中数据ID值
                sqlStr = string.Format(sqlStr, this.dgvSingerType.SelectedRows[0].Cells["SingerTypeID"].Value.ToString());
                DeleteSingerType();
            }
            ShowSingerType();//刷新
        }

        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSx_Click(object sender, EventArgs e)
        {
            ShowSingerType();
        }
        //------------------以下为所用方法
        /// <summary>
        /// 加载数据
        /// </summary>
        private void ShowSingerType()
        {
            //执行sql语句，显示数据
            string sqlStr = "select SingerTypeID,SingerTypeName from SingerType";
            //调用DBHelper并将结果放入dgv中
            this.dgvSingerType.DataSource = DBHelper.getTable(sqlStr);
            ResAndClear();//调用清空文本框方法
        }

        /// <summary>
        /// 添加数据方法
        /// </summary>
        private void AddSingerType()
        {
            //执行sql语句添加歌手类型
            string sqlStr = "insert into SingerType values('{0}')";
            sqlStr = string.Format(sqlStr, this.txtSingerTypeName.Text);
            //调用DBHelper并将结果以整数形式存入result中
            int result = DBHelper.getNonQuery(sqlStr);
            //判断结果并反馈
            if (result > 0)
            {
                MessageBox.Show("操作成功！", "提示");
            }
            else
            {
                MessageBox.Show("操作失败！", "提示");
            }
        }

        /// <summary>
        /// 修改数据方法
        /// </summary>
        private void UpdateSingerType()
        {
            string sqlStr = "update SingerType set SingerTypeName='{0}'where SingerTypeID='{1}'";
            sqlStr = string.Format(sqlStr, this.txtSingerTypeName.Text, this.txtTypeID.Text);
            int result = DBHelper.getNonQuery(sqlStr);
            if (result > 0)
            {
                MessageBox.Show("操作成功！", "提示");
            }
            else
            {
                MessageBox.Show("操作失败！", "提示");
            }
        }

        /// <summary>
        /// 删除数据方法
        /// </summary>
        private void DeleteSingerType()
        {
            string sqlStr = "delete from SingerType where SingerTypeID='{0}'";
            sqlStr = string.Format(sqlStr, this.txtTypeID.Text);
            int result = DBHelper.getNonQuery(sqlStr);
            if (result > 0)
            {
                MessageBox.Show("操作成功！", "提示");
            }
            else
            {
                MessageBox.Show("操作失败！", "提示");
            }
        }

        /// <summary>
        /// 清空文本框
        /// </summary>
        private void ResAndClear()
        {
            this.txtTypeID.Text = "";
            this.txtSingerTypeName.Text = "";
        }

        /// <summary>
        /// 点击选中事件
        /// 将选中数据加载进文本框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSingerType_SelectionChanged(object sender, EventArgs e)
        {
            //判断选中行数是否大于0
            if (this.dgvSingerType.SelectedRows.Count > 0)
            {
                //将dgv中选中数据值以文本形式存入id中
                string id = this.dgvSingerType.SelectedRows[0].Cells["SingerTypeID"].Value.ToString();
                //将dgv中选中数据值以文本形式存入类型名中
                string typeName = this.dgvSingerType.SelectedRows[0].Cells["SingerTypeName"].Value.ToString();
                //将数据写入文本框中
                this.txtTypeID.Text = id;
                this.txtSingerTypeName.Text = typeName;
            }
        }

        private void dgvSingerType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTypeID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
