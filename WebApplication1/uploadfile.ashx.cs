using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// uploadfile 的摘要说明
    /// </summary>
    public class uploadfile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //var t = context.Request.Form["editormd-image-file"];
            
            //string t = context.Request.ContentLength.ToString();
            //context.Response.Write(t);
            //context.Response.Write("{ \"success\":1,\"url\":\"123.jpg\",\"message\":\"success\"}");
            context.Response.ContentType = "text/plain";
            //指定字符集
            context.Response.ContentEncoding = System.Text.Encoding.UTF8;
            if (context.Request["REQUEST_METHOD"] == "OPTIONS")
            {
                context.Response.End();
            }
            SaveFile();

        }
        private void SaveFile(string basePath = "~/Upload/Images/")
        {
            var name = string.Empty;
            basePath = (basePath.IndexOf("~") > -1) ? System.Web.HttpContext.Current.Server.MapPath(basePath) : basePath;
            //获取文件上传集合
            HttpFileCollection files = System.Web.HttpContext.Current.Request.Files;

            //如果目录不存在，则创建目录
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }

            var suffix = files[0].ContentType.Split('/');
            //获取文件格式
            var _suffix = suffix[1].Equals("jpeg", StringComparison.CurrentCultureIgnoreCase) ? ".jpg" : suffix[1];
            var _temp = System.Web.HttpContext.Current.Request["name"];

            //如果不修改文件名，则创建随机文件名
            //if (!string.IsNullOrEmpty(_temp))
            //{
            //    name = _temp;
            //}
            //else
            //{
            Random rand = new Random(24 * (int)DateTime.Now.Ticks);
            name = rand.Next() + "." + _suffix;
            // }
            //文件保存
            var full = basePath + name;
            string fullpath = Convert.ToString(full);


            files[0].SaveAs(full);
            //{ \"success\":1,\"url\":\"123.jpg\",\"message\":\"success\"}
            var _result = "{\"success\" : 1, \"message\" : \"添加成功\", \"url\" : \"/Upload/Images/" + name + "\"}";
            System.Web.HttpContext.Current.Response.Write(_result);



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