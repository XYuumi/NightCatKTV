using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MyKtv_Tool
{
    public class DBHelper
    {
        private static string connStr = "server =.;database=SuperKTV;uid = sa;pwd = 20020221ltr.";
        public static SqlConnection conn;
        public static SqlDataReader dr;
        public static int getNonQuery(string sqlStr)
        {
            int result = -1;
            conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;


        }
        public static SqlDataReader getReader(string sqlStr)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            dr = cmd.ExecuteReader();
            return dr;

        }
        /// <summary>
        /// 查询第一行第一列
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public static object getScalar(string sqlStr)
        {
            object result = null;
            conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            result = cmd.ExecuteScalar();
            conn.Close();
            return result;

        }
        public static DataTable getTable(string sqlStr)
        {
            DataTable result = null;
            conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            result = ds.Tables[0];
            conn.Close();
            return result;
        }
    }
}
