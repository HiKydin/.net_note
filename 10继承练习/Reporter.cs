using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10继承练习
{
    public class Reporter:Preson
    {
        private string _hobby;
        public string Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }
        public Reporter(string name,int age,char gender,string hobby):base(name,age,gender)
        {
            this.Hobby = hobby;
        }
        public void ReporterSayHello()
        {
            Console.WriteLine("我是{0}，我的爱好是{1}，我的年龄是{2}，我是一个{3}狗仔",this.Name,this.Hobby,this.Age,this.Gender);
        }
    }
}
