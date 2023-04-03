using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;



namespace BLL
{
    public class StorageManager
    {

        #region 添加菜单信息
        /// <summary>
        /// 添加菜单信息
        /// </summary>
        /// <param name="sif"></param>
        /// <returns></returns>
        public static int StoreImageAdd(StorageInfo sif)
        {

            return StorageServier.StoreImageAdd(sif);
        
        }
        #endregion

        #region 桌号管理
        /// <summary>
        /// 桌号管理
        /// </summary>
        /// <returns></returns>
        public static List<Ramadhin> RamadhinInfo()
        {
            return StorageServier.RamadhinInfo();
        }
        #endregion
    }
}
