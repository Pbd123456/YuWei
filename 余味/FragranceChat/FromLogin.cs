using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;

namespace LingFragSystem
{
    public partial class FromLogin : Form
    {
        public static string uid { get; set; }
        public FromLogin()
        {
            InitializeComponent();
        }

        #region 登录
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //获取账号密码，职位
            uid = txtUid.Text;
            string pwd = txtPwd.Text;
            string tion = (this.rbtion.Checked ? "操作员" : "管理员");

            //查找数据
            List<Employee> ei = LoginManager.SelectLogin(uid, pwd, tion);
            if (ei.Count > 0)
            {
                if (tion == "操作员")
                {
                    //如果是操作员的话，进入主界面
                    FrmMain frm = new FrmMain();
                    //切换窗口
                    frm.Show();
                    //关闭窗口
                    this.Hide();
                }
                else
                {
                    Frmbackground frm = new Frmbackground();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("账号密码错误！");
            }
        }
        #endregion

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromLogin_Load(object sender, EventArgs e)
        {
            //文本框设置透明
            this.txtUid.BackColor = this.BackColor;
            this.txtPwd.BackColor = this.BackColor;
            //默认选择
            rbtion.Checked = true;

        }
        #endregion

        #region 重置事件方法
        /// <summary>
        /// 重置事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSest_Click(object sender, EventArgs e)
        {
            txtUid.Text = "";
            txtPwd.Text = "";
            rbtion.Checked = true;
        }
        #endregion

        #region 退出事件方法
        /// <summary>
        /// 退出事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //退出
            Application.Exit();
        }
        #endregion
    }
}
