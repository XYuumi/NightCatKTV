using MyKtv_Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyKtv_Server
{
    public partial class frmResource : Form
    {
        public frmResource()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSingerPic_Click(object sender, EventArgs e)
        {
            this.fbdSingerPic.ShowDialog();

            this.txtPicutre.Text = this.fbdSingerPic.SelectedPath;
        }

        private void btnSongPic_Click(object sender, EventArgs e)
        {
            this.fbdSongPic.ShowDialog();

            this.txtposter.Text = this.fbdSongPic.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.fbdfile.ShowDialog();

            this.txtFile.Text = this.fbdfile.SelectedPath;
        }

        /// <summary>
        /// 将数据库文件绑定到界面中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>      
        private void frmResource_Load(object sender, EventArgs e)
        {
            //展示数据库中存储的位置
            string sqlStr = "select  * from ResourceUrl";
            SqlDataReader dr = DBHelper.getReader(sqlStr);
            dr.Read();
            //判断下一行是否有数据
            while (dr.Read())
            {
                switch (dr["RName"].ToString())
                {
                    case "SingerPic":
                        this.txtPicutre.Text = dr["RPath"].ToString();
                        break;
                    case "SongPic":
                        this.txtposter.Text = dr["RPath"].ToString();
                        break;
                    case "Song":
                        this.txtFile.Text = dr["RPath"].ToString();
                        break;
                }
            }
        }

        private void btnBaoCun_Click(object sender, EventArgs e)
        {
            //将三个内容数据整体修改
            //修改资源 
            string sql1 = "update ResourceUrl set RPath ='" + this.txtPicutre.Text + "'where RName ='SingerPic'";
            string sql2 = "update ResourceUrl set RPath= '" + this.txtposter.Text + "'where RName ='SongPic'";
            string sql3 = "update ResourceUrl set RPath= '" + this.txtFile.Text + "'where RName ='Song'";
            int result1 = DBHelper.getNonQuery(sql1);
            int result2 = DBHelper.getNonQuery(sql2);
            int result3 = DBHelper.getNonQuery(sql3);
            if (result1 > 0 && result2 > 0 && result3 > 0)
            {
                MessageBox.Show("保存成功！");
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
        }

        private void btnChong_Click(object sender, EventArgs e)
        {
            this.txtFile.Text = "";
            this.txtPicutre.Text = "";
            this.txtposter.Text = "";
        }
    }
}
