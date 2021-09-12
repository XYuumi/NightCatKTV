using MyKtv_Server;
using MyKtv_Tool;
using System;
using System.Windows.Forms;

namespace MyKTV_Server
{
    public partial class frmSong : Form
    {
        public frmSong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开窗体的加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSong_Load(object sender, EventArgs e)
        {
            DGVshow();//调用刷新方法
            singerid();//调用方法获取下拉框的值
        }

        /// <summary>
        /// 添加歌手按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            frmSinger fs = new frmSinger();
            fs.ShowDialog();//模式化打开
        }

        /// <summary>
        /// 添加类型按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            frmSongType fst = new frmSongType();
            fst.ShowDialog();//模式化打开
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTianJia_Click(object sender, EventArgs e)
        {
            Add();//调用添加方法
            DGVshow();//刷新
        }

        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXiuGai_Click(object sender, EventArgs e)
        {
            Upate();//调用修改方法
            DGVshow();//刷新
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShanChu_Click(object sender, EventArgs e)
        {
            Del(this.txtGeQvID.Text);//调用删除方法
            DGVshow();//刷新
        }

        /// <summary>
        /// 清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQinKong_Click(object sender, EventArgs e)
        {
            qk();//清空文本框
            DGVshow();//刷新dgv
            singerid();//显示默认下拉框
        }

        /// <summary>
        /// 添加路径按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            //模式化打开对话框
            this.ofd1.ShowDialog();
            //关闭获取文件名
            if (this.txtGeQvWanJian.Text != null)
            { 
                //关闭获取文件名
                this.txtGeQvWanJian.Text = "";
                this.txtGeQvWanJian.Text = this.ofd1.SafeFileName;
            }
            else
            {
                MessageBox.Show("请选择文件");
            }
        }
        
        /// <summary>
        /// 将选中数据显示在文本框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSonginfo_SelectionChanged(object sender, EventArgs e)
        {
            //判断是否选中数据
            if (this.dgvSonginfo.SelectedRows.Count > 0)
            {
                //将选中行数数据转换为字符串类型显示在文本框中
                this.txtGeQvID.Text = this.dgvSonginfo.SelectedRows[0].Cells["SongID"].Value.ToString();
                this.txtDianJiNv.Text = this.dgvSonginfo.SelectedRows[0].Cells["ClientCount"].Value.ToString();
                this.txtGeQvMing.Text = this.dgvSonginfo.SelectedRows[0].Cells["SongName"].Value.ToString();
                this.txtGeQvWanJian.Text = this.dgvSonginfo.SelectedRows[0].Cells["Url"].Value.ToString();
                this.txtPinYin.Text = this.dgvSonginfo.SelectedRows[0].Cells["Songab"].Value.ToString();
                this.txtZiShu.Text = this.dgvSonginfo.SelectedRows[0].Cells["SongWordCount"].Value.ToString();
                this.cboGeQvLeiXing.Text = this.dgvSonginfo.SelectedRows[0].Cells["SongTypeName"].Value.ToString();
                this.cboGeShouMing.Text = this.dgvSonginfo.SelectedRows[0].Cells["SingerName"].Value.ToString();
                //执行sql语句查询资源文件路径
                string sql = "select RPath from ResourceUrl where RName = 'Song'";
                string path = DBHelper.getScalar(sql).ToString();
                //将路径转为字符串类型显示在文本框中
                this.txtGeQvWanJian.Text = path + "\\" + dgvSonginfo.SelectedRows[0].Cells["Url"].Value.ToString();
            }
        }

        //-----------------------------------------------以下为所调用的方法
        /// <summary>
        /// 刷新和清空文本框方法
        /// </summary>
        private void DGVshow()
        {
            //执行sql语句查询数据
            string sql = "select SongID, SongName, Songab, SongWordCount, a.SongTypeID,b.SingerName, c.SongTypeName, Url, ClientCount from song a, Singer b,SongType c where a.SingerID = b.SingerID and a.SongTypeID = c.SongTypeID";
            //将结果显示在dgv中
            this.dgvSonginfo.DataSource = DBHelper.getTable(sql);
            //清空文本框
            qk();
        }

        /// <summary>
        /// 显示下拉框值方法
        /// </summary>
        private void singerid()
        {
            //执行sql语句查询歌手信息
            string sql1 = "select SingerID,SingerName from Singer";
            //显示数据到dgv中
            this.cboGeShouMing.DataSource = DBHelper.getTable(sql1);
            this.cboGeShouMing.ValueMember = "SingerID";
            this.cboGeShouMing.DisplayMember = "SingerName";
            //执行sql语句查询歌曲类型信息
            string sql2 = "select SongTypeID,SongTypeName from SongType";
            //显示数据到dgv中
            this.cboGeQvLeiXing.DataSource = DBHelper.getTable(sql2);
            this.cboGeQvLeiXing.ValueMember = "SongTypeID";
            this.cboGeQvLeiXing.DisplayMember = "SongTypeName";
        }

        /// <summary>
        /// 清空文本框方法
        /// </summary>
        private void qk()
        {
            this.txtGeQvID.Text = "";
            this.txtDianJiNv.Text = "";
            this.txtGeQvMing.Text = "";
            this.txtGeQvWanJian.Text = "";
            this.txtPinYin.Text = "";
            this.txtZiShu.Text = "";
        }

        /// <summary>
        /// 添加数据方法
        /// </summary>
        private void Add()
        {
            //判断空值
            if (txtDianJiNv.Text == "" || txtGeQvMing.Text == "" || txtGeQvWanJian.Text == "" || txtPinYin.Text == "" || txtZiShu.Text == "")
            {
                MessageBox.Show("未填写完整数据，请重试！", "系统提示");
                return;
            }
            //判断点击率和字数输入是否正确
            int a;//声明变量
            string djl = txtDianJiNv.Text;
            string zs = txtZiShu.Text;
            //利用强制转换判断填写是否为数字
            if (!int.TryParse(djl, out a))
            {
                MessageBox.Show("请输入正确的点击率！", "系统提示");
                return;
            }
            if (!int.TryParse(zs, out a))
            {
                MessageBox.Show("请输入正确的字数！", "系统提示");
                return;
            }
            //执行sql语句添加数据-----歌名，拼音，字数，歌曲类型，歌手编号，文件名，点击率
            string sql = string.Format("insert into Song values('{0}','{1}',{2},{3},{4},'{5}',{6})",
                this.txtGeQvMing.Text, this.txtPinYin.Text, this.txtZiShu.Text, this.cboGeQvLeiXing.SelectedValue, this.cboGeShouMing.SelectedValue, this.txtGeQvWanJian.Text, this.txtDianJiNv.Text);
               //根据影响行数判断结果
            if (DBHelper.getNonQuery(sql) > 0)
            {
                MessageBox.Show("操作成功", "提示");
            }
            else
            {
                MessageBox.Show("操作失败", "提示");
            }
        }

        /// <summary>
        /// 修改数据方法
        /// </summary>
        private void Upate()
        {
            //判断空值
            if (txtDianJiNv.Text == "" || txtGeQvID.Text == "" || txtGeQvMing.Text == "" || txtGeQvWanJian.Text == "" || txtPinYin.Text == "" || txtZiShu.Text == "")
            {
                MessageBox.Show("未填写完整数据，请重试！", "系统提示");
                return;
            }
            //判断点击率和字数输入是否正确
            int a;//声明变量
            string djl = txtDianJiNv.Text;
            string zs = txtZiShu.Text;
            //利用强制转换判断填写是否为数字
            if (!int.TryParse(djl, out a))
            {
                MessageBox.Show("请输入正确的点击率！", "系统提示");
                return;
            }
            if (!int.TryParse(zs, out a))
            {
                MessageBox.Show("请输入正确的字数！", "系统提示");
                return;
            }
            //执行sql语句修改数据
            string sql = string.Format("update Song set SongName='{0}', Songab='{1}', SongWordCount={2}, SongTypeID={3}, SingerID={4}, Url='{5}', ClientCount='{6}'where SongID={7}",
                this.txtGeQvMing.Text, this.txtPinYin.Text, this.txtZiShu.Text, this.cboGeQvLeiXing.SelectedValue, this.cboGeShouMing.SelectedValue, this.txtGeQvWanJian.Text, this.txtDianJiNv.Text, this.txtGeQvID.Text);
            //判断结果
            if (DBHelper.getNonQuery(sql) > 0)
            {
                MessageBox.Show("操作成功", "提示");
            }
            else
            {
                MessageBox.Show("操作失败", "提示");
            }
        }

        /// <summary>
        /// 删除数据方法
        /// </summary>
        private void Del(string SongID)//删除数据
        {
            //执行sql语句删除歌曲
            string sql = string.Format("delete from Song where SongID={0}",SongID);
            //判断结果
            if (DBHelper.getNonQuery(sql) > 0)
            {
                MessageBox.Show("操作成功", "提示");
            }
            else
            {
                MessageBox.Show("操作失败", "提示");
            }
        }
    }
}
