using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FdisTypeInfo
    {
        public int FypeId { get; set; }     //菜品类型编号
        public string Fname { get; set; }   //类型名称

        public int Nid { get; set; }        //单号id
        public string BiNumber { get; set; }//单号

        public int Nstate { get; set; }     //状态

    }
}
