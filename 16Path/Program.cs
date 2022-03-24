using System;
using System.IO;

namespace _16Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"C:\Users\admin\source\repos\16Path\16Path.csproj";
            //int index = str.LastIndexOf("\\");
            //str = str.Substring(index + 1);
            //Console.WriteLine(str);
            Console.WriteLine(Path.GetFileName(str));
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            Console.WriteLine(Path.GetExtension(str));
            Console.WriteLine(Path.GetDirectoryName(str));
            Console.WriteLine(Path.GetFullPath(str));
            Console.WriteLine(Path.Combine(@"c:/a/", "b.txt"));
        }
    }
}
