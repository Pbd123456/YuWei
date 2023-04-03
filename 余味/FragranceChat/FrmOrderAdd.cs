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

namespace LingFragSystem
{
    public partial class FrmOrderAdd : Form
    {
        //存储菜品类型
        public int fId = 0;
        //存储菜品数量
        int number = 0;
        //存储菜品口味
        string btaste ="";
        //存储金额
        int price = 0;
        //存储菜品数量价格
        int priceNumber = 0;
        public FrmOrderAdd()
        {
            InitializeComponent();
        }

        #region 窗体加载事件方法
        /// <summary>
        /// 窗体加载事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOrderAdd_Load(object sender, EventArgs e)
        {
            //调用加载事件
            Storage();

        }
        #endregion

        #region 加载事件
        /// <summary>
        /// 加载事件
        /// </summary>
        public void Storage()
        {
            //获取点击的菜品名
            string meName = FrmValues.MeName;
            //查询菜品图片
            List<StorageInfo> si = FrontDeskManager.SelectStorNameQuery(meName);
            //定义一个字节数组存储图片
            byte[] images;
            foreach (var item in si)
            {
                //将图片存储在字节数组中
                images = item.MPicture;
                //将图片数组转换为文件流
                MemoryStream ms = new MemoryStream(images);
                //将文件流转换为图片
                Image _imag = Image.FromStream(ms);
                //将图片赋值给图片框
                picInfo.Image = _imag;
                //赋值名称
                lbName.Text = "名称：" + item.MeName;
                //价格
                lbPrice.Text = "价格：" + item.MePrice;
                //存储单个菜品价格
                price = Convert.ToInt32(item.MePrice);
                //存储菜品类型
                fId = item.FypeId;
            }
            //判断菜品类型
            ///如果它等于甜品或者糖水类就禁用菜品口味的选择，如果不等于反之
            if (fId == 7)
            {
                foreach (Control item in this.panel3.Controls)
                {
                    if (item is RadioButton)
                    {
                        item.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (Control item in this.panel4.Controls)
                {
                    if (item is RadioButton)
                    {
                        item.Enabled = false;
                    }
                }
            }

        }
        #endregion

        #region 添加事件方法
        /// <summary>
        /// 添加事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (AddInfo())
            {
                //当前时间
                string timea = DateTime.Now.ToString();
                //获取图片将图片转换成字节流
                PlaceorderInfo pl = new PlaceorderInfo();
                pl.Radhin = FrmValues.ramadhin;             //桌号
                pl.MeName = FrmValues.MeName;              //菜名
                pl.MeNumber = Convert.ToInt32(lbNumber.Text);  //数量
                pl.Btaste = btaste;                        //口味
                pl.Bnote = txtBnote.Text;                  //备注
                pl.BiPrice = priceNumber;                  //总金额
                pl.Btime = timea;                          //存储当前时间
                pl.BtPric = imagTobyte(picInfo.Image);     //存储图片
                                                           //创建一个新的list对象
                try
                {
                    //将数据添加进list集合
                    FrmValues.MeList.Add(pl) ;
                    MessageBox.Show("添加成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex.Message);
                }
            }
        }

        #endregion

        #region 加减数量事件
        /// <summary>
        /// 加减数量事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "+")
            {
                number += 1;
                lbNumber.Text = number.ToString();
                priceNumber = price * number;
                lbPric.Text = "价格：" + priceNumber.ToString();
            }
            else if (number == 0)
            {
                number = 0;
            }
            else
            {
                number -= 1;
                lbNumber.Text = number.ToString();
                priceNumber = price * number;
                lbPric.Text = "价格：" + priceNumber.ToString();
            }

        }
        #endregion

        #region 获取选中的菜品口味
        /// <summary>
        /// 获取选中的菜品口味
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            //提示
            if (rb.Text == "其它")
            {
                MessageBox.Show("请记得在备注写上您要的口味！");
            }
            btaste = rb.Text;
        }
        #endregion

        #region 将图片转换成字节流
        /// <summary>
        /// 将图片转换成字节流
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private byte[] imagTobyte(System.Drawing.Image image)
        {

            MemoryStream ms = new MemoryStream();

            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();

        }
        #endregion

        #region 校验事件完整性
        /// <summary>
        /// 校验事件完整性
        /// </summary>
        /// <returns></returns>
        public bool AddInfo()
        {
            if (true)
            {
                if (Convert.ToInt32(lbNumber.Text) == 0)
                {
                    MessageBox.Show("至少选择一件商品才可以添加！");
                    return false;
                }
                if (btaste == "")
                {
                    MessageBox.Show("请您选择一种口味或者勾选其它！");
                    return false;
                }
                return true;
            }
        }

        #endregion
    }
}
