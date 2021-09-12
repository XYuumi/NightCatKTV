using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MyKtv_Tool;

namespace MyKtv_Server
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sqlStr = "select * from AdminInfo where AName = '" + this.txtName.Text + "'and APwd='" + this.txtPwd.Text + "'";

            if (DBHelper.getScalar(sqlStr) != null)
            {
                //登陆成功
                this.Hide();
                frmMain fm = new frmMain();
                //将当前用户名放入状态栏中
                fm.tsslLoginName.Text = this.txtName.Text + ",欢迎登录";
                fm.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("登录失败！");
                //清空密码框
                this.txtPwd.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定关闭KTV点歌后台管理系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 1)
            {
                timer1.Enabled = false;//关闭计时器
            }
            else
            {
                //每次增加5%不透明度
                this.Opacity += 0.05;
            }
        }
    }
}
