using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using BLL;
using Newtonsoft.Json;
using System.Data;
namespace WebApplication1
{
    /// <summary>
    /// PostALLAit 的摘要说明
    /// </summary>
    public class PostALLAit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            //int id = Convert.ToInt32( context.Request.Form["article_idd"]);
            //DataTable ds = BLL.Art.GetAitAll(id);
            ////context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(ds));
            //articles art = new articles();
            //DataRow dr = ds.Rows[0];
            //art.article_title = dr["article_title"].ToString();
            //art.article_content = dr["article_content"].ToString();
            //context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(art));



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