using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class LoginManager
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
            return LoginService.SelectLogin(uid,pwd,tion);
        }
        #endregion
    }
}
