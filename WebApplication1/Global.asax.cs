using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["num"] = DAL.GetView.Pnum();//sql获取上次已存的共计访问人数
            Application["onLine"] = 0;	//初始化在线人数值为0

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();                                     
            Application["num"] = (int)Application["num"] + 1;    //访问+1
            Application["onLine"] = (int)Application["onLine"] + 1;	//在线加1
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();                                          
            Application["onLine"] = (int)Application["onLine"] - 1;     //session结束后，在线人数减1
            Application.UnLock();                                        
        }

        protected void Application_End(object sender, EventArgs e)
        {
            BLL.GetPnum.SAVNum((int)Application["num"]);
        }
    }
}