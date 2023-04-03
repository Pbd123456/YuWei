using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class BillStorageManaher
    {
        #region 添加账单信息     
        /// <summary>
        /// 添加账单信息
        /// </summary>
        /// <param name="pif"></param>
        /// <returns></returns>
        public static int GetBillAdd(PlaceorderInfo pif)
        {
            return BillStorageService.GetBillAdd(pif);
        }
        #endregion

        #region 根据桌号查询账单信息
        /// <summary>
        /// 根据桌号查询账单信息
        /// </summary>
        /// <returns></returns>
        public static List<PlaceorderInfo> SelectBillStoraheInfo(string Radhin)
        {
            return BillStorageService.SelectBillStoraheInfo(Radhin);
        }
        #endregion

        #region 删除账单信息
        /// <summary>
        /// 删除账单信息
        /// </summary>
        /// <param name="Radhin"></param>
        /// <param name="MeName"></param>
        /// <returns></returns>
        public static int DeleteBill(string Radhin, string MeName)
        {
            return BillStorageService.DeleteBill(Radhin, MeName);
        }
        #endregion

        #region 创建单号
        /// <summary>
        /// 创建单号
        /// </summary>
        /// <param name="BiNumber"></param>
        /// <returns></returns>
        public static int GetNumberInfoAdd(string BiNumber,int state)
        {
            return BillStorageService.GetNumberInfoAdd(BiNumber,state);
        }
        #endregion

        #region 查询单号
        /// <summary>
        /// 查询单号
        /// </summary>
        /// <returns></returns>
        public static List<FdisTypeInfo> SelectFidsType()
        {
            return BillStorageService.SelectFidsType();
        }
        #endregion

        #region 单号精确查询
        /// <summary>
        /// 单号精确查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<FdisTypeInfo> SelectFidsTypeInfo(int id)
        {
            return BillStorageService.SelectFidsTypeInfo(id);
        }
        #endregion

        #region 根据单号查询所有点单
        /// <summary>
        /// 根据单号查询所有点单
        /// </summary>
        /// <returns></returns>
        public static List<PlaceorderInfo> SelectAllPlaceInfo(int Bnumber)
        {
            return BillStorageService.SelectAllPlaceInfo(Bnumber);
        }
        #endregion
    }
}
