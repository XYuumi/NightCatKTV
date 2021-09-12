using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyKtv_Tool;

namespace MyKtv_Server
{
    public partial class frmSinger : Form
    {
        public frmSinger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSinger_Load(object sender, EventArgs e)
        {
            //调用加载刷新方法
            ShowDGV();
            //显示绑定歌手类型下拉框
            ShowSingerType();
        }

        
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSinger();
            //重新刷新显示内容
            ShowDGV();
            ShowSingerType();
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSinger(this.txtSingerID.Text);//调用删除方法
            ShowDGV();//刷新
            ShowSingerType();//刷新下拉框
        }

        /// <summary>
        /// 右键删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            //判断是否选择一行信息
            if (this.dgvShow.SelectedRows.Count > 0)
            {
                //获取选中一行信息的SingerID值
                string singerID = this.dgvShow.SelectedRows[0].Cells["SingerID"].Value.ToString();
                DeleteSinger(singerID);
                ShowDGV();//调用加载刷新方法
                ShowSingerType();//刷新下拉框
            }
        }

        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSinger();//调用修改方法
            ShowDGV();//调用加载刷新方法
            ShowSingerType();//刷新下拉框
        }

        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSx_Click(object sender, EventArgs e)
        {
            ShowDGV();//调用加载刷新方法
            ShowSingerType();//刷新下拉框
        }

        /// <summary>
        /// 添加歌手类型按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSingerType_Click(object sender, EventArgs e)
        {
            frmSingerType fm = new frmSingerType();
            fm.ShowDialog();
            //更新后，需要更新的下拉框选项
            ShowSingerType();
        }

        /// <summary>
        /// 游览图片按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYl_Click(object sender, EventArgs e)
        {
            //打开OFD对话框文件
            this.ofdPic.ShowDialog();
            if (this.txtPhoto.Text != null)
            { //关闭获取文件名
                this.txtPhoto.Text = "";
                this.txtPhoto.Text = this.ofdPic.SafeFileName;
                //展示图片--判断如果路径文本框不为空
                if (this.txtPhoto.Text != null)
                {
                    //判断是否为默认值
                    if (txtPhoto.Text== "openFileDialog1")
                    {
                        this.txtPhoto.Text = "暂无图标.jpg";
                        return;//跳出方法
                    }
                    this.pbSinger.Image = Image.FromFile(this.ofdPic.FileName);
                }
            }
            //判断是否选择照片
            if (this.txtPhoto.Text == "暂无图标.jpg")
            {
                MessageBox.Show("请选择文件!", "系统提示");
            }
        }

        //-------------------------------------------以下为所调用的方法

        /// <summary>
        /// 加载刷新方法
        /// </summary>
        public void ShowDGV()
        {
            //执行sql语句查询
            string sqlStr = "select SingerID,SingerName,a.SingerTypeID,b.SingerTypeName,a.Gender,a.Photo from Singer a,SingerType b where a.SingerTypeID=b.SingerTypeID";
            //将查询结果显示在dgv中
            this.dgvShow.DataSource = DBHelper.getTable(sqlStr);
            //清空数据
            this.txtSingerID.Text = "";
            this.txtSingerName.Text = "";
            this.cboGender.Text = "";
            this.cboType.SelectedIndex = -1;
            this.txtPhoto.Text = "";
            this.pbSinger.Image = null;
        }

        /// <summary>
        /// 绑定下拉框方法
        /// </summary>
        private void ShowSingerType()
        {
            //执行sql语句查询
            string sqlStr = "select SingerTypeID,SingerTypeName from SingerType";
            //将结果显示在下拉框中
            this.cboType.DataSource = DBHelper.getTable(sqlStr);
            this.cboType.ValueMember = "SingerTypeID";
            this.cboType.DisplayMember = "SingerTypeName";
        }

        /// <summary>
        /// 添加歌手方法
        /// </summary>
        private void AddSinger()
        {
            if (this.txtPhoto.Text == "")
            {
                this.txtPhoto.Text = "暂无图片.jpg";
            }
            if (this.txtSingerName.Text == "")
            {
                this.txtSingerName.Text = "默认";
            }
            //执行sql语句添加数据
            string sqlStr = "insert into Singer values ('{0}',{1},'{2}','{3}')";
            sqlStr = string.Format(sqlStr, this.txtSingerName.Text, this.cboType.SelectedValue, this.cboGender.Text, this.txtPhoto.Text);
            //判断结果
            int result = DBHelper.getNonQuery(sqlStr);
            if (result > 0)
            {
                MessageBox.Show("操作成功！", "提示");
            }
            else
            {
                MessageBox.Show("操作失败！", "提示");
            }
        }

        /// <summary>
        /// 删除歌手方法
        /// </summary>
        private void DeleteSinger(string singerID)
        {
            //可能歌手有歌曲，因此要删除歌曲再删除歌手
            string SongStr = "delete from Song where SingerID=" + singerID;
            DBHelper.getNonQuery(SongStr);
            //删除歌手
            string sqlStr = "delete from Singer where SingerID={0}";
            sqlStr = string.Format(sqlStr, singerID);
            int result = DBHelper.getNonQuery(sqlStr);
            if (result > 0)
            {
                MessageBox.Show("操作成功", "提示");
            }
            else
            {
                MessageBox.Show("操作失败", "提示");
            }
        }

        /// <summary>
        /// 修改歌手方法
        /// </summary>
        private void UpdateSinger()
        {
            //查询路径
            string sql = "select RPath from ResourceUrl where RName='SingerPic'";
            //存入变量
            string path = DBHelper.getScalar(sql).ToString();
            //路径
            path += "\\" + this.dgvShow.SelectedRows[0].Cells["Photo"].Value.ToString();
            //判断图片是否默认
            if (this.txtPhoto.Text == path)
            {
                MessageBox.Show("未选择图片，请重试！", "系统提示");
                return;//跳出方法
            }
            //执行sql语句修改数据
            string sqlStr = "update Singer set SingerName = '{0}',SingerTypeID={1},Gender='{2}',Photo='{3}'where SingerID='{4}'";
            sqlStr = string.Format(sqlStr, this.txtSingerName.Text, this.cboType.SelectedValue, this.cboGender.Text, this.txtPhoto.Text, this.txtSingerID.Text);
            //判断结果
            int result = DBHelper.getNonQuery(sqlStr);
            if (result > 0)
            {
                MessageBox.Show("操作成功！", "提示");
            }
            else
            {
                MessageBox.Show("操作失败", "提示");
            }
        }

        /// <summary>
        /// 选中信息显示在文本框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvShow_SelectionChanged(object sender, EventArgs e)
        {
            //注意：先要判断所选项是否至少有一个
            if (this.dgvShow.SelectedRows.Count > 0)
            {
                //将选择内容放入对话框中
                this.txtSingerID.Text = this.dgvShow.SelectedRows[0].Cells["SingerID"].Value.ToString();
                this.txtSingerName.Text = this.dgvShow.SelectedRows[0].Cells["SingerName"].Value.ToString();
                this.cboGender.Text = this.dgvShow.SelectedRows[0].Cells["Gender"].Value.ToString();
                //由于cboSingerType数据从数据库中读取的，因此要找到相应的内容
                string SingerTypeName = this.dgvShow.SelectedRows[0].Cells["SingerTypeName"].Value.ToString();
                //循环绑定
                for (int i = 0; i < cboType.Items.Count; i++)
                {
                    //获取当前选项
                    DataRowView item = (DataRowView)this.cboType.Items[i];
                    //如果当前选项的显示文本 完全等于DGV中的类型名称
                    if (item.Row[1].ToString() == SingerTypeName)
                    {
                        //下拉框选择项改为当前索引
                        this.cboType.SelectedIndex = i;
                        break;
                    }
                }
                //绑定照片
                string sqlStr = "select RPath from ResourceUrl where RName='SingerPic'";
                string path = DBHelper.getScalar(sqlStr).ToString();
                //路径
                path += "\\" + this.dgvShow.SelectedRows[0].Cells["Photo"].Value.ToString();
                this.txtPhoto.Text = path;
                this.pbSinger.Image = Image.FromFile(path);
            }
        }

        private void txtPhoto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void txtSingerID_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
