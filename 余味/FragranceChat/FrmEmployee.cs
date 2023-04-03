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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        #region 窗体加载事件方法
        /// <summary>
        /// 窗体加载事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            cboSex.SelectedIndex = 0;
            cboState.SelectedIndex = 0;
            cboToin.SelectedIndex = 0;
            LoadDgv();
           
        }
        #endregion
        
        #region 刷新dgv
        /// <summary>
        /// 刷新dgv
        /// </summary>
        private void LoadDgv()
        {
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.DataSource = EmployeeManager.GetEmployees();
        } 
        #endregion

        #region 网格单击事件方法
        /// <summary>
        ///网格单击事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvEmployee.SelectedRows[0].Cells["clEmId"].Value.ToString();
            txtAdderss.Text = dgvEmployee.SelectedRows[0].Cells["clEmAddress"].Value.ToString();
            txtAge.Text = dgvEmployee.SelectedRows[0].Cells["clEmAge"].Value.ToString();
            txtCid.Text = dgvEmployee.SelectedRows[0].Cells["clEmCid"].Value.ToString();
            txtLogin.Text = dgvEmployee.SelectedRows[0].Cells["clEmCount"].Value.ToString();
            txtName.Text = dgvEmployee.SelectedRows[0].Cells["clEmName"].Value.ToString();
            txtPhone.Text = dgvEmployee.SelectedRows[0].Cells["clEmPhone"].Value.ToString();
            txtPwd.Text = dgvEmployee.SelectedRows[0].Cells["clEmPwd"].Value.ToString();
            txtWages.Text = dgvEmployee.SelectedRows[0].Cells["clEmWages"].Value.ToString();
            cboSex.Text = dgvEmployee.SelectedRows[0].Cells["clEmSex"].Value.ToString();
            cboState.Text = dgvEmployee.SelectedRows[0].Cells["clEmState"].Value.ToString();
            cboToin.Text = dgvEmployee.SelectedRows[0].Cells["clEmTion"].Value.ToString();
        }
        #endregion

        #region 重置事件方法
        /// <summary>
        ///重置事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadReaet();
        }
        #endregion

        #region 重置方法
        /// <summary>
        /// 重置方法
        /// </summary>
        private void LoadReaet()
        {
            txtId.Text = "";
            txtAdderss.Text = "";
            txtAge.Text = "";
            txtCid.Text = "";
            txtLogin.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtPwd.Text = "";
            txtWages.Text = "";
            cboSex.SelectedIndex = 0;
            cboState.SelectedIndex = 0;
            cboToin.SelectedIndex = 0;
        } 
        #endregion

        #region 添加事件方法
        /// <summary>
        /// 添加事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                Employee elp = new Employee()
                {
                    EmCount = txtLogin.Text,
                    EmPwd = txtPwd.Text,
                    EmName = txtName.Text,
                    EmAge = Convert.ToInt32(txtAge.Text),
                    EmSex = cboSex.Text,
                    EmPhone = txtPhone.Text,
                    EmCid = txtCid.Text,
                    EmAddress = txtAdderss.Text,
                    EmTion=cboToin.Text,
                    EmWages=Convert.ToInt32(txtWages.Text),
                    EmState = cboState.Text,
                };
                int elps = EmployeeManager.AddEmployeeInfoLogind(txtLogin.Text);
                if (elps == 0)
                {
                    int n = 0;
                    n = EmployeeManager.AddEmployee(elp);
                    LoadDgv();
                    LoadReaet();
                    if (n > 0)
                    {
                        MessageBox.Show("员工添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("员工添加失败！");
                    }
                }
                else
                {
                    MessageBox.Show("该账号已存在！");
                }
            }
        }
        #endregion

        #region 校验信息的完整性
        /// <summary>
        /// 校验信息的完整性
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("请输入账号！");
                txtLogin.Focus();
                return false;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("请输入密码！");
                txtPwd.Focus();
                return false;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("请输入电话！");
                txtPhone.Focus();
                return false;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("请输入员工姓名！");
                txtName.Focus();
                return false;
            }
            if (txtAge.Text == "")
            {
                MessageBox.Show("请输入年龄！");
                txtAge.Focus();
                return false;
            }
            if (txtWages.Text == "")
            {
                MessageBox.Show("请输入员工工资！");
                txtWages.Focus();
                return false;
            }
            if (txtAdderss.Text == "")
            {
                MessageBox.Show("请输入员工住址！");
                txtAdderss.Focus();
                return false;
            }
            if (txtCid.Text == "")
            {
                MessageBox.Show("请输入员工身份证号！");
                txtCid.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region 删除事件方法
        /// <summary>
        /// 删除事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndalete_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("您确定要删除该员工吗？", "删除", MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);
            string a = dgvEmployee.SelectedRows[0].Cells["clEmId"].Value.ToString();
            if (ret == DialogResult.Yes)
            {
                int n = EmployeeManager.DeleteEmployee(a);
                if (n>0)
                {
                    LoadDgv();
                    LoadReaet();
                    MessageBox.Show("员工删除成功！");
                }
                else
                {
                    MessageBox.Show("员工删除失败！");
                }
            }
        }
        #endregion

        #region 修改事件方法
        /// <summary>
        /// 修改事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee em = new Employee()
            {
                EmCid = txtCid.Text,
                EmId = Convert.ToInt32(txtId.Text),
                EmAddress = txtAdderss.Text,
                EmAge = Convert.ToInt32(txtAge.Text),
                EmCount = txtLogin.Text,
                EmName = txtName.Text,
                EmPhone = txtPhone.Text,
                EmPwd = txtPwd.Text,
                EmSex = cboSex.Text,
                EmState = cboState.Text,
                EmTion = cboToin.Text,
                EmWages = Convert.ToDecimal(txtWages.Text)
            };
            int n = EmployeeManager.UpdateEmployee(em);
            if (n > 0)
            {
                LoadDgv();
                LoadReaet();
                MessageBox.Show("员工修改成功！");
            }
            else
            {
                MessageBox.Show("员工修改失败！");
            }
        }
        #endregion

        # region 关闭事件方法
        /// <summary>
        /// 关闭事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 查询事件方法
        /// <summary>
        /// 查询事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = EmployeeManager.GetEmployeeByEmId(txtFind.Text);
           txtFind.Focus();
        } 
        #endregion
    }
}
