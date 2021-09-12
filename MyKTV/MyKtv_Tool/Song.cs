using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyKtv_Tool
{
    /// <summary>
    /// 歌曲类
    /// </summary>
    public class Song
    {
        /// <summary>
        /// 歌曲ID
        /// </summary>
        public int SongID;
        /// <summary>
        /// 歌曲名称
        /// </summary>
        public string SongName;
        /// <summary>
        /// 歌手ID
        /// </summary>
        public int SingerID;
        /// <summary>
        /// 歌曲文件名
        /// </summary>
        public string Url;
        /// <summary>
        /// 歌手名称
        /// </summary>
        public string SingerName;
        /// <summary>
        /// 描述状态
        /// </summary>
        public int SongState;
    }
}
