using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40超市收银系统
{
    class Productfather
    {
        private string _name;
        private string _id;
        private double _price;
        public string Name
        {
            get;
            set;
        }
        public string Id
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        public Productfather(string name,string id,double price)
        {
            this.Name = name;
            this.Id = id;
            this.Price = price;
        }
    }
}
