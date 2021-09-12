using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyKtv_Tool
{
    /// <summary>
    /// 资源项目类
    /// </summary>
    public class Resource
    {
        /// <summary>
        /// 歌手图片文件夹路径
        /// </summary>
        public static string SingerPicPath;

        /// <summary>
        /// 歌曲图片文件夹路径
        /// </summary>
        public static string SongPicPath;

        /// <summary>
        /// 歌曲文件夹路径
        /// </summary>
        public static string SongPath;
        /// <summary>
        /// 从数据库加载到上述文件字段中
        /// </summary>
        public static void InitResource()
        {
            string sqlStr = "select * from ResourceUrl";
            DBHelper.getReader(sqlStr);
            while (DBHelper.dr.Read())
            {
                switch (DBHelper.dr["RName"].ToString())
                {
                    //如果RName的值为对应内容，则将相应的地址放入对应变量中
                    case "SingPic":
                        SingerPicPath = DBHelper.dr["RPath"].ToString();
                        break;
                    case "SongPic":
                        SongPicPath = DBHelper.dr["RPath"].ToString();
                        break;
                    case "Song":
                        SongPath = DBHelper.dr["RPath"].ToString();
                        break;
                    default:
                        break;
                }
            }
            DBHelper.dr.Close();
            DBHelper.conn.Close();
        }
    }
}
