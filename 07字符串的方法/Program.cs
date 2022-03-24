using System;
using System.Diagnostics;
using System.Text;

namespace _07字符串的方法
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Stopwatch sw = new Stopwatch();
            //创建了一个计数器，用来记录程序运行的时间
            string str = null;
            sw.Start();//开始计时
            for(int i=0;i<10000;i++)
            {
                //str+= i;
                sb.Append(i);
            }
            sw.Stop();//结束计时
            Console.WriteLine(sw.Elapsed);

            //ToUpper()将字符串转为大写
            //ToLower()将字符串转为小写
            //Equals()比较两个字符串，可以忽略大小写
            //if(a.Equals(b,StringComparison.OrdinalIgnoreCase))


            //从日期字符串("2008-08-08")中分析出年月日
            //让用户输入一个日期格式如2008-01-02，你输出的日期为2008年1月2日、
            string s = "2008-08-08";
            char[] chs = { '-' };
            string[] s1=s.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            string[] s2 = s.Split(new char[] { '-'}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0}年{1}月{2}日", s1[0], s1[1], s1[2]);

            //Substring 截取字符串

            string str1 = "今天天气好晴朗,处处好风光";
            str1 = str1.Substring(1,3);
            Console.WriteLine(str1);

            //EndsWith判断字符串的结尾
            string str2= "今天天气好晴朗,处处好风光";
            if (str2.EndsWith("风"))
            {
                Console.WriteLine("是的");
            }
            else
            {
                Console.WriteLine("不是的");
            }

            //StartsWith判断字符串的结尾
            string str3 = "今天天气好晴朗,处处好风光";
            if (str3.StartsWith("今天"))
            {
                Console.WriteLine("是的");
            }
            else
            {
                Console.WriteLine("不是的");
            }

            //IndexOf查找指定字符出现的下标
            string str4 = "今天天气好晴朗,处处好风光";
            int index = str4.IndexOf('天');
            Console.WriteLine(index);

            //查找时包括当前字符
            string str5 = "今天天气好晴朗,处处好风光";
            int index1 = str4.IndexOf('天',2);
            Console.WriteLine(index1);

            //LastIndexOf查找最后一个出现的下标
            string str6 = "今天天气好晴朗,处处好风光";
            int index2 = str4.LastIndexOf('天');
            Console.WriteLine(index2);

            //Substring 输出截取的字符串
            string path = @"c:\a\b\c\d\s\e\g\e\苍老师.wav";
            int index3 = path.LastIndexOf("\\");
            path = path.Substring(index3 + 1);
            Console.WriteLine(path);

            //Trim清楚
            string str7 = "     hahahah    ";
            str7 = str7.Trim();
            str7 = str7.TrimStart();
            str7 = str7.TrimEnd();
            Console.WriteLine(str7);


            //IsNullOrEmpty判断是否是null或者空
            string str8 = null;
            if(string.IsNullOrEmpty(str8))
            {
                Console.WriteLine("是的");
            }
            else
            {
                Console.WriteLine("不是的");
            }

            //string.Join 在字符串数组中加入指定符号，最后一个不加
            string[] names = { "张三", "李四", "王五" };
            string strNew=string.Join("|", names);
            Console.WriteLine(strNew);


            //判断这句话有没有"邪恶",如果有，替换为**
            string str9 = "老牛很邪恶";
            if (str9.Contains("邪恶"))
            {
                str9 = str9.Replace("邪恶", "**");
            }
            Console.WriteLine(str9);




        }
    }
}
