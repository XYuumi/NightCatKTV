using MyKTV_Server;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            //弹出对话框
            DialogResult dr = MessageBox.Show("确定关闭KTV点歌后台管理系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            //判断
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 资源项目管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiResource_Click(object sender, EventArgs e)
        {           
            //mdi方式打开子窗体
            frmResource fm = new frmResource();
            fm.MdiParent = this;
            fm.Show();
        }

        /// <summary>
        /// 歌手管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSingerAdmin_Click(object sender, EventArgs e)
        {
            //mdi方式打开子窗体
            frmSinger fm = new frmSinger();
            fm.MdiParent = this;
            fm.Show();
        }

        /// <summary>
        /// 歌手类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSingerType_Click(object sender, EventArgs e)
        {
            //mdi方式打开子窗体
            frmSingerType fst = new frmSingerType();
            fst.MdiParent = this;
            fst.Show();
        }

        /// <summary>
        /// 歌曲类型管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSongType_Click(object sender, EventArgs e)
        {
            //mdi方式打开子窗体
            frmSongType fm = new frmSongType();
            fm.MdiParent = this;
            fm.Show();
        }

        /// <summary>
        /// 歌曲管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSongAdmin_Click(object sender, EventArgs e)
        {
            //mdi方式打开子窗体
            frmSong fs = new frmSong();
            fs.MdiParent = this;
            fs.Show();
        }

        /// <summary>
        /// 管理员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAdminNews_Click(object sender, EventArgs e)
        {
            //mdi方式打开子窗体
            frmAdminShow fm = new frmAdminShow();
            fm.MdiParent = this;
            fm.Show();
        }

        private void 歌手类型管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
