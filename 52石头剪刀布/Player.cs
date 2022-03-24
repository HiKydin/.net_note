using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52石头剪刀布
{
    public class Player
    {
        public int GetFit(string str)
        {
            int unum = 0;
            switch(str)
            {
                case "石头":
                    unum = 0;
                    break;
                case "剪刀":
                    unum = 1;
                    break;
                case "布":
                    unum = 2;
                    break;
            }
            return unum;
        }
    }
}
