using System;
using System.IO;
using System.Text;

namespace _22FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream  操作字节
            //StreamReader和StreamWirter 操作字符的

            using (FileStream fsRead=new FileStream(@"C:\Users\admin\source\repos\22FileStream\1.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                string s = Encoding.Default.GetString(buffer, 0, r);
                Console.WriteLine(s);
            }


            //using (FileStream fsWrite = new FileStream(@"C:\Users\admin\source\repos\22FileStream\1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    string str = "看我有没有成功写入";
            //    byte[] buffer = Encoding.Default.GetBytes(str);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            //Console.WriteLine("写入ok");
        }
    }
}
