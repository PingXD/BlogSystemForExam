﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Model;
namespace DAL
{
    public class Cookie
    {
        /// <summary>
        /// 使用uid和pwd生成以cookie
        /// </summary>
        /// <param name="cookie"></param>
        public static void Cookieget(users cookie)

        {

            string cok = Md5.MD5Encrypt(cookie.user_id + cookie.user_password);
            HttpCookie cokie = new HttpCookie("user");
            cokie.Expires = DateTime.Today.AddDays(7);
            cokie.Value = cok;
            

            //cokie.Domain="domain"
            HttpContext.Current.Response.Cookies.Add(cokie);

        }
        public static void Cooliegetuid(users cookie) {
            
            HttpCookie cook = new HttpCookie("uid");
            cook.Value= cookie.user_id.ToString();
            cook.Expires = DateTime.Today.AddDays(7);
            HttpContext.Current.Response.Cookies.Add(cook);
        }
    }
}
