using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           lbltime.Text= DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString();
        }
    }
}
