using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using Newtonsoft.Json;
using BLL;
using System.IO;

namespace WebApplication1
{
    /// <summary>
    /// 获取编辑页面post过来的json 调用数据库保存
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //string jsonstr;
            //context.Request.

            //jsonstr = JsonConvert.SerializeObject(art);
            //context.Response.Write(jsonstr);
            //BLL.Ait.SaveAir(art);
            // context.Request.ContentType = "application/json";
            // Stream stream = context.Request.InputStream;
            // StreamReader sr = new StreamReader(stream);
            // string search = sr.ReadToEnd();
            // sr.Close();
            // var jSetting = new JsonSerializerSettings
            // {
            //     NullValueHandling  = NullValueHandling.Ignore
            // };
            //art= (RecordResult)JsonConvert.DeserializeObject(search, jSetting);
            articles art = new articles();
            art.article_title = context.Request.Form["article_title"].ToString();
            art.article_content = context.Request.Form["article_content"].ToString();
            art.article_class = context.Request.Form["article_class"].ToString();
            art.artcle_content_20 = context.Request.Form["article_content_20"].ToString();
            int t=BLL.Art.SaveAir(art);

            //context.Response.Write( "{ \"result\":\"success\"}");
            ////返回post的请求
            //Result res = new Result();
            //res.result = "success";
            if (t==1)
            {
                context.Response.Write("{ \"result\":\"success\"}");
                //上下两种方法都可以返回一个 result为success的json,下面的这种方法繁琐
                //context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(res));
            }
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