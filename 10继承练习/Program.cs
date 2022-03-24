using System;

namespace _10继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //记者：我是记者，我的爱好是偷拍，我的年龄是34，我是一个男狗仔
            //司机：我叫舒马赫，我的年龄是43，我是男人，我的驾龄是23年
            //程序员：我叫孙权，我的年龄是23，我是男生，我的工作年限是3年

            Programmer zs = new Programmer("张三", 21, '男', 2);
            zs.ProgrammerSayHello();
            Reporter ls = new Reporter("李四", 18, '女', "偷拍");
            ls.ReporterSayHello();

        }
    }
}
