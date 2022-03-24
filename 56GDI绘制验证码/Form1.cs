using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _56GDI绘制验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //生成五个随机数并储存到字符串中
            Random r = new Random();
            string str = "";
            for(int i=0;i<5;i++)
            {
                int rnum = r.Next(0, 5);
                str += rnum;
            }
            //创建一个图片对象
            Bitmap bmp = new Bitmap(120,50);
            //创建GDI对象
            Graphics g = Graphics.FromImage(bmp);

            //创建存储字体的字符串数组
            string[] fonts = { "黑体", "楷体", "宋体" };
            //创建存储颜色的字符串数组
            Color[] colors = { Color.Black, Color.Yellow, Color.Blue, Color.Red };

            //绘制验证码
            for(int i=0;i<5;i++)
            {
                Point p = new Point(i * 20, 0);
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, fonts.Length)], 20, FontStyle.Bold), new SolidBrush(colors[r.Next(0, colors.Length)]), p);
            }

            //画线
            for(int i=0;i<25;i++)
            {
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                g.DrawLine(new Pen(Color.Green), p1, p2);
            }

            //画像素颗粒
            for(int i=0;i<100;i++)
            {
                Point p = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Black);
            }

            //将画好的图片放到PictureBox上
            pictureBox1.Image = bmp;
        }
    }
}
