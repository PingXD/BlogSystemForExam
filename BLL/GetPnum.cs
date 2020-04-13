using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public class GetPnum
    {
        public static int Num() => GetView.Pnum();
        public static void SAVNum(int t ) => GetView.Savenum(t);
    }
}
