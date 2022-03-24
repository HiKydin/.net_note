using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09继承
{
    public class Student:Preson
    {
        private int _scroe;
        public int Scroe
        {
            get { return _scroe; }
            set { _scroe = value; }
        }
        public Student(string name, int age, char gender,int scroe):base(name,age,gender)
        {
            this.Scroe = scroe;
        }


        public void CHLSS()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我的性别是{2}，我的成绩是{3}", this.Name, this.Age, this.Gender, this.Scroe);
        }
    }
}
