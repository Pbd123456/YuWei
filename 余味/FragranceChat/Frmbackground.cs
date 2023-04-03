using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LingFragSystem
{
    public partial class Frmbackground : Form
    {
        public Frmbackground()
        {
            InitializeComponent();
        }

        #region Panel切换事件方法
        /// <summary>
        /// Panel切换事件方法
        /// </summary>
        /// <param name="fm"></param>
        public void LoadFrom(object fm)
        {
            if (this.plMain.Controls.Count > 0)
            {
                this.plMain.Controls.RemoveAt(0);
            }
            Form f = fm as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.plMain.Controls.Add(f);
            this.plMain.Tag = f;
            f.Show();
        }

        #endregion

        #region 员工管理事件方法
        /// <summary>
        /// 员工管理事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            LoadFrom(new FrmEmployee());
        } 
        #endregion
    }
}
