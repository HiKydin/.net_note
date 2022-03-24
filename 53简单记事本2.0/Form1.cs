using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _53简单记事本2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.WordWrap = false;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文本文件";
            //不设置多选
            ofd.InitialDirectory = @"C:\Users\admin\source\repos\53简单记事本2.0";
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            ofd.ShowDialog();
            //获得选中文件的路径
            string path = ofd.FileName;
            //将选中文件的名字存储到ListBox中
            listBox1.Items.Add(Path.GetFileName(path));
            //将文件的全路径放到List泛型集合中
            list.Add(path);
            using (FileStream fsRead = new FileStream(path,FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                byte[] buffer = new byte[1024 * 1024 * 3];
                //本次读取实际读取到的字节数
                int r = fsRead.Read(buffer, 0, buffer.Length);

                //解码
                textBox1.Text = System.Text.Encoding.Default.GetString(buffer, 0, r);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory= @"C:\Users\admin\source\repos\53简单记事本2.0";
            sfd.Filter= "文本文件|*.txt|所有文件|*.*";
            sfd.Title = "请选择要保存的路径";
            sfd.ShowDialog();
            //获取用户保存文件的路径
            string path = sfd.FileName;
            using(FileStream fsWrite=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
            {
                byte[] buffer = System.Text.Encoding.Default.GetBytes(textBox1.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功!");
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(自动换行ToolStripMenuItem.Text=="☆自动换行")
            {
                textBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "★取消自动换行";
            }
            else
            {
                textBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "☆自动换行";
            }
        }

        private void 字体样式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            textBox1.Font = fd.Font;
        }

        private void 颜色样式ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }

        List<string> list = new List<string>();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //根据你双击的文件 找到这个文件所对应的全路径
            string path = list[listBox1.SelectedIndex];
            using (FileStream fsRead = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 3];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = System.Text.Encoding.Default.GetString(buffer, 0, r);
            }
        }
    }
}
