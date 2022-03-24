using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54窗体间控件的移动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 frm2 = new Form2();
        private void label1_Click(object sender, EventArgs e)
        {
            //判断 如果label在第一个窗体中
            //点击的时候 让它去第二个窗体中
            if(this.label1.Parent==this)
            {
                //将窗体1中label添加到窗体2中
                frm2.Controls.Add(this.label1);
                this.label1.Text = "我现在在窗体2中";
                frm2.Show();
            }
            else//在第二个窗体中
            {
                this.Controls.Add(this.label1);
                this.label1.Text = "我现在在窗体1中";
            }
        }
    }
}
