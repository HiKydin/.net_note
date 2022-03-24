using System;
using System.IO;
using System.Text;

namespace _08字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //接收一句英文，将其中的单词反序输出"hello c sharp"->"sharp c hello"
            string str = "hello c sharp";
            char[] s = { ' ' };
            string[] str1=str.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            for(int i=0;i<str1.Length/2;i++)
            {
                string tmp = str1[i];
                str1[i] = str1[str1.Length - 1 - i];
                str1[str1.Length - 1 - i] = tmp;
            }
            str=string.Join(" ", str1);
            Console.WriteLine(str);



            //从Email中提取用户名和域名"abc@163.com"
            string email = "abc@163.com";
            int index = email.IndexOf('@');
            string userName = email.Substring(0, index);
            Console.WriteLine(userName);
            string yuName = email.Substring(index+1);
            Console.WriteLine(yuName);


            //文本文件中存储了多个文章标题、作者
            //标题和作者之间用若干空格(数量不定)隔开，每行一个
            //标题有的长有的短，输出到控制台的时候最多标题长度10
            //如果超过10，则截取长度8的字串并且最后添加"...",加一个竖线后输出作者的名字

            string path = @"C:\Users\admin\source\repos\08字符串练习\1.txt";
            string[] contents = File.ReadAllLines(path, Encoding.Default);
            for (int i=0;i<contents.Length;i++)
            {
                string[] strNew = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine((strNew[0].Length>10?strNew[0].Substring(0,8)+"...":strNew[0])+'|'+strNew[1]);
            }

            //用户输入一句话，找出所有e的位置
            string str2 = "asdaseaseeawease";
            int index1 = str2.IndexOf('e');
            Console.WriteLine("第{0}次出现e的位置是{1}",1,index1);
            int cont = 1;
            while(index1!=-1)
            {
                index1 = str2.IndexOf('e', index1 + 1);
                if(index1==-1)
                {
                    break;
                }
                Console.WriteLine("第{0}次出现e的位置是{1}",++cont, index1);
            }

            //判断这句话有没有"邪恶",如果有，替换为**
            string str3 = "老牛很邪恶";
            if(str3.Contains("邪恶"))
            {
                str3 = str3.Replace("邪恶", "**");
            }
            Console.WriteLine(str3);

            //把{"诸葛亮","鸟叔","卡卡西","卡哇伊"}变成诸葛亮|鸟叔|卡卡西|卡哇伊

            string[] str4 = { "诸葛亮", "鸟叔", "卡卡西", "卡哇伊" };
            string strNew1=string.Join('|', str4);
            Console.WriteLine(strNew1);



        }
    }
}
