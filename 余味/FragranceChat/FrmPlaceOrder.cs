using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace LingFragSystem
{
    public partial class FrmPlaceOrder : Form
    {
        //存储循环次数
        public int number { get; set; }
        //存储控件个数
        public int numbers { get; set; }
        //每个leabl的位置
        public int a = 20;
        public int b = 20;
        public int c = 20;
        public int d = 20;
        public int ar = 20;

        int money;//存储金额

        //存储菜名
        string MeName = "";

        //存储价格
       public int MePrice { get; set; }
        public FrmPlaceOrder()
        {
            InitializeComponent();
        }

        #region 窗体加载事件方法
        /// <summary>
        /// 窗体加载事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPlaceOrder_Load(object sender, EventArgs e)
        {
            //列名横线
            Panel p1 = new Panel();
            p1.Size = new Size(570, 1);                 //大小
            p1.BorderStyle = BorderStyle.FixedSingle;   //外观
            p1.Location = new Point(20, 40);            //位置
            FlpPan.Controls.Add(p1);

            //下拉框事件
            cboType.DataSource = FrontDeskManager.SelectFdisTypeInfoQuery();
            cboType.DisplayMember = "Fname";

            cboType.ValueMember = "FypeId";

            //加载点单
            List<PlaceorderInfo> plf = BillStorageManaher.SelectAllPlaceInfo(FrmValues.Bnumber);
            MessageBox.Show(plf.Count+"");
            DynamicAdd(plf);
            //存储房号
            txtRid.Text = FrmValues.ramadhin;
            MessageBox.Show(FrmValues.ramadhin);
        }
        #endregion

        #region 添加菜品事件方法
        /// <summary>
        /// 添加菜品事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 添加
            //获取菜品名
            //string storName = cboDishes.Text;

            //if (pdf.Count == 0)
            //{

            //    //根据菜品名将所有数据添加到list集合
            //    OrderAdd(storName);
            //    //调用动态添加控件
            //    DynamicAdd();
            //}
            //else
            //{
            //    string acc = Judge();
            //    if (acc == "没有")
            //    {
            //        //根据菜品名将所有数据添加到list集合
            //        OrderAdd(storName);
            //        //调用动态添加控件
            //        DynamicAdd();
            //    }
            //    else
            //    {
            //        lock (pdf)
            //        {
            //            for (int i = 0; i < pdf.Count; i++)
            //            {
            //                //判断新加等于集合中有的
            //                if (storName == pdf[i].MeName)
            //                {
            //                    //获取数量
            //                    PlaceorderInfo pi = new PlaceorderInfo()
            //                    {
            //                        MeNumber = pdf[i].MeNumber,
            //                        BiPrice = pdf[i].BiPrice,
            //                    };

            //                    //存储数量
            //                     number = pi.MeNumber + Convert.ToInt32(txtNumber.Text);
            //                    //价格
            //                    MePrice = Convert.ToInt32(txtPrice.Text) * number;
            //                    //修改数据
            //                    pdf.ForEach(w => w.MeNumber = number) ;
            //                    //修改价格
            //                    pdf.ForEach(w => w.BiPrice = MePrice);
            //                    //清空控件中的数据
            //                    FlpPans.Controls.Clear();
            //                    //重新添加
            //                    DynamicAdd();

            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}

            #endregion

            //添加
            int n = 0;
          
                PlaceorderInfo pi = new PlaceorderInfo()
                {
                    Nid = FrmValues.Bnumber,
                    Radhin = txtRid.Text,
                    MeName = cboDishes.Text,
                    MeNumber =Convert.ToInt32( txtNumber.Text),
                    Btaste = txtBtaste.Text,
                    Bnote =txtBnote.Text,
                    BiPrice = Convert.ToInt32(txtNumber.Text)*Convert.ToInt32(txtPrice.Text),
                    Btime = DateTime.Now.ToString(),
                };
                //添加账单
                n = BillStorageManaher.GetBillAdd(pi);
            
            if (n > 0)
            {
                MessageBox.Show("下单成功！");
            }
            else
            {
                MessageBox.Show("下单失败");
            }

            #region MyRegion

            //if (pdf.Count == 0)
            //{
            //numbers++;

            ////获取菜品名
            //string storName = cboDishes.Text;



            //if (pdf.Count == 0)
            //{
            //    //调用加载方法传输数据
            //    OrderAdd(storName);
            //}
            //else
            //{
            //    foreach (var item in pdf)
            //    {
            //        if (item.name == storName)
            //        {

            //            MessageBox.Show(pdf.Count + "");
            //            MessageBox.Show("hello,又是我");

            //        }
            //        else
            //        {
            //            MessageBox.Show("我第一次添加喔！");
            //            OrderAdd(storName);
            //        }
            //    }
            //}
            //}
            //else
            //{
            //    //PlaceorderInfo p = new PlaceorderInfo();
            //    //存储新添加的菜名
            //    string name = cboDishes.Text;
            //    //循环进集合中的数据
            //    foreach (var item in pdf)
            //    {
            //        //如果有相同的菜名
            //        if (item.name == name)
            //        {
            //            //将数量加1
            //            //item.MeNumber += 1;
            //            item.MeNumber += Convert.ToInt32(name);
            //        }
            //        else
            //        {
            //            //获取菜品名
            //            //string storName = cboDishes.Text;
            //            //调用加载方法传输数据
            //            //OrderAdd(storName);
            //        }
            //    }
            //    //重新添加
            //    //pdf.Add(p);
            //} 
            #endregion

        }
        #endregion

        #region 检查菜名是否存在
        /// <summary>
        /// 检查菜名是否存在
        /// </summary>
        /// <returns></returns>
        public string Judge()
        {
            List<PlaceorderInfo> plf = BillStorageManaher.SelectAllPlaceInfo(FrmValues.Bnumber);
            //获取菜品名
            string MeName = cboDishes.Text;
            //循环遍历已经添加过的数据
            string ass = "";
            foreach (var item in plf)
            {

                //判断是否有相同的菜名
                if (MeName == item.MeName)
                {
                    ass = "已存在";
                }
                else
                {
                    ass = "没有";
                }
            }
            return ass;
        }
        #endregion

        #region 动态添加控件
        /// <summary>
        /// 动态添加控件 #endregion 
        /// </summary>
        public void DynamicAdd(List<PlaceorderInfo> plf)
        {
            //查看panel框中所有控件
            number = 0;
            //存储控件个数
            numbers = 0;
            //每个leabl的位置
            a = 20;
            b = 20;
            c = 20;
            d = 20;
            ar = 20;
            foreach (Control item in this.FlpPan.Controls)
            {
                if (item.Name == "FlpPans")
                {
                    #region 加载控件
                    //清空所有控件
                    FlpPans.Controls.Clear();

                    //循环存储查出的数据
                    foreach (var str in plf)
                    {
                        numbers++;
                        //创建菜品名label框
                        Label l1 = new Label();
                        //设置名字
                        l1.Name = "lb" + number;
                        //给lb赋值
                        l1.Text = str.MeName;
                        //设置lb相关的属性
                        l1.Size = new Size(100, 20);
                        if (numbers == 1)
                        {
                            //lb位置
                            l1.Location = new Point(20, 20);
                        }
                        else
                        {
                            //lb位置
                            l1.Location = new Point(18, 20 + 40);
                        }
                        //调用 lb
                        item.Controls.Add(l1);
                        //添加点击事件
                        l1.Click += new EventHandler(Click_Dynamiclick);
                        number++;


                        //创建口味label框
                        Label l2 = new Label();
                        //设置名字
                        l2.Name = "lb" + number;
                        //给lb赋值
                        l2.Text = str.Btaste;
                        //设置lb相关的属性
                        l2.Size = new Size(45, 20);
                        if (numbers == 1)
                        {
                            //lb位置
                            l2.Location = new Point(130, 20);
                        }
                        else
                        {
                            //lb位置
                            l2.Location = new Point(130, b += 40);
                        }

                        //调用 lb
                        item.Controls.Add(l2);
                        number++;




                        //创建备注label框
                        Label l3 = new Label();
                        //设置名字
                        l3.Name = "lb" + number;
                        //给lb赋值
                        l3.Text = str.Bnote;
                        //设置lb相关的属性
                        l3.Size = new Size(200, 20);
                        if (numbers == 1)
                        {
                            //lb位置
                            l3.Location = new Point(250, 20);
                        }
                        else
                        {
                            //lb位置
                            l3.Location = new Point(250, c += 40);
                        }

                        //调用 lb
                        item.Controls.Add(l3);
                        number++;



                        //创建数量label框
                        Label l4 = new Label();
                        //设置名字
                        l4.Name = "lb" + number;
                        //给lb赋值
                        l4.Text = str.MeNumber.ToString();
                        //设置lb相关的属性
                        l4.Size = new Size(50, 20);
                        if (numbers == 1)
                        {
                            //lb位置
                            l4.Location = new Point(450, 20);
                        }
                        else
                        {
                            //lb位置
                            l4.Location = new Point(450, d += 40);
                        }

                        //调用 lb
                        item.Controls.Add(l4);
                        number++;



                        //创建金额label框
                        Label l5 = new Label();
                        //设置名字
                        l5.Name = "lb" + number;
                        //给lb赋值
                        l5.Text = str.BiPrice.ToString();
                        //设置lb相关的属性
                        l5.Size = new Size(25, 10);
                        if (numbers == 1)
                        {
                            //lb位置
                            l5.Location = new Point(570, 20);
                        }
                        else
                        {
                            //lb位置
                            l5.Location = new Point(570, ar += 40);
                        }
                        //调用 lb
                        item.Controls.Add(l5);
                        number++;

                        //列名横线
                        Panel p1 = new Panel();
                        p1.Size = new Size(570, 1);                 //大小
                        p1.BorderStyle = BorderStyle.FixedSingle;   //外观
                        if (numbers == 1)
                        {
                            p1.Location = new Point(20, 40);            //位置
                        }
                        else
                        {
                            p1.Location = new Point(20, 40 * numbers);  //位置
                        }
                        item.Controls.Add(p1);                    //添加

                        //计算金额
                        money += Convert.ToInt32(l5.Text);
                        lbPric.Text = "总金额：" + money.ToString();
                    }
                    #endregion


                }
            }



        }
        #endregion

        #region 菜名点击事件方法
        /// <summary>
        /// 绑定于动态加载控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Dynamiclick(object sender, EventArgs e)
        {
            //获取菜名
            Label lb = (Label)sender;
            MeName = lb.Text;

        }
        #endregion

        #region 刷新事件方法
        /// <summary>
        /// 下单事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            List<PlaceorderInfo> plf = BillStorageManaher.SelectAllPlaceInfo(FrmValues.Bnumber);
            DynamicAdd(plf);
        }
        #endregion

        #region 下拉框选择值
        /// <summary>
        /// 下拉框选择值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string arr = cboDishes.Text;
            //获取选中的数据
            List<StorageInfo> fit = FrontDeskManager.SelectStorNameQuery(arr);
            //循环遍历把金额输出
            foreach (var item in fit)
            {
                txtPrice.Text = item.MePrice.ToString();
            }

        }
        #endregion

        #region 选择菜品类型更换菜品事件方法
        /// <summary>
        /// 选择菜品类型更换菜品事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int arr = cboType.SelectedIndex + 1;
            //获取选中的数据
            cboDishes.DataSource = FrontDeskManager.SelectStoraheQuery(arr);
            cboDishes.DisplayMember = "MeName";
            cboDishes.ValueMember = "MeId";

        }
        #endregion

        #region 删除事件方法
        /// <summary>
        ///删除事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelect_Click(object sender, EventArgs e)
        {
            //提示是否删除
            DialogResult ret = MessageBox.Show("确定删除吗？", "删除提醒"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //执行删除语句
            if (DialogResult.Yes == ret)
            {
                int n = BillStorageManaher.DeleteBill(txtRid.Text, MeName);
                if (n > 0)
                {
                    
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }

        }

        #endregion

    }
}
