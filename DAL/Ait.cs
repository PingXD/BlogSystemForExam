using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class Ait
    {

        public static int Add(articles saveart)
        {

            //在注册按钮点击事件  传输regusers的变量 user_name,user_password,user_email,user_profile_photo,user_birthday,user_telephone_number, user_nickname
            string sql = string.Format("INSERT into articles (article_title,article_content,article_class,artcle_content_20) VALUES ('{0}','{1}','{2}','{3}')", saveart.article_title, saveart.article_content,saveart.article_class,saveart.artcle_content_20);
            //下面这行是全列执行，由于html页还未为邮箱设计BOX等暂不使用，设计完后要加非空，或空验证  执行不同的sql
            //string sql = string.Format("INSERT into users (user_name,user_password,user_email,user_profile_photo,user_registration_time,user_birthday,user_telephone_number,user_nickname) VALUES ('{0}','{1}','{2}','{3}',NOW(),{4},'{5}','{6}')", regusers.user_name, regusers.user_password, regusers.user_email, regusers.user_profile_photo, regusers.user_birthday, regusers.user_telephone_number, regusers.user_nickname);
            int result = dbhelper.ExecuteNorQuery(sql);//调用dbh执行sql语句
            return result;
        }
        public static DataTable GetArtALL(int id)
        {
            string sql = string.Format("SELECT * from articles where article_id={0} ",id);
            DataTable ds = new DataTable();
            ds = dbhelper.GetTable(sql);
            return ds;
        }
        public static DataTable GetArtALLA()
        {
            string sql = string.Format("SELECT * from articles");
            DataTable ds = new DataTable();
            ds = dbhelper.GetTable(sql);
            return ds;
        }
        public static DataTable GetClass()
        {
            string sql = "SELECT  DISTINCT article_class FROM `articles` where !(article_class is null)";
            DataTable dt = new DataTable();
            dt = dbhelper.GetTable(sql);
            return dt;
        }
        public static DataTable GetClassArt(string classname) 
        {
            string sql = string.Format("select * from articles where article_class =\"{0}\"", classname);
            DataTable dt = new DataTable();
            dt = dbhelper.GetTable(sql);
            return dt;
        }
    }
}
