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
    public partial class frmOrderBySongAB : Form
    {
        public frmOrderBySongAB()
        {
            InitializeComponent();
        }

        private void frmOrderBySongWordCount_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 根据拼音简写查询歌曲到LV中
        /// </summary>
        /// <param name="songAB"></param>
        public void ShowSong(string songAB)
        {
            this.lvShow.Items.Clear();
            Song[] songs = new Song[50];
            string sqlStr = "select SongID,SongName,SingerName,url,a.SingerID" +
                " from Song a,Singer b where a.SingerID=b.SingerID and Songab like'%" + songAB + "%'";

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

        /// <summary>
        /// 所以的按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button25_Click(object sender, EventArgs e)
        {
            //将当前按钮的text放入TxT中
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "重置":
                    this.txtSongAB.Text = "";
                    break;
                case "删除":
                    //如果字段为空，则跳出方法
                    if (this.txtSongAB.Text == "")
                    {
                        return;
                    }
                    this.txtSongAB.Text = txtSongAB.Text.Substring(0, this.txtSongAB.Text.Length - 1);
                    break;
                default:
                    this.txtSongAB.Text += btn.Text;
                    break;
            }
        }

        private void txtSongAB_TextChanged(object sender, EventArgs e)
        {
            ShowSong(this.txtSongAB.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmSomeSong fss = new frmSomeSong();
            fss.ShowDialog();
        }
    }
}




    

