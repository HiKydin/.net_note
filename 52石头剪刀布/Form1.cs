using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStorn_Click(object sender, EventArgs e)
        {
            string str = "石头";
            PlayGames(str);
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            PlayGames(str);
        }

        private void btnBu_Click(object sender, EventArgs e)
        {
            string str = "布";
            PlayGames(str);
        }

        public void PlayGames(string str)
        {
            //显示玩家按下的按钮
            lblPlayer.Text = str;
            //创建电脑对象
            Cpu cpu = new Cpu();
            //获取电脑出的拳
            int rnum=cpu.GetFit();
            //将电脑出的拳显示出来
            lblCpu.Text = cpu.Fit;
            //创建玩家对象
            Player player = new Player();
            //创建裁判对象
            Caipan caipan = new Caipan();
            //判断结果
            string strret=caipan.Whowin(player.GetFit(str),rnum);
            //显示结果
            lblResult.Text = strret;
        }
    }
}
