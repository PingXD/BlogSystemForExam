using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class Ait
    {
        /// <summary>
        /// 传入art 储存文章内容
        /// </summary>
        /// <param name="articles"></param>
        /// <returns></returns>
        public static int SaveAir( articles articles) => DAL.Air.Add(articles);
    }
}
