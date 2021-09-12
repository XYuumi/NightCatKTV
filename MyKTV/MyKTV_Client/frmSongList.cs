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
    public partial class frmSongList : Form
    {
        public frmSongList()
        {
            InitializeComponent();
        }

        private void frmOrderByClientCount_Load(object sender, EventArgs e)
        {
            string sqlStr = "select SongID,SongName,SingerName,url,a.SingerID,ClientCount" +
                " from Song a,Singer b where a.SingerID=b.SingerID" +
                " and SingerName='" + this.lblJqSong.Text + "' order by ClientCount desc";
            DBHelper.getReader(sqlStr);
            while (DBHelper.dr.Read())

            {
                Song s = new Song();
                s.SongID = (int)DBHelper.dr["SongID"];
                s.SongName = DBHelper.dr["SongName"].ToString();
                s.SingerName = DBHelper.dr["SingerName"].ToString();
                s.Url = DBHelper.dr["url"].ToString();
                s.SingerID = (int)DBHelper.dr["SingerID"];
                ListViewItem item = new ListViewItem(s.SongName);
                item.SubItems.Add(s.SingerName);
                this.lvShow.Items.Add(item);
            }
            DBHelper.dr.Close();
            DBHelper.conn.Close();
        }

        /// <summary>
        /// 当用户改选择项时要做 的事
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvShow.SelectedItems.Count > 0)
            {
                string songName = this.lvShow.SelectedItems[0].Text;
                string sqlStr = "select SongID,SongName,SingerName,url,a.SingerID " +
                    " from Song a,Singer b where a.SingerID = b.SingerID and SongName = '" + songName + "'";
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
                string sqlStr1 = "update Song set ClientCount = ClientCount+1 where SongID=" + s.SingerID;
                DBHelper.getNonQuery(sqlStr1);

                //自动播放第一首歌
                if (frmMain.fp.Songs[0] != null && frmMain.fp.Songs[0].SongState == 0)
                {
                    frmMain.fp.RelSong();
                }
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbChong_Click(object sender, EventArgs e)
        {
            frmMain.fp.RelSong();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            frmMain.fp.NextSong();
        }

        private void pbFw_Click(object sender, EventArgs e)
        {
            frmSomeSong fss = new frmSomeSong();
            fss.ShowDialog();
        }
    }
}
