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

namespace _62Server
{
    public partial class Form1 : Form
    {
        Socket socketSend;
        //将远程连接的客户端的IP地址和Socket存入集合
        Dictionary<string, Socket> dicIP = new Dictionary<string, Socket>();


        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 开始监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListening_Click(object sender, EventArgs e)
        {
            try
            {
                //当点击开始监听的时候 在服务器端创建一个负责监听IP地址和端口号的Socket
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;
                //创建端口号对象
                IPEndPoint port = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                //监听
                socketWatch.Bind(port);
                ShowMsg("监听成功");
                //创建监听队列
                socketWatch.Listen(10);
                //创建监听线程
                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
            }
            catch { }
        }


        /// <summary>
        /// 等待客户端的连接 并且创建与之通信的Socket
        /// </summary>
        /// <param name="o"></param>
        void Listen(object o)
        {
            try
            {
                //用as进行类型转换，如果能转换返回一个对象，否则返回一个null
                Socket socketWatch = o as Socket;
                //等待客户端连接 并且创建一个负责通信的Socket
                while (true)
                {
                    socketSend = socketWatch.Accept();
                    //将远程连接的客户端的IP地址和Socket存入集合
                    dicIP.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    //将远程连接的客户端的IP地址和Socket存入下拉框
                    cboIP.Items.Add(socketSend.RemoteEndPoint.ToString());
                    //有人连接成功后写入日志
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");
                    //开启一个新线程接收客户端发送的消息
                    Thread th = new Thread(Receive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
            }
            catch
            { }
        }

        void Receive(object o)
        {
            Socket socketSend = o as Socket;
            while(true)
            {
                try
                {
                    //客户端连接成功后，服务器接收客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //实际上接收到的有效字节数
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
                catch
                { }
            }
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

        /// <summary>
        /// 服务器给客户端发消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txtMsg.Text;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                //进行协议的标识
                List<byte> list = new List<byte>();
                list.Add(0);
                list.AddRange(buffer);
                //将泛型集合转换为数组
                byte[] newBuffer = list.ToArray();
                //发送的合法性判断
                if (cboIP.SelectedItem == null)
                {
                    MessageBox.Show("请选择要发送的用户！");
                }
                else
                {
                    //获得用户在下拉框中选中的IP地址
                    string ip = cboIP.SelectedItem.ToString();
                    dicIP[ip].Send(newBuffer);
                    txtMsg.Clear();
                }
            }
            catch { }
        }

        /// <summary>
        /// 选择要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = @"C:\Users\admin\source\repos\62Server";
                ofd.Title = "请选择要发送的文件";
                ofd.Filter = "所有文件|*.*";
                ofd.ShowDialog();
                txtFileaddress.Text = ofd.FileName;
            }
            catch { }
        }

        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                /// 获得要发送文件的路径
                string path = txtFileaddress.Text;
                using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    //创建字节数组传递数据
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r = fsRead.Read(buffer, 0, buffer.Length);
                    //添加协议位
                    List<byte> list = new List<byte>();
                    list.Add(1);
                    list.AddRange(buffer);
                    byte[] newBuffer = list.ToArray();
                    //发送的合法性判断
                    if (cboIP.SelectedItem == null)
                    {
                        MessageBox.Show("请选择要发送的用户！");
                    }
                    else
                    {
                        dicIP[cboIP.SelectedItem.ToString()].Send(newBuffer, 0, r + 1, SocketFlags.None);
                        txtAddress.Clear();
                    }
                }
            }
            catch { }
        }

        private void btnShake_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[1];
                buffer[0] = 2;
                //发送的合法性判断
                if (cboIP.SelectedItem == null)
                {
                    MessageBox.Show("请选择要发送的用户！");
                }
                else
                {
                    dicIP[cboIP.SelectedItem.ToString()].Send(buffer, 0, buffer.Length, SocketFlags.None);
                    txtAddress.Clear();
                }
            }
            catch { }
        }
    }
}
