﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using DAL;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        bool yn = false; 
        protected void Page_Load(object sender, EventArgs e)
        {
            string uid = Request.QueryString["uid"];
            yn = DAL.CookieChecker.CookieCheacker(uid, "user");
         
            if (uid!=null)
            {
                if (yn == true)
                {
                   //传递确认变量
                }
                else
                {
                    //传递错误变量。
                }
            }


        }
    }
}