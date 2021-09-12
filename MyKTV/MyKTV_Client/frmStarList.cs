using MyKtv_Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKtv_Client
{
    public partial class frmStarList : Form
    {
        public int singerTypeID;//歌手类型ID
        public string singerGender;//歌手性别
        public frmStarList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 界面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStarList_Load(object sender, EventArgs e)
        {
            //根据筛选条件展示歌手信息
            string sqlStr = "select SingerID ,SingerName,a.SingerTypeID,SingerTypeName,Gender,Photo" +
                " from Singer a, SingerType b where a.SingerTypeID=b.SingerTypeID and a.SingerTypeID= " + singerTypeID + "and Gender='" + singerGender + "'";
            DBHelper.getReader(sqlStr);
            while (DBHelper.dr.Read())

            {
                int index = 0;//歌手图片列表的索引值

                //获取当前列表的名字
                string photoName = DBHelper.dr["Photo"].ToString();
                //获取这个图片在列表的下标
                index = this.imageList1.Images.IndexOfKey(photoName);
                ListViewItem item = new ListViewItem(DBHelper.dr["SingerName"].ToString(), index);

                //将列表项放入LV中
                this.lvShow.Items.Add(item);
            }
            DBHelper.dr.Close();
            DBHelper.conn.Close();
        }

        private void pbRelSong_Click(object sender, EventArgs e)
        {
            frmMain.fp.RelSong();
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvShow.SelectedItems.Count > 0)
            {
                frmSongList fsl = new frmSongList();
                //找到选择项的歌手名称，放到歌曲选择界面（根据歌手ID查询歌曲）
                fsl.lblJqSong.Text = this.lvShow.SelectedItems[0].Text;

                fsl.ShowDialog();
                //关闭当前窗口
                this.Close();
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbNextSong_Click(object sender, EventArgs e)
        {
            frmMain.fp.NextSong();
        }

        private void lblJqSong_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmSomeSong fss = new frmSomeSong();
            fss.ShowDialog();
        }
    }
}
