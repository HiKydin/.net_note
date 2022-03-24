using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _63Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //创建负责通信的Socket
        Socket socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //获取要连接的服务器的IP地址和端口号
                IPAddress ip = IPAddress.Parse(txtAddress.Text);
                IPEndPoint port = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                socketSend.Connect(port);
                ShowMsg("连接成功!");
                //创建一个新线程不断接收服务器发送的消息
                Thread th = new Thread(Receive);
                th.IsBackground = true;
                th.Start(socketSend);
            }
            catch { }
        }

        /// <summary>
        /// 客户端接收消息
        /// </summary>
        /// <param name="o"></param>
        void Receive(object o)
        {
            Socket socketSend = o as Socket;
            while(true)
            {
                try
                {
                    //连接成功后，接收服务器发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //实际上接收到的有效字节数
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    //提取出接收内容的协议
                    //==0表示传输的是文字消息
                    if (buffer[0]==0)
                    {
                        string str = System.Text.Encoding.UTF8.GetString(buffer, 1, r-1);
                        ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                    }
                    //==1表示传输的是文件
                    else if(buffer[0] ==1)
                    {
                        MessageBox.Show("对方发送了一个文件，请查收！");
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = @"C:\Users\admin\source\repos\62Server";
                        sfd.Title = "请选择要保存的路径";
                        sfd.Filter = "所有文件|*.*";
                        sfd.ShowDialog(this);
                        string path = sfd.FileName;
                        using(FileStream fsWrite=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, r - 1);
                        }
                        MessageBox.Show("保存成功！");
                    }
                    //==2表示传输的是震动
                    else if(buffer[0] ==2)
                    {
                        Shake();
                    }
                }
                catch { }
            }
        }
        private void Shake()
        {
            int leftWidth = this.Left; //指定窗体左边值
            int topWidth = this.Top; //指定窗体上边值

            for (int i = 0; i < 20; i++) //设定循环次数为20 且加1
            {
                if (i % 2 == 0) //如果i 能给2整除
                {
                    this.Left = this.Left + 10; //窗体左边值加10
                }
                else //否则
                {
                    this.Left = this.Left - 10;//窗体左边边值减10
                }
                if (i % 2 == 0)//如果i能给2整除
                {
                    this.Top = this.Top + 10;//窗体上边值加10
                }
                else//否则
                {
                    this.Top = this.Top - 10;//窗体上边值减10
                }

                System.Threading.Thread.Sleep(30);//震动频率
            }

            this.Left = leftWidth;//重设窗体初此左边值
            this.Top = topWidth; //重设窗体初此上边值
        }

        /// <summary>
        /// 客户端给服务器发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txtMsg.Text.Trim();
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                socketSend.Send(buffer);
                txtMsg.Clear();
            }
            catch { }
        }

        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="str"></param>
        private void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        /// <summary>
        /// 主窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            
        }
    }
}
