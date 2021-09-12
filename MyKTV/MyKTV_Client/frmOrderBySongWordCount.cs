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
    public partial class frmOrderBySongWordCount : Form
    {
        public frmOrderBySongWordCount()
        {
            InitializeComponent();
        }

        private void frmOrderBySongWordCount_Load(object sender, EventArgs e)
        {

        }
        public void ShowSong(int songWordCount)
        {
            this.lvShow.Items.Clear();
            Song[] songs = new Song[50];
            string sqlStr = "select SongID,SongName,SingerName,url,a.SingerID" +
                " from Song a,Singer b where a.SingerID=b.SingerID ";
            if (songWordCount <= 6)
            {
                sqlStr += "and SongWordCount=" + songWordCount;
            }
            else
            {
                sqlStr += "and SongWordCount>6";
            }
            DBHelper.getReader(sqlStr);
            while (DBHelper.dr.Read())
            {
                Song s = new Song();
                s.SingerID = (int)DBHelper.dr["SingerID"];
                s.SongName = DBHelper.dr["SongName"].ToString();
                s.SingerName = DBHelper.dr["SingerName"].ToString();
                s.Url = DBHelper.dr["url"].ToString();
                s.SongID = (int)DBHelper.dr["SongID"];
                ListViewItem item = new ListViewItem(s.SongName);
                item.SubItems.Add(s.SingerName);
                this.lvShow.Items.Add(item);
            }
            DBHelper.dr.Close();
            DBHelper.conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMain.fp.NextSong();
        }

        private void frmOrderBySongWordCount_Load_1(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ShowSong(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ShowSong(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ShowSong(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ShowSong(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ShowSong(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ShowSong(6);
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            ShowSong(7);
        }

        private void pbYIDian_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbRelSong_Click(object sender, EventArgs e)
        {
            frmMain.fp.RelSong();
        }

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvShow.SelectedItems.Count > 0)
            {
                string songName = this.lvShow.SelectedItems[0].Text;

                string sqlStr = "select SongID,SongName,SingerName,url, a.SingerID from " +
                    "Song a,Singer b where a.SingerID = b.SingerID" +
                    " and SongName='" + songName + "'";
                DBHelper.getReader(sqlStr);
                Song s = null;
                if (DBHelper.dr.Read())
                {

                    s = new Song();
                    s.SongID = (int)DBHelper.dr["SongID"];
                    s.SongName = DBHelper.dr["SongName"].ToString();
                    s.SingerName = DBHelper.dr["SingerName"].ToString();
                    s.Url = DBHelper.dr["url"].ToString();
                    s.SingerID = (int)DBHelper.dr["SingerID"];
                    for (int i = 0; i < frmMain.fp.Songs.Length; i++)
                    {
                        if (frmMain.fp.Songs[i] == null)
                        {
                            frmMain.fp.Songs[i] = s;

                            break;
                        }
                    }

                }

                DBHelper.dr.Close();
                DBHelper.conn.Close();

                string sqlStr1 = " update Song set ClientCount = ClientCount+1 where SongID = " + s.SingerID;
                DBHelper.getNonQuery(sqlStr1);

                //自动播放第一首歌
                if (frmMain.fp.Songs[0] != null && frmMain.fp.Songs[0].SongState == 0)
                {
                    frmMain.fp.RelSong();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmSomeSong fss = new frmSomeSong();
            fss.ShowDialog();
        }
    }
}




    

