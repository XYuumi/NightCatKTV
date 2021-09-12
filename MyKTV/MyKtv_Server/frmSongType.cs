using MyKtv_Tool;
using System;
using System.Windows.Forms;

namespace MyKTV_Server
{
    public partial class frmSongType : Form
    {
        public frmSongType()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSongType_Load(object sender, EventArgs e)
        {
            dgvshow();//调用加载方法
        }

        /// <summary>
        /// 添加按钮功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdde_Click(object sender, EventArgs e)
        {
            add();//调用添加方法
            dgvshow();//调用刷新方法
        }

        /// <summary>
        /// 修改按钮功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            xiugai();
            dgvshow();//调用刷新方法
        }

        /// <summary>
        /// 删除按钮功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            del();//调用删除方法
            dgvshow();//调用刷新方法
        }

        /// <summary>
        /// 右键删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //根据选中行数进行判断
            if (this.dgvSongTypeinfo.SelectedRows.Count > 0)//选中行数
            {
                //将选中行数的数据id存入singer中
                string singer = this.dgvSongTypeinfo.SelectedRows[0].Cells["SongTypeID"].Value.ToString();
                //调用删除方法
                del();
            }
            dgvshow();
        }

        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShuaXin_Click(object sender, EventArgs e)//刷新
        {
            dgvshow();//调用加载事件
        }

        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------以下为调用的方法

        /// <summary>
        /// 加载数据并清空文本框
        /// </summary>
        public void dgvshow()
        {
            //执行sql语句查询将数据显示出来
            string sql = "select SongTypeID,SongTypeName from SongType";
            //将数据放入dgv中
            this.dgvSongTypeinfo.DataSource = DBHelper.getTable(sql);
            //清空文本框内容
            this.txtSongType.Text = "";
            this.txtSongTypeID.Text = "";
        }

        /// <summary>
        /// 添加数据方法
        /// </summary>
        private void add()
        {
            //执行sql语句添加数据
            string sql = string.Format("insert into SongType values('{0}')",
                this.txtSongType.Text);
            //调用DBHelper并根据受影响行数判断返回结果
            if (DBHelper.getNonQuery(sql) > 0)
            {
                MessageBox.Show("操作成功！", "提示");
            }
            else
            {
                MessageBox.Show("操作失败！", "提示");
            }
        }

        /// <summary>
        /// 修改方法
        /// </summary>
        private void xiugai()
        {
            //执行sql语句修改数据内容
            string sql = string.Format("update SongType set SongTypeName='{0}' where SongTypeID={1}",
                this.txtSongType.Text, this.txtSongTypeID.Text);
            //根据影响行数判断是否执行成功并反馈
            if (DBHelper.getNonQuery(sql) > 0)
            {
                MessageBox.Show("操作成功！", "提示");
            }
            else
            {
                MessageBox.Show("操作失败，，您未选中数据！", "提示");
            }
        }
        /// <summary>
        /// 删除方法
        /// </summary>
        private void del()
        {
            //执行sql语句删除数据
            string sql = string.Format("delete from SongType where SongTypeID={0}",
                this.txtSongTypeID.Text);
            if (DBHelper.getNonQuery(sql) > 0)
            {
                MessageBox.Show("操作成功", "提示");
            }
            else
            {
                MessageBox.Show("已有此类型歌手，请先删除歌手在删除类型", "提示");
            }
        }

        /// <summary>
        /// 将选中数据显示在文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSongTypeinfo_SelectionChanged(object sender, EventArgs e)
        {
            //判断选中行数是否大于0
            if (this.dgvSongTypeinfo.SelectedRows.Count > 0)
            {
                //将选中数据转换成文本形式显示在文本框中
                this.txtSongTypeID.Text = this.dgvSongTypeinfo.SelectedRows[0].Cells["SongTypeID"].Value.ToString();
                this.txtSongType.Text = this.dgvSongTypeinfo.SelectedRows[0].Cells["SongTypeName"].Value.ToString();
            }
        }

        private void txtSongTypeID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
