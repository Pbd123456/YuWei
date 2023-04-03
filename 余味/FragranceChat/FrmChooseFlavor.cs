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
    public partial class FrmChooseFlavor : Form
    {
        public FrmChooseFlavor()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmChooseFlavor_Load(object sender, EventArgs e)
        {
            FrmLoad();
            picMes.SizeMode = PictureBoxSizeMode.StretchImage;     //图像自适应
        }
        #endregion

        #region 窗体加载事件方法
        /// <summary>
        /// 窗体加载事件方法
        /// </summary>
        public void FrmLoad()
        {
            //获取选中的名字
            string meName = FrmValues.MeName;
            //根据菜品名查询所有数据
            List<StorageInfo> si = FrontDeskManager.SelectStorNameQuery(meName);
            //声明一个字节数组存储图片
            byte[] images;
            //遍历所有数据
            foreach (var item in si)
            {
                //将字节存储在字节数组中
                images = item.MPicture;
                //将字节数据转换成文件流
                MemoryStream ms = new MemoryStream(images);
                //将文件流转换成图片
                Image _image = Image.FromStream(ms);

                //将数据赋值
                picMes.Image = _image;
                lbMeName.Text = "名称："+item.MeName;
                lbMePric.Text = "价格："+item.MePrice.ToString();
                lbMetaste.Text =item.MeTaste;
                lbMeTerial.Text = item.MeTerial;
                lbMeDetails.Text = item.MeDetails;
                lbMeNumber.Text ="销量："+ item.MeNumber.ToString();
            }

        }
        #endregion

        #region 返回事件方法
        /// <summary>
        /// 返回事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
