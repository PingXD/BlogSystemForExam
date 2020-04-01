using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{

    /// <summary>
    /// MD5的控制
    /// </summary>
    public class CreatMd5
    {
        /// <summary>
        /// 传入str  传出str的32位MD5
        /// </summary>
        public static string GetMD5(string str) => Md5.MD5Encrypt(str);
    }
}
