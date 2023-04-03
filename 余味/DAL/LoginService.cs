using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
  public  class LoginService
    {
        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        /// <param name="tion"></param>
        /// <returns></returns>
        public static List<Employee> SelectLogin(string uid, string pwd, string tion)
        {
            List<Employee> em = new List<Employee>();
            string sql = "select top 100 EmCount,EmPwd,EmTion from Employee where EmCount = '" + uid + "' and EmPwd ='" + pwd + "' and EmTion ='" + tion + "'";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Employee ei = new Employee();
                ei.EmCount = dr["EmCount"].ToString();
                ei.EmPwd = dr["EmPwd"].ToString();
                ei.EmTion = dr["EmTion"].ToString();
                em.Add(ei);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return  em;
        }
        #endregion
    }
}
