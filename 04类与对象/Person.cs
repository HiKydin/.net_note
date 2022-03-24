using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04类与对象
{
    public class Person
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        int _age;
        public int Age
        {
            get {
                if (_age<0||_age>100)
                {
                    return 0;
                }
                return _age; }
            set { _age = value; }
        }
        char _gender;
        public char Gender
        {
            get { return _gender; }
            set {
                if (value != '男' && value != '女')
                {
                    _gender = '无';
                }
                else
                {
                    _gender = value;
                }
             }
        }
        public void CHLSS()
        {
            Console.WriteLine("我叫{0}，今年{1}岁了，我是{2}生",this._name,this.Age,this._gender);
        }
    }
}
