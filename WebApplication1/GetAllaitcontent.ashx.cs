using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// GetAllaitcontent 的摘要说明
    /// </summary>
    public class GetAllaitcontent : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int id;
            DataTable ds = null;
            string get = context.Request.Form["article_idd"];
            ds = BLL.Art.GetAitAll(Convert.ToInt32(get));
            context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(ds));
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