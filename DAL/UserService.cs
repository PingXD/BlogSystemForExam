using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    //接受业务逻辑层传递过来的数据，操作数据库，并将操作之后的结果返回给业务逻辑层
    public class UserService
    {


        public static int Add(users regusers)
        {

            //在注册按钮点击事件  传输regusers的变量 user_name,user_password,user_email,user_profile_photo,user_birthday,user_telephone_number, user_nickname
            string sql = string.Format("INSERT into users (user_name,user_password) VALUES ('{0}','{1}')", regusers.user_name, regusers.user_password);
            //下面这行是全列执行，由于html页还未为邮箱设计BOX等暂不使用，设计完后要加非空，或空验证  执行不同的sql
            //string sql = string.Format("INSERT into users (user_name,user_password,user_email,user_profile_photo,user_registration_time,user_birthday,user_telephone_number,user_nickname) VALUES ('{0}','{1}','{2}','{3}',NOW(),{4},'{5}','{6}')", regusers.user_name, regusers.user_password, regusers.user_email, regusers.user_profile_photo, regusers.user_birthday, regusers.user_telephone_number, regusers.user_nickname);
            int result = dbhelper.ExecuteNorQuery(sql);//调用dbh执行sql语句
            return result;
        }

        public static users Login(users user)
        {
            users u = null;
            string sql = String.Format("select * from users where user_name='{0}'", user.user_name);
            //datatable要换成list
            DataTable dt = dbhelper.GetTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    
                    u = new users();
                    DataRow dr = dt.Rows[0];
                    u.user_name = dr["user_name"].ToString();
                    u.user_telephone_number = dr["user_telephone_number"].ToString();
                    u.user_password = dr["user_password"].ToString();
                    u.user_nickname = dr["user_nickname"].ToString();
                    u.user_id = Convert.ToInt32(dr["user_id"]);
                }
            }
            return u;
        }



        /// <summary>
        /// 传入uid，获取UID+PWD的MD5
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public static string UidGetReUIDandPWDToMd5(string uid)
        {

            string sql = String.Format("select user_password from users where user_id='{0}'", uid);
            //datatable要换成list
            DataTable dt = dbhelper.GetTable(sql);
            string cookie = null;
            if (dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                cookie = Md5.MD5Encrypt(uid + dr["user_password"].ToString());
            }
            return cookie;
        }
    }
}
