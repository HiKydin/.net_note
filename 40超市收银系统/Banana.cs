using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40超市收银系统
{
    class Banana : Productfather
    {
        public Banana(string name, string id, double price) : base(name, id, price)
        {
            this.Name = name;
            this.Id = id;
            this.Price = price;
        }
    }
}
