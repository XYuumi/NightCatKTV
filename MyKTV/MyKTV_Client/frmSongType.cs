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
    public partial class frmSongType : Form
    {
        public frmSongType()
        {
            InitializeComponent();
        }
        public int singerTypeID;//歌手类型ID
        public string singerGender;//歌手性别
        private void pbRelSong_Click(object sender, EventArgs e)
        {
            frmMain.fp.RelSong();
        }

        private void pbDL_Click(object sender, EventArgs e)
        {
            //大陆歌手的数据库ID1001
            this.singerTypeID = 1001;
            //隐藏歌手类型的pan1
            this.panSingerType.Visible = false;
            this.panGender.Visible = true;
        }

        private void pbGT_Click(object sender, EventArgs e)
        {
            //港台歌手ID1002
            this.singerTypeID = 1002;
            //隐藏歌手类型的pan1
            this.panSingerType.Visible = false;
            this.panGender.Visible = true;
        }

        private void pbOM_Click(object sender, EventArgs e)
        {
            //欧美歌手ID1003
            this.singerTypeID = 1003;
            //隐藏歌手类型的pan1
            this.panSingerType.Visible = false;
            this.panGender.Visible = true;
        }

        private void pbRH_Click(object sender, EventArgs e)
        {
            //日韩歌手ID1004
            this.singerTypeID = 1004;
            //隐藏歌手类型的pan13
            this.panSingerType.Visible = false;
            this.panGender.Visible = true;
        }

        private void pbMan_Click(object sender, EventArgs e)
        {
            //男歌手
            this.singerGender = "男";
            //将用户选择的信息传递到子窗口中
            frmStarList fsl = new frmStarList();
            fsl.singerTypeID = this.singerTypeID;
            fsl.singerGender = this.singerGender;
            //打开子窗口
            fsl.ShowDialog();
            this.Close();
        }

        private void pbWuman_Click(object sender, EventArgs e)
        {
            //女歌手
            this.singerGender = "女";
            //将用户选择的信息传递到子窗口中
            frmStarList fsl = new frmStarList();
            fsl.singerTypeID = this.singerTypeID;
            fsl.singerGender = this.singerGender;
            //打开子窗口
            fsl.ShowDialog();
            this.Close();
        }

        private void pbZH_Click(object sender, EventArgs e)
        {
            //女歌手
            this.singerGender = "女";
            //将用户选择的信息传递到子窗口中
            frmStarList fsl = new frmStarList();
            fsl.singerTypeID = this.singerTypeID;
            fsl.singerGender = this.singerGender;
            //打开子窗口
            fsl.ShowDialog();
            //关闭当前窗口
            this.Close();
        }

        private void frmOrderByStar_Load(object sender, EventArgs e)
        {
            this.panSingerType.Visible = true;//显示歌手类型
            this.panGender.Visible = false;//隐藏歌手性别                       
        }

        private void pbYIDian_Click(object sender, EventArgs e)
        {
            //如果当时性别显示框
            if (this.panGender.Visible == true)
            {
                //则显示类型选择项
                this.panGender.Visible = false;
                this.panSingerType.Visible = true;
            }
            else
            {
                this.Close();
            }
        }

        private void panSingerType_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbNextSong_Click(object sender, EventArgs e)
        {
            frmMain.fp.NextSong();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmSomeSong fss = new frmSomeSong();
            fss.ShowDialog();
        }
    }
}
       

    




    

