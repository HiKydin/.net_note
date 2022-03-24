using System;

namespace _36重写父类的ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Preson p = new Preson();
            Console.WriteLine(p.ToString());
        }
    }
    public class Preson
    {
        public override string ToString()//这个是虚方法
        {
            return "hi";
        }
    }
}
