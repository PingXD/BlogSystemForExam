using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AddArticle : System.Web.UI.Page
    {
        bool yn = false;
        protected void Page_Load(object sender, EventArgs e)
        {

            string uid= Request.QueryString["uid"];
                if (uid != null)
            {
                yn = DAL.CookieChecker.CookieCheacker(uid, "user");
                if (yn == true)
                {
                    Response.Write("<script>alert('欢迎');</script>");
                }
                else
                {
                    Response.Write("<script>alert('麻油权限，请先登录admin账户');</script>");
                    Response.Write("<script>window.location = '/index.aspx'</script>");
                }
            }
                 else
                {
                Response.Write("<script>alert('请先登录');</script>");
                    Response.Write("<script>window.location = '/user.aspx'</script>");
            }
                
        }
    }
}