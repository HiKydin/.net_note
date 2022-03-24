using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06面向对象练习
{
    public class Student
    {

        public Student(string name,char gender,int age,int chinese,int math,int english)
        {
            this._name = name;
            this._gender = gender;
            this._age = age;
            this._chinese = chinese;
            this._math = math;
            this._english = english;
        }
        public Student(string name,char gender):this(name,gender,0,0,0,0)
        {

        }

        ~Student()
        {

        }




        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set { _age = value; }
        }
        private int _math;
        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }
        private int _english;
        public int English
        {
            get { return _english; }
            set { _english = value; }
        }



        public void sayhello()
        {
            Console.WriteLine("我叫{0}，我是{1}生，今年{2}岁了，我的总成绩是{3}", Name, Gender, Age, Chinese + Math + English);
        }
    }
}
