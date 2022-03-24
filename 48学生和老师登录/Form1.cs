using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48学生和老师登录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(rdoStudent.Checked==true)
            {
                if(txtUsr.Text=="student"&&txtPwd.Text=="student")
                {
                    MessageBox.Show("学生登录成功！");
                }
                else
                {
                    MessageBox.Show("学生登录失败");
                }
            }
            else if(rdoTeacher.Checked==true)
            {
                if (txtUsr.Text == "teacher" && txtPwd.Text == "teacher")
                {
                    MessageBox.Show("老师登录成功！");
                }
                else
                {
                    MessageBox.Show("老师登录失败");
                }
            }
        }
    }
}
