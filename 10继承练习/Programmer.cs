using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10继承练习
{
    public class Programmer:Preson
    {
        private int _workYear;
        public int WorkYear
        {
            get { return _workYear; }
            set { _workYear = value; }
        }
        public Programmer(string name, int age,char gender,int workyear) :base(name,age,gender)
        {
            this.WorkYear = workyear;
        }
        public void ProgrammerSayHello()
        {
            Console.WriteLine("我是{0}，我的工龄是{1}，我的年龄是{2}，我是一个{3}码农", this.Name, this.WorkYear, this.Age, this.Gender);
        }
    }
}
