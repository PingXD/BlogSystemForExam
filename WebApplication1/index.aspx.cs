using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        bool yn = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = Application["num"].ToString();
            Label2.Text = Application["online"].ToString();
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {

            Result res = new Result();
            if (HttpContext.Current.Request.Cookies["user"] != null && HttpContext.Current.Request.Cookies["uid"] != null)
            {            
                         
                //string uid = Request.QueryString["uid"];
                yn = DAL.CookieChecker.CookieCheacker();
                //if (uid != null)
                //{
                    if (yn == true)
                    {
                        //res.result = "loginon";
                        //Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(res));
                        Response.Write("<div class=\"login\">已登陆</div>");
                    }
                    else
                    {
                        //res.result = "loginoff";
                        //Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(res));
                        Response.Write("<div class=\"login\">未登陆</div>");                        //Response.Write("<script>window.location = '/index.aspx'</script>");
                    }
                //}
                //else
                //{
                //    //res.result = "loginoff";
                //    //Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(res));
                //    Response.Write("<div class=\"login\">未登陆</div>");                    //Response.Write("<script>window.location = '/user.aspx'</script>");
                //}
            }
           
            else
            {
                //res.result = "loginoff";
                //Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(res));
                Response.Write("<div class=\"login\">未登陆</div>");
            }
            
            //string uid = Request.QueryString["uid"];
            //yn = DAL.CookieChecker.CookieCheacker(uid, "user");

            ////DataTable ds = BLL.Art.GetAitAll(2);
            //////context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(ds));
            ////articles art = new articles();
            ////DataRow dr = ds.Rows[0];
            ////art.article_title = dr["article_title"].ToString();
            ////art.article_content = dr["article_content"].ToString();
            ////art.article_date =Convert.ToDateTime( dr["article_date"]);


            //if (uid!=null)
            //{
            //    if (yn == true)
            //    {
            //       //传递确认变量
            //    }
            //    else
            //    {
            //        //传递错误变量。
            //    }
            //}


        }
       
    }
}