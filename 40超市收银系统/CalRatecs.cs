using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40超市收银系统
{
    class CalRatecs:CatFather
    {
        public double Rate
        {
            get;
            set;
        }
        public CalRatecs(double rate)
        {
            this.Rate = rate;
        }
        public override double GetMoney(double realMoney)
        {
            return realMoney * Rate;
        }
    }
}
