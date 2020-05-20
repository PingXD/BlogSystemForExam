using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
namespace DAL
{
    public class dbhelper
    {
        static string constr = "server=192.168.1.10;port=3306;user=root;database=blog;CharSet=utf8";
        /// <summary>
        /// 执行增删改操作的方法，返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNorQuery(string sql)
        {
            int result;
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(sql, conn);
                result = comm.ExecuteNonQuery();
            }
            return result;
        }
        public static object ExecuteScalar(string sql)
        {
            object obj;
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(sql, conn);
                obj = comm.ExecuteScalar();

            }
            return obj;
        }

        public static DataTable GetTable(string sql)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
                sda.Fill(dt);
                
            }
            return dt;
        }
        public static DataSet GetDset(string sql)
        {
            
            DataSet ds = new DataSet();
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);
                sda.Fill(ds);
               
            }
            return ds;
        }

    }
}
