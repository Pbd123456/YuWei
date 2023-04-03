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


    public partial class FrmMain : Form
    {


        //存储图片
        PictureBox ab = null;
        //存储图片名
        string ac = "";
        //存储预约人数

        //获取dbug中的图片
        Image imag = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "包房(绿色).png");
        Image imag1 = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "包房(红色).png");
        Image imag2 = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "茶几(红色).png");
        Image imag3 = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "茶几(绿色).png");
       // Image min = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "最小化.png");
        Image imag5 = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "茶几(蓝色).png");
        Image imag6 = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "包房(蓝色).png");
        //Image max = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "最大化2.png");
        //Image colse = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "叉号.png");

        //存储剩余可用的包间或者桌号
        int number = 33;
        //存储已经使用的包间
        int number1 = 0;
        //存储用户名
        string uid = FromLogin.uid;
        public static int a { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 加载事件方法
        /// <summary>
        /// 加载事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //给用户名赋值
            lbNmae.Text = uid;
            //存储用户名
            FrmValues.loginName = lbNmae.Text;


            //开启定时器
            lbDate.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;


            //老版本桌号
            #region 老版本桌号
            //循环将panle中的图片换成空
            //foreach (Control a in this.panPic.Controls)
            //    {
            //        if (a is PictureBox)
            //        {
            //            if (a.Name.Contains ("picB"))
            //            {
            //                a.BackgroundImage = imag3;
            //                a.BackgroundImageLayout = ImageLayout.Stretch;
            //            }
            //            if (a.Name.Contains("picZ"))
            //            {
            //                a.BackgroundImage = imag;
            //                a.BackgroundImageLayout = ImageLayout.Stretch;

            //            }
            //        }
            //    } 
            #endregion

            //设置右上角图片
            // picMin.BackgroundImage = min;
            //picClose.BackgroundImage = colse;
    

            //右下角剩余
            lbEmaining.Text = "剩余：" + number;
            lbHave.Text = "已使用：" + number1;

            //加载桌号
            LoadRamadhin();
        }
        #endregion

        #region 加载桌号
        /// <summary>
        /// 加载桌号
        /// </summary>
        public void LoadRamadhin()
        {

            List<Ramadhin> ri = StorageManager.RamadhinInfo();
            int i = 1;
            int b = 1;
            int c = 1;
            foreach (var a in ri)
            {
                //panel框
                Panel p1 = new Panel();
                p1.Size = new Size(79, 100);
                p1.Name = "pan" + a;
                p1.Location = new Point(0, 0);
                p1.BorderStyle = BorderStyle.None;        
                panPic.Controls.Add(p1);
                i += 1;

                //图片
                PictureBox pic = new PictureBox();
                pic.Name = "picZ" + b;                      //名字
                pic.Size = new Size(75, 75);                //大小
                pic.SizeMode = PictureBoxSizeMode.Zoom;     //图像自适应
                pic.Cursor = Cursors.Hand;                  //悬停样式
                pic.BorderStyle = BorderStyle.None;         //图片无边框
                pic.Click += new EventHandler(Pic_Click);
                p1.Controls.Add(pic);
                b += 1;

                if (a.Rtate == "空")
                {
                    pic.Image = imag3;
                }
                else if (a.Rtate == "有人")
                {
                    pic.Image = imag2;
                }
                else if (a.Rtate == "预定")
                {
                    pic.Image = imag5;
                }

                Label lb = new Label();
                //给lb取名
                lb.Name = "lb" + c;
                //设置lb相关的属性
                lb.Size = new Size(50, 40);
                lb.Location = new Point(20,80);
                //给lb赋值
                lb.Text = a.Radhin;
                lb.Click += new EventHandler(Pic_Click);
                p1.Controls.Add(lb);
                c += 1;

                #region MyRegion
                //// 创建图片框
                //PictureBox pic = new PictureBox();
                //pic.Name = "picZ" + b;                      //名字
                //pic.Size = new Size(50, 50);                //大小
                //pic.BorderStyle = BorderStyle.FixedSingle;  //变宽样式
                //pic.Location = new Point(i * 80, 10);       //位置
                //pic.SizeMode = PictureBoxSizeMode.Zoom;     //图像自适应
                //pic.Cursor = Cursors.Hand;                  //悬停样式
                //pic.BorderStyle = BorderStyle.None;         //图片无边框
                //pic.Click += new EventHandler(Pic_Click);
                //b += 1;
                ////创建labl
                //Label l1 = new Label();
                ////给lb取名
                //l1.Name = "lb" + b;
                ////设置lb相关的属性
                //l1.Size = new Size(30, 30);
                ////给lb赋值
                //l1.Text = a.Radhin;
                //l1.Click += new EventHandler(Pic_Click);

                //if (i >= 1 && i <= 11)
                //{
                //    //添加控件
                //    panPic.Controls.Add(pic);
                //    //判断状态
                //    if (a.Rtate == "空")
                //    {
                //        pic.Image = imag3;
                //    }
                //    else if (a.Rtate == "有人")
                //    {
                //        pic.Image = imag2;
                //    }
                //    else if (a.Rtate == "预定")
                //    {
                //        pic.Image = imag5;
                //    }
                //    //名字位置
                //    l1.Location = new Point(i * 82, 80);
                //    //添加lb控件
                //    panPic.Controls.Add(l1);
                //}


                ////循环输出图片和桌号
                //if (i > 11 && i <= 22)
                //{
                //    //名字位置
                //    l1.Location = new Point(u * 81, 220);
                //    //添加lb控件
                //    panPic.Controls.Add(l1);
                //    //图片位置
                //    pic.Location = new Point(u * 80, 150);
                //    //添加图片控件
                //    panPic.Controls.Add(pic);
                //    //判断状态
                //    if (a.Rtate == "空")
                //    {
                //        pic.Image = imag3;
                //    }
                //    else if (a.Rtate == "有人")
                //    {
                //        pic.Image = imag2;
                //    }
                //    else if (a.Rtate == "预定")
                //    {
                //        pic.Image = imag5;
                //    }

                //    u++;
                //}
                //if (i >= 23 && i < 34)
                //{
                //    //包间换名字
                //    pic.Name = "picP" + i;
                //    //包间位置变大
                //    l1.Size = new Size(45, 30);
                //    //名字位置
                //    l1.Location = new Point(c * 81, 350);
                //    //添加lb控件
                //    panPic.Controls.Add(l1);
                //    //给lb赋值
                //    l1.Text = a.Radhin;
                //    //图片位置
                //    pic.Location = new Point(c * 80, 280);
                //    //添加图片控件
                //    panPic.Controls.Add(pic);

                //    //给图片赋值
                //    if (a.Rtate == "空")
                //    {
                //        pic.Image = imag;
                //    }
                //    else if (a.Rtate == "有人")
                //    {
                //        pic.Image = imag1;
                //    }
                //    else if (a.Rtate == "预定")
                //    {
                //        pic.BackColor = Color.Black;
                //    }

                //    pic.Image = imag;
                //    c++;
                //}
                //i++; 
                #endregion
            }
        }

        #endregion

        #region 点击获取名称事件方法
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pic_Click(object sender, EventArgs e)
        {
            //获取当前点击的桌号或者包房
            //截取它最后一位字符
            //循环picpic中所有panel框控件
            //在循环panel中所有控件
            //查找名字为lb开头的文本
            PictureBox pic = (PictureBox)sender;
            ab = pic;
            ac = pic.Name;
            foreach (Control item in this.panPic.Controls)
            {
                if (item is Panel)
                {
                    foreach (Control item1 in item.Controls)
                    {
                        if (item1.Name == ac)
                        {
                            foreach (Control item2 in item.Controls)
                            {
                                if (item2.Name.StartsWith("lb"))
                                {
                                   FrmValues.ramadhin = item2.Text;
                                   
                                }
                            }
                        }
                    }
                }
            }
            //MessageBox.Show(Ramadhin);
            //.Ramadhin = Ramadhin;


        }
        #endregion

        #region 开台事件方法
        /// <summary>
        /// 开台时间方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //将图片切换成红色的
            try
            {
                string arr = ac.Substring(5 - 2, 1);
                if (arr == "Z")
                {
                    ab.Image = imag2;
                   
                }
                else
                {
                    ab.Image = imag1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("点击图片选择包房或者桌号！");
            }
            //查询所有单号，获取总数
            List<FdisTypeInfo> ft = BillStorageManaher.SelectFidsType();
            int nid = ft.Count;
            string Bnumber = "No.0000" + nid + 1;
            //创建单号
            int n = BillStorageManaher.GetNumberInfoAdd(Bnumber, 0);
            //存储单号
            FrmValues.Bnumber = nid + 1;
            //剩余开台数
            number--;
            lbEmaining.Text = "剩余：" + number;
            //已使用数
            number1++;
            lbHave.Text = "已使用：" + number1;
        }
        #endregion

        #region 结账事件方法
        /// <summary>
        /// 结账事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            #region 结账事件方法
            ////回归到空
            //string arr = ac.Substring(5 - 2, 1);

            //if (arr == "Z")
            //{
            //    ab.BackgroundImage = imag;
            //}
            //else
            //{
            //    ab.BackgroundImage = imag3;
            //}
            ////剩余开台数
            //number++;
            //lbEmaining.Text = "剩余：" + number;
            ////已使用数
            //number1--;
            //lbHave.Text = "已使用：" + number1;
            //将图片切换成红色的 
            #endregion

            //获取单号所有菜品

            #region 将图片换为绿色

            try
            {
                string arr = ac.Substring(5 - 2, 1);
                if (arr == "Z")
                {
                    ab.Image = imag3;
                }
                else
                {
                    ab.Image = imag1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("点击图片选择包房或者桌号！");
            }
            #endregion
        }
        #endregion

        #region 定时器事件方法
        /// <summary>
        /// 定时器事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //设置当前时间
            lbDate.Text = "当前时间：" + DateTime.Now.ToString();
        }
        #endregion

        #region 预定事件方法
        /// <summary>
        /// 预定事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntReserva_Click(object sender, EventArgs e)
        {
            try
            {
                string arr = ac.Substring(5 - 2, 1);
                if (arr == "Z")
                {
                    ab.Image = imag5;
                }
                else
                {
                    ab.Image = imag6;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("点击图片选择包房或者桌号！");
            }
        }
        #endregion

        #region 查看菜单事件方法
        /// <summary>
        /// 查看菜单事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string arr = ac.Substring(5 - 2, 1);
                string acc = ac.Substring(5 - 1, 1);
                string ar = "";
                if (arr == "Z")
                {
                    ar = "包房" + acc;
                }
                else
                {
                    ar = "桌号" + acc;
                }
                //切换窗体
                FrmOrder frm = new FrmOrder();
                frm.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("请选择卓号");
            }
          
        }
        #endregion

        #region 点单事件方法
        /// <summary>
        /// 点单事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntOrder_Click(object sender, EventArgs e)
        {
            FrmPlaceOrder frm = new FrmPlaceOrder();
            frm.Show();
        }
        #endregion
    }
}
