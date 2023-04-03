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
using System.IO;
using System.Drawing.Drawing2D;

namespace LingFragSystem
{
    public partial class FrmOrder : Form
    {

        //存菜品数量
        int number = 1;
        //存控件数量
        int art = 0;
        //存储点击次数
        int its = 0;
        //计算总金额
        int price = 0;
        public FrmOrder()
        {
            InitializeComponent();
        }


        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOrder_Load(object sender, EventArgs e)
        {

            //获取所有数据
            List<StorageInfo> sif = FrontDeskManager.StoraheInfoQuery();
            Loads(sif);//加载菜单框

            //获取当前登录名赋值再lbname中
            lbName.Text = "登录名:" + FrmValues.loginName;
        }
        #endregion

        #region 加载事菜单件方法
        /// <summary>
        /// 加载事菜单件方法
        /// </summary>
        public void Loads(List<StorageInfo> sif)
        {
            fiPicInfo.Controls.Clear();
            number++;
            //声明字节数组
            byte[] imageByte;
            foreach (var a in sif)
            {
                //将字节存储在字节数组中
                imageByte = a.MPicture;
                //转换为文件流
                MemoryStream ms = new MemoryStream(imageByte);
                //将文件流转换为图片
                Image _iamg = Image.FromStream(ms);
                //将图片赋在图片框中
                //pic1.Image = _iamg;
                art++;
                //图片

                #region 添加图片
                ////判断是否为图片
                //if (b is PictureBox)
                //{
                //    if (b.Name == "pic" + ar)
                //    {
                //        //给图片框赋图片
                //        b.BackgroundImage = _iamg;
                //        //自适应大小
                //        b.BackgroundImageLayout = ImageLayout.Stretch;

                //        ar++;
                //        break;
                //    }
                //}
                #endregion
                #region  循环查询panle中的图片
                //foreach (Control b in this.plPic.Controls)
                //{
                //    //图片编号
                //    if (b is PictureBox)
                //    {
                //        foreach (Control a2 in this.plPic.Controls)
                //        {
                //            if (a2 is PictureBox)
                //            {
                //                if (a2.Name == "pic" + ar)
                //                {
                //                    a2.BackgroundImage = _iamg;
                //                    a2.BackgroundImageLayout = ImageLayout.Stretch;
                //                    ar++;
                //                    break;
                //                }
                //            }
                //        }
                //    }
                //}

                #endregion


                //添加空隙
                Panel p2 = new Panel();
                p2.Size = new Size(40, 150);
                p2.BorderStyle = BorderStyle.None;
                this.fiPicInfo.Controls.Add(p2);

                //添加panle框
                Panel p1 = new Panel();
                p1.Size = new Size(150, 150);
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Name = "pan" + art;
                this.fiPicInfo.Controls.Add(p1);
                art++;

                //设置图片对象
                PictureBox pic = new PictureBox();
                //设置图像相关的属性
                pic.Width = 130;                            //宽度
                pic.Height = 90;                             //高度
                pic.Name = "pic" + art;                     //控件名
                pic.Location = new Point(10, 10);            //位置
                pic.BorderStyle = BorderStyle.FixedSingle;  //变宽样式
                pic.SizeMode = PictureBoxSizeMode.StretchImage;     //图像自适应
                pic.Cursor = Cursors.Hand;                  //悬停样式
                pic.Image = _iamg;                          //添加图片
                p1.Controls.Add(pic);
                pic.DoubleClick += new EventHandler(Pic_Click);
                art++;

                //创建名字对象
                Label lbName = new Label();
                lbName.Name = "lb" + art;
                lbName.Size = new Size(110, 15);
                lbName.Location = new Point(10, 110);
                lbName.Text = "名称：" + a.MeName;
                p1.Controls.Add(lbName);



                //创建价格对象
                Label lbPric = new Label();
                lbPric.Name = "pric" + art;
                lbPric.Size = new Size(90, 70);
                lbPric.Location = new Point(10, 130);
                lbPric.Text = "价格：" + a.MePrice;
                p1.Controls.Add(lbPric);


                //创建添加购物车
                Button btnAdd = new Button();
                btnAdd.Size = new Size(40, 20);
                btnAdd.Name = "btn" + art;
                btnAdd.Text = "添加";
                btnAdd.Location = new Point(100, 125);
                btnAdd.Click += new EventHandler(BtnAdd_Click);
                p1.Controls.Add(btnAdd);
                number++;

                #region 老版本查看商品
                //    //添加label
                //    for (int i = 0; i < 2; i++)
                //    {
                //        //设置lb对象
                //        Label lb = new Label();
                //        lb.Name = "lb" + i;
                //        if (i == 0)
                //        {
                //            lb.Text = "名称：" + a.MeName;
                //            //设置lb相关的属性
                //            lb.Size = new Size(105, 20);

                //            lb.Location = new Point(20, 128);
                //            //调用 lb
                //            p1.Controls.Add(lb);
                //        }
                //        if (i == 1)
                //        {
                //            lb.Text = "价格：" + a.MePrice.ToString();
                //            //设置lb相关的属性
                //            lb.Size = new Size(90, 20);

                //            lb.Location = new Point(150, 128);
                //            //调用 lb
                //            p1.Controls.Add(lb);
                //        }

                //    }

                //    Button bt = new Button();
                //    bt.Name = "bt" + a.MeName;
                //    bt.Text = "-";
                //    bt.Width = 20;
                //    bt.Height = 20;
                //    bt.Location = new Point(50, 148);
                //    //绑定点击事件
                //    bt.Click += new EventHandler(c1_Click);
                //    //添加进planle框中
                //    p1.Controls.Add(bt);


                //    //设置数量
                //    Label lb2 = new Label();
                //    lb2.Name = "btlb" + a.MeName;
                //    lb2.Text = number.ToString();
                //    lb2.Size = new Size(30, 20);
                //    //设置lb相关的属性
                //    lb2.Location = new Point(100, 153);
                //    p1.Controls.Add(lb2);

                //    Button bt2 = new Button();
                //    bt2.Name = "bt" + a.MeName;
                //    bt2.Text = "+";
                //    bt2.Width = 20;
                //    bt2.Height = 20;
                //    bt2.Location = new Point(140, 148);
                //    //绑定点击事件
                //    bt2.Click += new EventHandler(c1_Click);
                //    p1.Controls.Add(bt2);

                //    //将图片框放进容器中
                //    p1.Controls.Add(pic);
                //    pic.BackgroundImage = _iamg;
                //    p1.Tag = a.MeName;
                //    ar++;
                //    //自适应大小
                //    pic.BackgroundImageLayout = ImageLayout.Stretch;

                //} 
                #endregion

            }
        }


        #endregion

        #region 图片点击事件
        /// <summary>
        /// 图片点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox ps = (PictureBox)sender;
            foreach (Control item in fiPicInfo.Controls)
            {//循环fipicinfo中所有控件
                if (item is Panel)
                {//循环所有的panel框
                    foreach (Control item1 in item.Controls)
                    {//循环panel中的所有控件
                        if (item1 is PictureBox)
                        {//循环所有的图片框
                            if (item1.Name == ps.Name)
                            {//查找跟读取出来的图片框一样的框名
                                foreach (Control item2 in item.Controls)
                                {//再次循环panel中的所有控件
                                    if (item2 is Label)
                                    {//查找所有的lebel控件
                                        if (item2.Name.StartsWith("lb"))
                                        {//查找以lb开头的控件名
                                         //保存控件名
                                            string a = item2.Text;
                                            //截取菜名
                                            string arr = a.Remove(0, 3);
                                            FrmValues.MeName = arr;
                                            //查看详情窗口
                                            FrmChooseFlavor frm = new FrmChooseFlavor();
                                            frm.Show();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        #endregion

        #region 点击增加事件 （作废）
        /// <summary>
        /// 点击增加事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c1_Click(object sender, EventArgs e)
        {
            //获取按钮名称
            Button btn = (Button)sender;
            string str = btn.Name.Substring(2);
            //循环所有控件
            foreach (var item in fiPicInfo.Controls)
            {
                //筛选所有panel框
                if (item is Panel pl)
                {
                    foreach (var item2 in pl.Controls)  //循环panel框中所有控件
                    {
                        if (item2 is Label lb)          //筛选所有label控件
                        {
                            if (lb.Name == "btlb" + str)   //筛选名字相等的
                            {
                                if (btn.Text == "+")        //判断是加号还是减号
                                {
                                    lb.Text = (Convert.ToInt32(lb.Text) + 1) + "";//将数量加1
                                    // 将数量赋值到numer中
                                    number = Convert.ToInt32(lb.Text);
                                }
                                else
                                {
                                    //判断数量是等于0，如果等于就退出循环
                                    if (lb.Text == "0")
                                    {
                                        lb.Text = "0";
                                        break;
                                    }
                                    lb.Text = (Convert.ToInt32(lb.Text) - 1) + "";
                                    number = Convert.ToInt32(lb.Text);
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region 更换热销菜品事件
        /// <summary>
        /// 更换热销菜品事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 更换图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开初始化文件对话框
            OpenFileDialog ofdlgTest = new OpenFileDialog();
            //文件过滤
            ofdlgTest.Filter = "*.png|*.jpg";
            //设置不可以选择多个文件
            ofdlgTest.Multiselect = false;

            //显示打开对话框
            DialogResult result = ofdlgTest.ShowDialog();
            //将文件名显示到文本框
            if (result == DialogResult.OK)  //判断是否打开
            {
                //picsellnot.Image = Image.FromFile(ofdlgTest.FileName);
            }

        }
        #endregion

        #region 返回主界面事件
        /// <summary>
        ///返回主界面事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReate_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();

        }
        #endregion

        #region 家常类型方法事件
        /// <summary>
        /// 家常类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDaily_Click(object sender, EventArgs e)
        {
            //点击左边类型，刷新菜单
            Button bt = (Button)sender;
            List<StorageInfo> sti = FrontDeskManager.SelectStorageInfo(bt.Text);
            Loads(sti);

        }
        #endregion

        #region 菜品添加事件方法
        /// <summary>
        /// 菜品添加事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //获取按钮名字
            Button btn = (Button)sender;
            //判断添加的哪个菜品
            foreach (Control item in this.fiPicInfo.Controls)
            {
                if (item is Panel)
                {
                    foreach (Control item1 in item.Controls)
                    {
                        if (item1 is Button)
                        {
                            if (item1.Name == btn.Name)
                            {
                                foreach (Control item2 in item.Controls)
                                {
                                    if (item2 is Label)
                                    {//查找所有的lebel控件
                                        if (item2.Name.StartsWith("lb"))
                                        {//查找以lb开头的控件名
                                            //保存控件名
                                            string a = item2.Text;
                                            //截取菜名
                                            string arr = a.Remove(0, 3);
                                            //存储菜品名
                                            FrmValues.MeName = arr;
                                            //切换输出窗体
                                            FrmOrderAdd frm = new FrmOrderAdd();
                                            frm.Show();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region 查看菜品
        /// <summary>
        /// 查看菜品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label14_Click(object sender, EventArgs e)
        {

            //获取查看已点名称
            Label lb = (Label)sender;
            //获取金额

            if (its % 2 == 0)
            {
                //已点框大小
                plHave.Size = new Size(852, 400);
                //已点框位置
                plHave.Location = new Point(239, 236);
                //将已点框设置为最上层
                plHave.BringToFront();
                //已点框文本
                lb.Text = "点击返回";
                //已点框按钮位置
                its++;
                this.plHave.Controls.Clear();
                StorskAdd();
            }
            else
            {
                plHave.Size = new Size(852, 36);
                plHave.Location = new Point(239, 600);
                lb.Text = "查看已点";
                its++;
            }
        }
        #endregion

        #region 已选菜单框方法
        /// <summary>
        /// 已选菜单框方法
        /// </summary>
        public void StorskAdd()
        {

            //存储隔行位置
            int a = 0;
            //存储控件位置
            int b = 0;
            int c = 0;
            int d = 0;
            int f = 0;
            int j = 0;
            int k = 0;
            int r = 0;
            //存储控件名字
            int i = 1;
            //存储图片字节
            byte[] images;
            //清空已点框控件

            //添加panel
            Panel pan = new Panel();
            pan.Name = "pan" + i;
            pan.Size = new Size(700, 300);
            pan.Location = new Point(85, 50);
            pan.BorderStyle = BorderStyle.FixedSingle;
            this.plHave.Controls.Add(pan);

            //添加查看菜品
            Label lcr = new Label();
            lcr.Name = "label14";
            lcr.Text = "点击返回";
            lcr.Size = new Size(70, 50);
            lcr.Location = new Point(359, 12);
            lcr.Click += new EventHandler(label14_Click);
            this.plHave.Controls.Add(lcr);


            //给框中添加数据
            foreach (var item in FrmValues.MeList)
            {
                b++;
                //将图片存储在字节数组中
                images = item.BtPric;
                //将图片数组转换为文件流
                MemoryStream ms = new MemoryStream(images);
                //将文件流转换为图片
                Image _imag = Image.FromStream(ms);

                #region 标题
                if (i == 1)
                {
                    //画标题
                    //图片
                    Label lbPic = new Label();
                    lbPic.Name = "pic" + i;
                    lbPic.Text = "菜品图片";
                    lbPic.Size = new Size(90, 20);
                    lbPic.Location = new Point(50, 5);
                    pan.Controls.Add(lbPic);

                    //菜名
                    Label lbNmae = new Label();
                    lbNmae.Name = "lbNmae" + i;
                    lbNmae.Text = "菜品名称";
                    lbNmae.Size = new Size(50, 20);
                    lbNmae.Location = new Point(180, 5);
                    pan.Controls.Add(lbNmae);

                    //口味
                    Label lbBtaste = new Label();
                    lbBtaste.Name = "lbBtaste" + i;
                    lbBtaste.Text = "口味";
                    lbBtaste.Size = new Size(40, 20);
                    lbBtaste.Location = new Point(275, 5);
                    pan.Controls.Add(lbBtaste);

                    //数量
                    Label lbNmuber = new Label();
                    lbNmuber.Name = "lbNmuber" + i;
                    lbNmuber.Text = "数量";
                    lbNmuber.Size = new Size(50, 20);
                    lbNmuber.Location = new Point(360, 5);
                    pan.Controls.Add(lbNmuber);


                    //金额
                    Label lbPrice = new Label();
                    lbPrice.Name = "lbNmae" + i;
                    lbPrice.Text = "金额";
                    lbPrice.Size = new Size(50, 20);
                    lbPrice.Location = new Point(430, 5);
                    pan.Controls.Add(lbPrice);

                    //备注
                    Label lbBnote = new Label();
                    lbBnote.Name = "lbNmae" + i;
                    lbBnote.Text = "备注";
                    lbBnote.Size = new Size(50, 20);
                    lbBnote.Location = new Point(500, 5);
                    pan.Controls.Add(lbBnote);
                }
                #endregion

                //画图片框
                PictureBox picStore = new PictureBox();
                picStore.Name = "pic" + i;
                picStore.Image = _imag;
                picStore.Size = new Size(70, 40);
                if (b == 1)
                {
                    picStore.Location = new Point(50, r += 35);
                }
                else
                {
                    picStore.Location = new Point(50, r += 75);
                }
                picStore.BorderStyle = BorderStyle.FixedSingle;
                picStore.SizeMode = PictureBoxSizeMode.StretchImage;
                pan.Controls.Add(picStore);

                //名称
                Label lb = new Label();
                lb.Name = "lbName" + i;
                lb.Size = new Size(60, 20);
                if (b == 1)
                {
                    lb.Location = new Point(178, c += 50);
                }
                else
                {
                    lb.Location = new Point(178, c += 75);

                }
                lb.Text = item.MeName;
                pan.Controls.Add(lb);

                //口味
                Label lb2 = new Label();
                lb2.Name = "lbTaste" + i;
                lb2.Size = new Size(60, 20);
                if (b == 1)
                {
                    lb2.Location = new Point(273, d += 50);
                }
                else
                {
                    lb2.Location = new Point(273, d += 75);
                }
                lb2.Text = item.Btaste;
                pan.Controls.Add(lb2);


                //数量
                Label lb3 = new Label();
                lb3.Name = "lbNumber" + i;
                lb3.Size = new Size(60, 20);
                if (b == 1)
                {

                    lb3.Location = new Point(370, f += 50);
                }
                else
                {
                    lb3.Location = new Point(370, f += 75);
                }
                lb3.Text = item.MeNumber.ToString();
                pan.Controls.Add(lb3);


                //金额
                Label lb4 = new Label();
                lb4.Name = "lbPrice" + i;
                lb4.Size = new Size(60, 20);
                if (b == 1)
                {
                    lb4.Location = new Point(430, j += 50);
                }
                else
                {
                    lb4.Location = new Point(430, j += 75);
                }
                lb4.Text = item.BiPrice.ToString();
                pan.Controls.Add(lb4);

                //备注
                Label lb5 = new Label();
                lb5.Name = "lbBnote" + i;
                lb5.Size = new Size(60, 20);
                if (b == 1)
                {
                    lb5.Location = new Point(500, k += 50);
                }
                else
                {
                    lb5.Location = new Point(500, k += 75);
                }
                lb5.Text = item.Bnote;
                pan.Controls.Add(lb5);


                //隔行线
                Panel pan1 = new Panel();
                pan1.Name = "pang" + i;
                pan1.Size = new Size(650, 1);
                if (b == 1)
                {
                    pan1.Location = new Point(25, a += 85);
                }
                else
                {
                    pan1.Location = new Point(25, a += 75);
                }
                pan1.BorderStyle = BorderStyle.FixedSingle;
                pan.Controls.Add(pan1);
                i++;

                price += item.BiPrice;
            }
            pan.AutoScroll = true;
            //计算总金额
            Label MePrice = new Label();
            MePrice.Name = "Prices";
            MePrice.Text = "一共：" + price + " 元";
            MePrice.Size = new Size(70, 12);
            MePrice.Location = new Point(650, 370);
            this.plHave.Controls.Add(MePrice);


            //下单按钮
            Button btnAdds = new Button();
            btnAdds.Name = "btnAdds";
            btnAdds.Text = "下单";
            btnAdds.Size = new Size(75, 23);
            btnAdds.Location = new Point(751, 365);
            btnAdds.Click += new EventHandler(Add_Click);
            this.plHave.Controls.Add(btnAdds);
        }

        #endregion

        #region 下单事件方法
        /// <summary>
        /// 下单事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            #region 老版添加
            //根据桌号id查询账单编号，根据账单编号查询订单状态
            ////存储订单id
            //int id = 0;
            //int n = 0;
            ////根据桌号查询数据
            //List<PlaceorderInfo> pl = BillStorageManaher.SelectBillStoraheInfo(FrmValues.ramadhin);

            //MessageBox.Show(pl.Count+"");
            ////循环出订单id
            //foreach (var item in pl)
            //{
            //    MessageBox.Show("44");
            //    id = item.Nid;
            //    //根据订单id查询订单状态
            //    List<FdisTypeInfo> fti = BillStorageManaher.SelectFidsTypeInfo(id);
            //    if (fti.Count ==0)
            //    {
            //        //查询所有单号，获取总数
            //        List<FdisTypeInfo> ft = BillStorageManaher.SelectFidsType();
            //        int nid = ft.Count;
            //        //创建单号
            //        n = BillStorageManaher.GetNumberInfoAdd("No.0000" + nid, 0);
            //         if (n > 0)
            //          {
            //                MessageBox.Show("11");
            //                Add(nid);
            //            }
            //    }
            //    else
            //    {
            //        foreach (var sid in fti)
            //        {
            //            MessageBox.Show("33");
            //            //状态为1则已结账重新创建单号
            //            if (sid.Nstate == 1)
            //            {
            //                MessageBox.Show("22");
            //                //查询所有单号，获取总数
            //                List<FdisTypeInfo> ft = BillStorageManaher.SelectFidsType();
            //                int nid = ft.Count;
            //                //创建单号
            //                n = BillStorageManaher.GetNumberInfoAdd("No.0000" + nid, 0);
            //                if (n > 0)
            //                {
            //                    MessageBox.Show("11");
            //                    Add(nid);
            //                }
            //            }
            //            else
            //            {
            //                Add(id);
            //            }
            //        }

            //    }
            //}
            //下单，      
            #endregion

            //添加数据
            Add(FrmValues.Bnumber);

        }
        #endregion

        #region 下单
        /// <summary>
        /// 下单
        /// </summary>
        /// <param name="nid"></param>
        public void Add(int nid)
        {
            int n = 0;
            foreach (var item in FrmValues.MeList)
            {
                PlaceorderInfo pi = new PlaceorderInfo()
                {
                    Radhin = item.Radhin,
                    MeName = item.MeName,
                    MeNumber = item.MeNumber,
                    Btaste = item.Btaste,
                    Bnote = item.Bnote,
                    BiPrice = item.BiPrice,
                    Btime = item.Btime,
                    Nid = nid,
                };
                //添加账单
                n = BillStorageManaher.GetBillAdd(pi);
            }
            if (n > 0)
            {
                MessageBox.Show("下单成功！");
            }
            else
            {
                MessageBox.Show("下单失败");
            }

        }
        #endregion
    }

}
