using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using Newtonsoft.Json;
using BLL;
namespace WebApplication1
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //string jsonstr;
            //context.Request.
            articles art = new articles();
            //jsonstr = JsonConvert.SerializeObject(art);
            //context.Response.Write(jsonstr);
            //BLL.Ait.SaveAir(art);
            art.article_title = context.Request.Form["article_title"].ToString();
            art.article_content = context.Request.Form["article_content"].ToString();
            BLL.Ait.SaveAir(art);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}