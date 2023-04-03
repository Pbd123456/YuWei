using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class PlaceorderInfo
    {
        public int Bid { get; set; }            //账单id
        public string BiNumber { get; set; }    //单号
        public string Radhin { get; set; }      //桌号
        public string MeName { get; set; }      //菜品名称
        public int MeNumber { get; set; }       //菜品数量
        public string Btaste { get; set; }      //口味
        public string Bnote { get; set; }       //备注
        public int BiPrice { get; set; }        //总金额
        public string Btime { get; set; }       //下单日期

        public byte[] BtPric;                   //存储图片
        public int Nid { get; set; }        //单号id

    }
}
