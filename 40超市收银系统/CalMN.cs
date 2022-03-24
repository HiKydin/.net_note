using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40超市收银系统
{
    class CalMN:CatFather
    {
        public int M
        {
            get;
            set;
        }
        public int N
        {
            get;
            set;
        }
        public CalMN(int m,int n)
        {
            this.M = m;
            this.N = n;
        }
        public override double GetMoney(double realMoney)
        {
            if(realMoney>=M)
            {
                return realMoney - (int)(realMoney / this.M) * this.N;
            }
            else
            {
                return realMoney;
            }
        }
    }
}
