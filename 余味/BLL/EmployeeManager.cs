using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class EmployeeManager
    {
        #region 查询所有员工信息
        /// <summary>
        /// 查询所有员工信息
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetEmployees()
        {
            return EmployeeServers.GetEmployees();
        }
        #endregion

        #region 精确查询事件方法
        /// <summary>
        /// 精确查询事件方法
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetEmployeeByEmId(string coon)
        {
            return EmployeeServers.GetEmployeeByEmId(coon);
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
            return EmployeeServers.AddEmployee(elp);
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
            return EmployeeServers.AddEmployeeInfoLogind(login);
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
            return EmployeeServers.DeleteEmployee(em);
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
            return EmployeeServers.UpdateEmployee(elp);
        } 
        #endregion
    }
}
