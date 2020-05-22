using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    
 
    public class UserManage
    {
        /// <summary>
        /// 传入users实体类，执行SQL ，返回受影响的行数
        /// </summary>
        public static int Add(users regu) => UserService.Add(regu);
        /// <summary>
        /// 传入user.username 传出pwd等信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static users Login(users user) => UserService.Login(user);
        /// <summary>
        /// 使用uid+pwd生成以user为name的cookie并保存到客户端
        /// </summary>
        public static void Cook(users cook) => Cookie.Cookieget(cook);

        /// <summary>
        /// 使用的UserService.uidGetReUIDandPWDToMd5，传入uid 返回uid+pwd的md5值
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public static string Getmd5cook(string uid) => UserService.UidGetReUIDandPWDToMd5(uid);
        public static void Getmd5cookuid(users cook) => Cookie.Cooliegetuid(cook);

    }
}
