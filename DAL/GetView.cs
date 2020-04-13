using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class GetView
    {
        public static int Pnum() 
        {
          
            string sql = "select num from person";
            DataTable  dt = dbhelper.GetTable(sql);
            DataRow dr = dt.Rows[0];
            int res =  Convert.ToInt32(dr["num"]);
            return res;
        }
        public static void Savenum(int t) 
        {
            string sql = string.Format("update  person set num={0} WHERE id =1",t);
            dbhelper.ExecuteNorQuery(sql);
        }

    }
}
