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
    public class EmployeeServers
    {
        #region 查询所有员工信息
        /// <summary>
        /// 查询所有员工信息
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetEmployees()
        {
            List<Employee> elps = new List<Employee>();
            string sql = "select top 1000 * from Employee";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Employee elp = new Employee();
                elp.EmAddress = dr["EmAddress"].ToString();
                elp.EmAge = Convert.ToInt32(dr["EmAge"]);
                elp.EmCid = dr["EmCid"].ToString();
                elp.EmCount = dr["EmCount"].ToString();
                elp.EmId = Convert.ToInt32(dr["EmId"]);
                elp.EmName = dr["EmName"].ToString();
                elp.EmPhone = dr["EmPhone"].ToString();
                elp.EmPwd = dr["EmPwd"].ToString();
                elp.EmSex = dr["EmSex"].ToString();
                elp.EmState = dr["EmState"].ToString();
                elp.EmTion = dr["EmTion"].ToString();
                elp.EmWages = Convert.ToDecimal(dr["EmWages"]);
                elps.Add(elp);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return elps;
        }
        #endregion

        #region 精确查询事件方法
        /// <summary>
        /// 精确查询事件方法
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetEmployeeByEmId(string coon)
        {
            List<Employee> el = new List<Employee>();
            string sql = "select top 1000 * from Employee where"+
                " EmName like'%" + coon + "%' or Emsex like'%" + coon + "%' "+
                " or EmTion like'%" + coon + "%' or EmCount like'%" + coon + "%' ";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Employee e = new Employee();
                e.EmAddress = dr["EmAddress"].ToString();
                e.EmAge = Convert.ToInt32(dr["EmAge"]);
                e.EmCid = dr["EmCid"].ToString();
                e.EmCount = dr["EmCount"].ToString();
                e.EmId = Convert.ToInt32(dr["EmId"]);
                e.EmName = dr["EmName"].ToString();
                e.EmPhone = dr["EmPhone"].ToString();
                e.EmPwd = dr["EmPwd"].ToString();
                e.EmSex = dr["EmSex"].ToString();
                e.EmState = dr["EmState"].ToString();
                e.EmTion = dr["EmTion"].ToString();
                e.EmWages = Convert.ToDecimal(dr["EmWages"]);
                el.Add(e);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return el;
        }
        #endregion

        #region 添加员工信息
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="elp"></param>
        /// <returns></returns>
        public static int AddEmployee(Employee elp)
        {
            int n = 0;
            string sql = "insert into Employee(EmCount,EmPwd,EmName,EmAge," +
                "EmSex,EmPhone,EmCid,EmAddress,EmWages,EmTion,EmState) values" +
                " (@EmCount,@EmPwd,@EmName,@EmAge," +
                "@EmSex,@EmPhone,@EmCid,@EmAddress,@EmWages,@EmTion,@EmState)";
            n = SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text,
                new SqlParameter[]
                {
                    new SqlParameter("@EmAddress",elp.EmAddress),
                    new SqlParameter("@EmAge",elp.EmAge),
                    new SqlParameter("@EmCid",elp.EmCid),
                    new SqlParameter("@EmCount",elp.EmCount),
                    new SqlParameter("@EmName",elp.EmName),
                    new SqlParameter("@EmPhone",elp.EmPhone),
                    new SqlParameter("@EmPwd",elp.EmPwd),
                    new SqlParameter("@EmSex",elp.EmSex),
                    new SqlParameter("@EmState",elp.EmState),
                    new SqlParameter("@EmTion",elp.EmTion),
                    new SqlParameter("@EmWages",elp.EmWages),
                }
                );
            return n;
        }
        #endregion

        #region 校验员工账号
        /// <summary>
        /// 校验员工账号
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static int AddEmployeeInfoLogind(string login)
        {
            int n = 0;
            List<Employee> ems = new List<Employee>();
            string sql = "select * from Employee where EmCount='" + login + "'";
            SqlDataReader dr = SqlDbHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Employee em = new Employee();
                em.EmCount = dr["EmCount"].ToString();
                if (login == em.EmCount)
                {
                    n++;
                    break;
                }
                ems.Add(em);
            }
            dr.Close();
            SqlDbHelper.CloseCon();
            return n;
        }
        #endregion

        #region 删除工员信息
        /// <summary>
        /// 删除工员信息
        /// </summary>
        /// <param name="em"></param>
        /// <returns></returns>
        public static int DeleteEmployee(string em)
        {
            return SqlDbHelper.ExecuteNonQuery("DeleteEmployee",
                CommandType.StoredProcedure,new SqlParameter[] {
                new SqlParameter("@EmId",em)});
        }
        #endregion

        #region 修改员工信息
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="elp"></param>
        /// <returns></returns>
        public static int UpdateEmployee(Employee elp)
        {
            int n = 0;
            n = SqlDbHelper.ExecuteNonQuery("UpdateEmployee", CommandType.StoredProcedure,
                new SqlParameter[]
                {
                    new SqlParameter("@EmId",elp.EmId),
                    new SqlParameter("@EmAddress",elp.EmAddress),
                    new SqlParameter("@EmAge",elp.EmAge),
                    new SqlParameter("@EmCid",elp.EmCid),
                    new SqlParameter("@EmCount",elp.EmCount),
                    new SqlParameter("@EmName",elp.EmName),
                    new SqlParameter("@EmPhone",elp.EmPhone),
                    new SqlParameter("@EmPwd",elp.EmPwd),
                    new SqlParameter("@EmSex",elp.EmSex),
                    new SqlParameter("@EmState",elp.EmState),
                    new SqlParameter("@EmTion",elp.EmTion),
                    new SqlParameter("@EmWages",elp.EmWages),
                });
            return n;
        } 
        #endregion
    }
}
