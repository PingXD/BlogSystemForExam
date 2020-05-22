using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;
namespace BLL
{
    public class Art
    {
        /// <summary>
        /// 传入art 储存文章内容
        /// </summary>
        /// <param name="articles"></param>
        /// <returns></returns>
        public static int SaveAir(articles articles) => DAL.Ait.Add(articles);

        /// <summary>
        /// 获取全部文章,返回dataset
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAitAll(int id) => Ait.GetArtALL(id);
        public static DataTable GetAitAllA() => Ait.GetArtALLA();
        public static DataTable GetClass() => Ait.GetClass();
        public static DataTable GetClassArt(string t) => Ait.GetClassArt(t);
    }
}
