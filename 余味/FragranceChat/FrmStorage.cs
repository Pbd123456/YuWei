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
using System.Runtime.Serialization.Formatters.Binary;

namespace LingFragSystem
{
    public partial class FrmStorage : Form
    {
        public FrmStorage()
        {
            InitializeComponent();
        }

        #region 添加事件方法
        /// <summary>
        /// 添加事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //byte[] bytearr = System.Text.Encoding.Default.GetBytes(pictureBox1.Image);

            StorageInfo sif = new StorageInfo
            {
                MeName = textBox1.Text,
                MePrice = Convert.ToDecimal(textBox2.Text),
                FypeId = Convert.ToInt32(textBox3.Text),
                MPicture = imagTobyte(pictureBox1.Image),
                MeTerial = textBox5.Text,
                MeTaste = textBox6.Text,
                MeDetails = textBox7.Text,
                MeNumber = Convert.ToInt32(textBox8.Text),
            };

            int n = StorageManager.StoreImageAdd(sif);
            if (n > 0) 
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
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

            image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
               
        }
        #endregion

        #region 选择图片方法
        /// <summary>
        /// 选择图片方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
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
                this.textBox4.Text = ofdlgTest.FileName;

                pictureBox1.Image = Image.FromFile(ofdlgTest.FileName);
            }
            

        }
        #endregion
    }
}
