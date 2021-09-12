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
    public partial class frmMain : Form
    {
        //播放界面
        public static frmPlayer fp = new frmPlayer();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Resource.InitResource();
            fp.Show();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 重唱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void pbChong_Click(object sender, EventArgs e)
        {
            fp.RelSong();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            fp.NextSong();
        }

        private void pbYIDian_Click(object sender, EventArgs e)
        {
            frmSomeSong fss = new frmSomeSong();
            fss.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fp.Songs[0] == null)
            {
                return;
            }
            this.lblSongShow.Text = fp.Songs[fp.index].SongName + " - " + fp.Songs[fp.index].SingerName;

            if (fp.index == (fp.Songs.Length - 1) || fp.Songs[fp.index + 1] == null)
            {
                this.lblSongNext.Text = "未找到歌曲";
            }
            else
            {
                this.lblSongNext.Text = fp.Songs[fp.index + 1].SongName + "-" + fp.Songs[fp.index + 1].SingerName;
            }
            //当歌曲只剩一首自动重放
            //if (fp.Songs[0]!=null && fp.Songs[0].Url!=fp.wmpSongPlayer.URL)
            //{
            //    fp.RelSong();
            //}
        }

        private void pbWordc_Click(object sender, EventArgs e)
        {
            frmOrderBySongWordCount fob = new frmOrderBySongWordCount();
            fob.ShowDialog();
        }

        private void lblSongNext_Click(object sender, EventArgs e)
        {

        }

        private void lblSongShow_Click(object sender, EventArgs e)
        {

        }

        private void pbOrdreByClientCount_Click(object sender, EventArgs e)
        {
            frmOrderByClientCount fbc = new frmOrderByClientCount();
            fbc.ShowDialog();
        }

        private void pbPyin_Click(object sender, EventArgs e)
        {
            frmOrderBySongAB fos = new frmOrderBySongAB();
            fos.ShowDialog();
        }

        private void pbMxSong_Click(object sender, EventArgs e)
        {
            frmOrderByStar fob = new frmOrderByStar();
            fob.ShowDialog();
        }

        private void pbSongType_Click(object sender, EventArgs e)
        {
            frmSongType fst = new frmSongType();
            fst.ShowDialog();
        }

        private void pbZt_Click(object sender, EventArgs e)
        {
            fp.videoPause();//调用frmPlayer窗体中暂停方法
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fp.videoStart();//调用frmPlayer窗体中播放方法
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fp.yin(1);//音量-
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fp.yin(2);//音量+
        }
    }
}
