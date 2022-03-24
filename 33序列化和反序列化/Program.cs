using System;
using System.IO;
using System.Xml.Serialization;

namespace _33序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //序列化：就是将对象转换为二进制
            //反序列化：就是将二进制转换为对象
            //作用：传输数据
            Preson p = new Preson();
            p.name = "张三";
            p.age = 18;
            p.gender = '男';

            using (FileStream fsWriter=new FileStream(@"C:\Users\admin\source\repos\33序列化和反序列化\1.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                XmlSerializer bf = new XmlSerializer();
                bf.Serialize(fsWriter, p);
            }
            Console.WriteLine("序列化成功");

        }
    }
    public class Preson
    {
        public int age;
        public string name;
        public char gender;
    }
}
