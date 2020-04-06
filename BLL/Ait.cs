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
        public static int SaveAir( articles articles) => DAL.Air.Add(articles);
    }
}
