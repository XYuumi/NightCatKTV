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
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当前播放
        /// </summary>
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 界面加载时要做的事
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPlayer_Load(object sender, EventArgs e)
        {
            if (Songs[0] == null)
            {
                return;
            }
            index = 0;
            Songs[index].SongState = 1;
            wmpSongPlayer.URL = Resource.SongPath + "\\" + Songs[index].Url;
            Songs[index].SongState = 1;
        }

        /// <summary>
        ///点播歌曲列表
        ///默认当前都是NULL
        /// </summary>
        public Song[] Songs = new Song[50];
        public int index = 0;

        /// <summary>
        /// 重新播放
        /// </summary>
        public void RelSong()
        {
            if (Songs[index]==null)
            {
                return;
            }
            wmpSongPlayer.URL = Resource.SongPath + "\\" + Songs[index].Url;
            Songs[index].SongState = 1;
        }

        /// <summary>
        /// 暂停
        /// </summary>
        public void videoPause()
        {
            wmpSongPlayer.Ctlcontrols.pause();
        }
        //播放
        public void videoStart()
        {
            wmpSongPlayer.Ctlcontrols.play();
        }
        /// <summary>
        /// 切歌
        /// </summary>
        public void NextSong()
        {
            if (Songs[0] == null || Songs[1]==null)
            {
                return;
            }
            for (int i = 0; i < Songs.Length - 1; i++)
            {
                Songs[i] = Songs[i + 1];
            }
            //播放器播放歌曲
            wmpSongPlayer.URL = Resource.SongPath + "\\" + Songs[index].Url;
            Songs[index].SongState = 1;
        }

        /// <summary>
        ///音量
        /// </summary>
        /// <param name="i"></param>
        public void yin(int i)
        {
            switch (i)
            {
                case 1:
                    wmpSongPlayer.settings.volume -= 5;
                    break;
                case 2:
                    //播放器背景音量+=5
                    wmpSongPlayer.settings.volume += 5;
                    break;
            }
        }
    }
}
