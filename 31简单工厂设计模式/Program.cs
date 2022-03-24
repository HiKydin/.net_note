using System;

namespace _31简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //根据用户输入的品牌返回对应品牌的笔记本电脑
            Console.WriteLine("请输入您需要的电脑品牌");
            string name = Console.ReadLine();
            Notebook nb = GetNotebook(name);
            nb.SayHello();
        }

        public static Notebook GetNotebook(string name)
        {
            Notebook nb = null;
            switch(name)
            {
                case "Dell":nb = new Dell();
                    break;
                case "Leve":nb = new Leve();
                    break;
                case "Ibm": nb = new Ibm();
                    break;
                case "Mac": nb = new Mac();
                    break;
            }
            return nb;
        }
    }
    public abstract class Notebook
    {
        public abstract void SayHello();
    }
    public class Dell:Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }
    public class Leve:Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本");
        }
    }
    public class Ibm:Notebook 
    {
        public override void SayHello()
        {
            Console.WriteLine("我是ibm笔记本");
        }
    }
    public class Mac:Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是苹果笔记本");
        }
    }
}
