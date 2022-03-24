using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _50图片的上一张和下一张
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] path=Directory.GetFiles(@"C:\Users\admin\source\repos\50图片的上一张和下一张\Pic");
        int i = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            i++;
            if(i==path.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
        private void btnPro_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = path.Length-1;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
