using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
   public class BillStorageService
    {
        #region 添加账单信息
        /// <summary>
        /// 添加账单信息
        /// </summary>
        /// <param name="pif"></param>
        /// <returns></returns>
        public static int GetBillAdd(PlaceorderInfo pif)
        {
            int n = 0;
            string sql = "insert into Bill(Nid,Radhin,MeName,MeNumber,Btaste,Bnote,BiPrice,Btime)" +
                " values(@Nid,@Radhin,@MeName,@MeNumber,@Btaste,@Bnote,@BiPrice,@Btime)";
                n = SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text,
                new SqlParameter[] {
                new SqlParameter("@Nid",pif.Nid),
                new SqlParameter("@Radhin",pif.Radhin),
                new SqlParameter("@MeName",pif.MeName),
                new SqlParameter("@MeNumber",pif.MeNumber),
                new SqlParameter("@Btaste",pif.Btaste),
                new SqlParameter("@Bnote",pif.Bnote),
                new SqlParameter("@BiPrice",pif.BiPrice),
                new SqlParameter("@Btime",pif.Btime),
                });
            return n;
        }
        #endregion

        #region 根据桌号查询账单信息
        /// <summary>
        /// 根据桌号查询账单信息
        /// </summary>
        /// <returns></returns>
        public static List<PlaceorderInfo> SelectBillStoraheInfo(string Radhin)
        {
            List<PlaceorderInfo> ptf = new List<PlaceorderInfo>();
            string sql = "select top 100 * from Bill where Radhin='" + Radhin + "'";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                PlaceorderInfo pi = new PlaceorderInfo();
                pi.Bid = Convert.ToInt32(dr["Bid"]);
                pi.Radhin = dr["Radhin"].ToString();
                pi.Nid = Convert.ToInt32(dr["Nid"]);
                pi.MeName = dr["MeName"].ToString();
                pi.MeNumber = Convert.ToInt32(dr["MeNumber"]);
                pi.Btaste = dr["Btaste"].ToString();
                pi.Bnote = dr["Bnote"].ToString();
                pi.BiPrice = Convert.ToInt32(dr["BiPrice"]);
                pi.Btime = dr["BiPrice"].ToString() ;
                ptf.Add(pi);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return ptf;
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
            int n = 0;
            string sql = "delete from Bill where Radhin = '"+ Radhin + "' and MeName = '"+MeName+"'";
            n = SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text,
                new SqlParameter[] {
                new SqlParameter("@Radhin",Radhin),
                new SqlParameter("@MeName",MeName),
                });

            return n;
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
            int n = 0;
            string sql = "insert into Number values('"+BiNumber+"',"+state+")";
            n = SqlDbHelper.ExecuteNonQuery(sql,CommandType.Text,
                new SqlParameter[] { 
                new SqlParameter("@BiNumber",BiNumber),
                new SqlParameter("@Nstate",state),
            });
            return n;
        }
        #endregion

        #region 查询单号
        /// <summary>
        /// 查询单号
        /// </summary>
        /// <returns></returns>
        public static List<FdisTypeInfo> SelectFidsType()
        {
            List<FdisTypeInfo> fti = new List<FdisTypeInfo>();
            string sql = "select top 100 * from Number";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                FdisTypeInfo fi = new FdisTypeInfo();
                fi.Nid = Convert.ToInt32(dr["Nid"]);
                fi.BiNumber = dr["BiNumber"].ToString();
                fti.Add(fi);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return fti;
        }
        #endregion

        #region 单号精确查询
        /// <summary>
        /// 单号精确查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<FdisTypeInfo> SelectFidsTypeInfo(int id )
        {
            List<FdisTypeInfo> fti = new List<FdisTypeInfo>();
            string sql = "select top 100*from Number where Nid = "+id+"";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                FdisTypeInfo fi = new FdisTypeInfo();
                fi.Nid = Convert.ToInt32(dr["Nid"]);
                fi.BiNumber = dr["BiNumber"].ToString();
                fi.Nstate = Convert.ToInt32(dr["Nstate"]);
                fti.Add(fi);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return fti;
        }
        #endregion

        #region 根据单号查询所有点单
        /// <summary>
        /// 根据单号查询所有点单
        /// </summary>
        /// <returns></returns>
        public static List<PlaceorderInfo> SelectAllPlaceInfo(int Bnumber)
        {
            List<PlaceorderInfo> pt = new List<PlaceorderInfo>();
            string sql = "select top 100 * from Bill where Nid = "+Bnumber+"";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                PlaceorderInfo pi = new PlaceorderInfo();
                pi.Bid = Convert.ToInt32(dr["Bid"]);
                pi.Radhin = dr["Radhin"].ToString();
                pi.Nid = Convert.ToInt32(dr["Nid"]);
                pi.MeName = dr["MeName"].ToString();
                pi.MeNumber = Convert.ToInt32(dr["MeNumber"]);
                pi.Btaste = dr["Btaste"].ToString();
                pi.Bnote = dr["Bnote"].ToString();
                pi.BiPrice = Convert.ToInt32(dr["BiPrice"]);
                pi.Btime = dr["BiPrice"].ToString();
                pt.Add(pi);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return pt;
        }
        #endregion
    }
}
