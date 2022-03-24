using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52石头剪刀布
{
    public class Caipan
    {
        public string Whowin(int unum,int rnum)
        {
            if(unum-rnum==-1||unum-rnum==2)
            {
                return "玩家赢";
            }
            else if(unum-rnum==0)
            {
                return "平手";
            }
            else
            {
                return "电脑赢";
            }
        }
    }
}
