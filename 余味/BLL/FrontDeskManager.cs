using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class FrontDeskManager
    {
        #region 查看所有菜品
        /// <summary>
        /// 查看所有菜品
        /// </summary>
        /// <returns></returns>
        public static List<StorageInfo> StoraheInfoQuery()
        {
            return FrontDeskService.StoraheInfoQuery();
        }
        #endregion

        #region 查询所有菜品类型
        /// <summary>
        /// 查询所有菜品类型
        /// </summary>
        /// <returns></returns>
        public static List<FdisTypeInfo> SelectFdisTypeInfoQuery()
        {
            return FrontDeskService.SelectFdisTypeInfoQuery();
        }
        #endregion

        #region 根据类型编号查找菜品
        /// <summary>
        /// 根据类型编号查找菜品
        /// </summary>
        /// <param name="FypeId"></param>
        /// <returns></returns>
        public static List<StorageInfo> SelectStoraheQuery(int FypeId)
        {
            return FrontDeskService.SelectStoraheQuery(FypeId);
        }
        #endregion

        #region 根据菜品名查询数据
        /// <summary>
        /// 根据菜品名查询数据
        /// </summary>
        /// <param name="StorName"></param>
        /// <returns></returns>
        public static List<StorageInfo> SelectStorNameQuery(string StorName)
        {
            return FrontDeskService.SelectStorNameQuery(StorName);
        }
        #endregion

        #region 批量查询
        /// <summary>
        /// 批量查询
        /// </summary>
        /// <param name="storag"></param>
        /// <returns></returns>
        public static List<StorageInfo> SelectStorageInfo(string storag)
        {
            return FrontDeskService.SelectStorageInfo(storag);
        }
        #endregion  
    }
}
