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

namespace _46简单记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = textUsername.Text.Trim();
            string pwd = textPwd.Text;
            if(name=="admin" && pwd=="admin")
            {

                MessageBox.Show("登录成功！");

                btn1.Visible = true;
                btnSave.Visible = true;
                txtWords.Visible = true;

                btnLogin.Visible = false;
                btnReset.Visible = false;
                lblPasswd.Visible = false;
                lblUsername.Visible = false;
                textUsername.Visible = false;
                textPwd.Visible = false;
            }
            else
            {
                MessageBox.Show("用户名或密码错误！请重新输入");
                textUsername.Clear();
                textPwd.Clear();
                textUsername.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtWords.WordWrap = false;
            btn1.Visible = false;
            btnSave.Visible = false;
            txtWords.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPwd.Clear();
            textUsername.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(btn1.Text=="自动换行")
            {
                txtWords.WordWrap = true;
                btn1.Text = "取消自动换行";
            }
            else
            {
                txtWords.WordWrap = false;
                btn1.Text = "自动换行";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (FileStream fsWriter=new FileStream(@"C:\Users\admin\source\repos\46简单记事本\new.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                byte[] buffer = System.Text.Encoding.Default.GetBytes(txtWords.Text);
                fsWriter.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功！");
        }
    }
}
