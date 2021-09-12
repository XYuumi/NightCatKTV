using MyKtv_Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyKtv_Client
{
    public partial class frmSomeSong : Form
    {
        //播放界面
        public frmPlayer fp = new frmPlayer();
        public frmSomeSong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 返回主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 重唱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbChong_Click(object sender, EventArgs e)
        {
            frmMain.fp.RelSong();
        }

        /// <summary>
        /// 切歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbNext_Click(object sender, EventArgs e)
        {
            frmMain.fp.NextSong();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// 窗体加载时要做的事
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSomeSong_Load(object sender, EventArgs e)
        {
            ShowSong();
        }
        public static Song[] Songs = new Song[50];

        /// <summary>
        /// 展示所有已点歌曲
        /// PS：将frmPlayer中的Songs数组展示出来
        /// </summary>
        public void ShowSong()
        {

            for (int i = 0; i < Songs.Length; i++)
            {
                //获取遍历歌曲
                Song s = frmMain.fp.Songs[i];
                if (s != null && s.SongState != 2)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = s.SongName;
                    string sqlStr = "select SingerName from Singer where SingerID =" + s.SingerID;
                    string SingerName = DBHelper.getScalar(sqlStr).ToString();
                    item.SubItems.Add(SingerName);
                    this.lvShowSong.Items.Add(item);
                }
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            frmMain.fp.yin(1);//音量-
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            frmMain.fp.yin(2);//音量+
        }

        private void pbZt_Click_1(object sender, EventArgs e)
        {
            frmMain.fp.videoPause();//调用frmPlayer窗体中暂停方法
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmMain.fp.videoStart();//调用frmPlayer窗体中播放方法
        }
    }
}
