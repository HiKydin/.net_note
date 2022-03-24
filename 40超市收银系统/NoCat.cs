using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40超市收银系统
{
    class NoCat:CatFather
    {
        public override double GetMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
