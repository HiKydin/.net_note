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
// Disable the warning.
#pragma warning disable SYSLIB0001

// Code that uses obsolete API.
//...

// Re-enable the warning.
#pragma warning restore SYSLIB0001
namespace _59多线程摇奖机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th = null;
        bool b = false;
        private void GameStart_Click(object sender, EventArgs e)
        {
            if(b)
            {
                b = !b;
                GameStart.Text = "开始";
            }
            else
            {
                th = new Thread(PlayGame);
                th.IsBackground = true;
                th.Start();
                b = true;
                GameStart.Text = "暂停";
            }
        }
        void PlayGame()
        {
            Random r = new Random();
            while(b)
            {
                label1.Text = r.Next(0, 10).ToString();
                label2.Text = r.Next(0, 10).ToString();
                label3.Text = r.Next(0, 10).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(th!=null)
            {
                th.Abort();
            }
        }
    }
}
