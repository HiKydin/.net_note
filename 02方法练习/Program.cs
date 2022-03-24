using System;

namespace _02方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wholong = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            string str = Program.wlong(wholong);
            Console.WriteLine(str);
        }
        public static string wlong(string[] str)
        {
            string wlong="";
            int max=0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i].Length>max)
                {
                    max = str[i].Length;
                    wlong = str[i];
                }
            }
            return wlong;
        }
    }
}
