using System;
using System.Security.Cryptography;
using System.Text;

namespace _41MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //原文:123
            //密文：202cb962ac59075b964b07152d234b70
            string str = "123";
            Console.WriteLine(GetMd5(str));

        }
        public static string GetMd5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //开始加密
            //将字符串转换为字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //返回一个加密好的字节数组
            byte[] MD5buffer = md5.ComputeHash(buffer);
            //将字节数组转换为字符串
            string strNew = "";
            for(int i=0;i<MD5buffer.Length;i++)
            {
                strNew += MD5buffer[i].ToString("x2");
            }
            return strNew;
        }
    }
}
