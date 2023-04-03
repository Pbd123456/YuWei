using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace LingFragSystem
{
   public class FrmValues
    {
        //存储当前登录名称
        public static string loginName { get; set; }

        //存储当前桌号/包间
        public static string ramadhin { get; set; }

        //存储菜名
        public static string MeName { get; set; }

        //存储下单的菜
        public static List<PlaceorderInfo> MeList = new List<PlaceorderInfo>();

        //存储单号
        public static int Bnumber { get; set; }
    }
}
