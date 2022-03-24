using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _58单线程的缺点及解决
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th = null;
        private void button1_Click(object sender, EventArgs e)
        {
            //开启一个新的线程帮助我们执行Test方法（委托）
            th = new Thread(Test);
            //设置成后台线程
            th.IsBackground = true;
            //启动线程
            th.Start();
            //线程无法杀死后重新start

        }

        void Test()
        {
            for(int i=0;i<100000;i++)
            {
                textBox1.Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消对跨线程访问的检查
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当关闭窗体的时候，同时关闭后台线程
            if(th!=null)
            {
                //关闭线程
                th.Abort();
            }
        }
    }
}
