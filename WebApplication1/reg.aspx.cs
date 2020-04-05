using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
namespace WebApplication1
{
    public partial class reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uname = unmbox.Text.Trim();
            string pwd = CreatMd5.GetMD5(pwdboxy.Text.Trim());
            users regu = new users();
            regu.user_name = uname;
            regu.user_password = pwd;
            
            if (UserManage.Add(regu)==1)
            {
                Response.Write("<script>alert('注册成功');</script>");
            }
            else
            {
                Response.Write("<script>alert('注册shibai');</script>");
            }
            
        }
    }
}