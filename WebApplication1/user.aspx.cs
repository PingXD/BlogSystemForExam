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
    public partial class user1 : System.Web.UI.Page
    {
        
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        public void Button1_Click(object sender, EventArgs e)
        {
            string name = UNBox.Text.Trim();
            string pwd = CreatMd5.GetMD5( PWDBox.Text.Trim());
            //传递给业务逻辑层
            users Loginuser = new users();
            Loginuser.user_name = name;
            Loginuser.user_password = pwd;
            string nickname = Loginuser.user_nickname;
            //UserManage.Login
            
            users pu = UserManage.Login(Loginuser);
            
            if (pu != null)
            {
                if (pu.user_password == pwd)
                {
                    //Response.Write(string.Format("<script>alert('欢迎您{0}')</script>",nickname));
                    UserManage.Cook(pu);
                    
                    Response.Redirect(string.Format("index.aspx?uid={0}", pu.user_id));
                }
                else Response.Write("<script>alert('密码错误');</script>");
            }
            else 
            {
                Response.Write("<script>alert('账号不存在，请注册哟。');</script>");
                //Response.Redirect("reg.aspx");
            }
            

    }
    }
}