using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Model;
namespace DAL
{
    public class CookieChecker
    {
        /// <summary>
        /// uid与cookie value验证  返回布尔类型 
        /// </summary>
        /// <param name="uid">传入用户的uid</param>
        /// <param name="cookiename">传入要与uid验证的cookiename</param>
        /// <returns></returns>
        public static bool CookieCheacker(string uid,string cookiename) {
            //cookie验证
            bool yn = false;

            if (HttpContext.Current.Request.Cookies[cookiename] != null|| uid != null)
            {

                yn =HttpContext.Current.Request.Cookies[cookiename].Value==UserService.UidGetReUIDandPWDToMd5(uid)?true:false;
                // uname是获取name为user的cookie   
                //通过传入的uid验证与cookie的值是否相等
            }

            //当bool变量yn为真时，验证成功  为假则失败   真的时候为登陆成功  否的时候为登陆失败 
            return yn;
    } }
}
