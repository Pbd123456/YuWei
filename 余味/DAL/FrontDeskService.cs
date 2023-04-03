using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class FrontDeskService
    {
        #region 查看所有菜品
        /// <summary>
        /// 查看所有菜品
        /// </summary>
        /// <returns></returns>
        public static List<StorageInfo> StoraheInfoQuery()
        {
            List<StorageInfo> sti = new List<StorageInfo>();
            string sql = "select top 1000 * from Menu";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                StorageInfo sif = new StorageInfo();
                sif.MeName = dr["MeName"].ToString();
                sif.MePrice = Convert.ToInt32(dr["MePrice"]);
                sif.FypeId = Convert.ToInt32(dr["FypeId"]);
                sif.MPicture = (byte[])dr["MPicture"];
                sif.MeTerial = dr["MeTerial"].ToString();
                sif.MeTaste = dr["MeTaste"].ToString();
                sif.MeDetails = dr["MeDetails"].ToString();
                sti.Add(sif);
            };
            dr.Close();
            SqlDbHelper.CloseCon();
            return sti;
        }
        #endregion

        #region 查询所有菜品类型
        /// <summary>
        /// 查询所有菜品类型
        /// </summary>
        /// <returns></returns>
        public static List<FdisTypeInfo> SelectFdisTypeInfoQuery()
        {
            List<FdisTypeInfo> ft = new List<FdisTypeInfo>();

            string sql = "select top 100 * from FdisType";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                FdisTypeInfo fti = new FdisTypeInfo();
                fti.FypeId = Convert.ToInt32(dr["FypeId"]);
                fti.Fname = dr["Fname"].ToString();
                ft.Add(fti);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return ft;
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
            List<StorageInfo> sti = new List<StorageInfo>();
            string sql = "select top 100 * from Menu where FypeId = " + FypeId + " ";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                StorageInfo sif = new StorageInfo();
                sif.MeName = dr["MeName"].ToString();
                sif.MePrice = Convert.ToInt32(dr["MePrice"]);
                sif.FypeId = Convert.ToInt32(dr["FypeId"]);
                sif.MPicture = (byte[])dr["MPicture"];
                sif.MeTerial = dr["MeTerial"].ToString();
                sif.MeTaste = dr["MeTaste"].ToString();
                sif.MeDetails = dr["MeDetails"].ToString();
                sti.Add(sif);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return sti;
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
            List<StorageInfo> str = new List<StorageInfo>();
            string sql = "select top 10 * from  Menu where MeName = '" + StorName + "'";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                StorageInfo sif = new StorageInfo();
                sif.MeName = dr["MeName"].ToString();
                sif.MePrice = Convert.ToInt32(dr["MePrice"]);
                sif.FypeId = Convert.ToInt32(dr["FypeId"]);
                sif.MPicture = (byte[])dr["MPicture"];
                sif.MeTerial = dr["MeTerial"].ToString();
                sif.MeTaste = dr["MeTaste"].ToString();
                sif.MeDetails = dr["MeDetails"].ToString();
                str.Add(sif);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return str;


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
            List<StorageInfo> sti = new List<StorageInfo>();
            string sql = "select top 100 A.MeName,A.MePrice,B.Fname,A.MPicture,A.MeTerial,A.MeTaste,A.MeDetails,A.MeNumber from Menu A,FdisType B where A.FypeId = B.FypeId and Fname = '"+storag+"'";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                StorageInfo sr = new StorageInfo();
                sr.MeName = dr["MeName"].ToString();
                sr.MePrice = Convert.ToInt32(dr["MePrice"]);
                sr.Fname = dr["Fname"].ToString();
                sr.MeName = dr["MeName"].ToString();
                sr.MPicture = (byte[]) dr["MPicture"];
                sr.MeTerial = dr["MeTerial"].ToString();
                sr.MeTaste = dr["MeTaste"].ToString();
                sr.MeDetails = dr["MeDetails"].ToString();
                sr.MeNumber = Convert.ToInt32(dr["MeNumber"]);
                sti.Add(sr);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return sti;
        }
        #endregion
    }
}
