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
    public class StorageServier
    {
        #region 添加菜品
        /// <summary>
        /// 添加菜品
        /// </summary>
        /// <param name="sif"></param>
        /// <returns></returns>
        public static int StoreImageAdd(StorageInfo sif)
        {
            int n= 0;
            string sql = "insert into Menu(MeName,MePrice,FyPeId,MPicture,MeTerial,MeTaste,MeDetails,MeNumber)" +
                " values(@MeName,@MePrice,@FyPeId,@MPicture,@MeTerial,@MeTaste,@MeDetails,@MeNumber)";
            n = SqlDbHelper.ExecuteNonQuery(sql,CommandType.Text,
                new SqlParameter[] { 
                new SqlParameter("@MeName",sif.MeName),
                new SqlParameter("@MePrice",sif.MePrice),
                new SqlParameter("@FyPeId",sif.FypeId),
                new SqlParameter("@MPicture",sif.MPicture),
                new SqlParameter("@MeTerial",sif.MeTerial),
                new SqlParameter("@MeTaste",sif.MeTaste),
                new SqlParameter("@MeDetails",sif.MeDetails),
                new SqlParameter("@MeNumber",sif.MeNumber),
                });
            SqlDbHelper.CloseCon();
            return n;
        }

        #endregion

        #region 桌号查询
        /// <summary>
        /// 桌号查询
        /// </summary>
        /// <returns></returns>
        public static List<Ramadhin> RamadhinInfo()
        {
            List<Ramadhin> rin = new List<Ramadhin>();
            string sql = "select * from Ramadhins";

            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Ramadhin rn = new Ramadhin();
                rn.Rid = Convert.ToInt32(dr["Rid"]);
                rn.Radhin = dr["Radhin"].ToString();
                rn.Rtate = dr["Rtate"].ToString();
                rin.Add(rn);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return rin;

        }
        #endregion

    }
}
