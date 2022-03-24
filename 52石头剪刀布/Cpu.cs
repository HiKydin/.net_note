using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52石头剪刀布
{
    public class Cpu
    {
        Random r = new Random();
        public string Fit
        {
            get;
            set;
        }

        public int GetFit()
        {
            int rnum = r.Next(0, 3);
            switch(rnum)
            {
                case 0:
                    this.Fit = "石头";
                    break;
                case 1:
                    this.Fit = "剪刀";
                    break;
                case 2:
                    this.Fit = "布";
                    break;
            }
            return rnum;

        }
    }
}
