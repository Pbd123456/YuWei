using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StorageInfo
    {
        public int Meid { get; set; }               //菜品id
        public string MeName { get; set; }          //菜品名称
        public decimal MePrice { get; set; }        //价格
        public int FypeId { get; set; }             //菜品id
        public byte[] MPicture { get; set; }        //菜品图片
        public string MeTerial { get; set; }        //菜品主料
        public string MeTaste { get; set; }         //菜品口味
        public string MeDetails { get; set; }       //菜品详情
        public string Fname { get; set; }           //菜品类型
        public int MeNumber { get; set; }           //销售数量
    }
}
