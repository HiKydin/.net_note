using System;

namespace _00前导
{
    /// <summary>
    /// 定义了一个信息结构体，有三个字段，分别是姓名、年龄和性别
    /// </summary>
    public struct inf
    {
        public string _name;
        public int _age;
        public char _gender;
    }
    /// <summary>
    /// 定义了一个在线状态枚举类，有四个字段，分别是在线、离线、忙碌和Q我吧
    /// </summary>
    public enum Qstate
    {
        OnLine = 1,
        OffLine,
        Busy,
        QMe
    }
    class Program
    {
        public static string accout; //登录账号
        public static string passwd; //登录密码
        public static inf usrinf;    //用户信息结构体

        static void Main(string[] args)
        {
            #region 生成随机校验码
            Random n = new Random();
            int rNumber = n.Next(1, 10);
            Console.WriteLine("您的随机校验ID为：{0}", rNumber);
            //Console.ReadKey();
            #endregion
            #region 用户登录
            Program.Login();
            string msg;
            bool logininf = Program.CheckLogin(accout, passwd, out msg);
            while (logininf == false)
            {
                Program.Cross();
                Console.WriteLine(msg);
                Program.Login();
                logininf = Program.CheckLogin(accout, passwd, out msg);
                if (logininf == true)
                {
                    break;
                }
            }
            #endregion
            Hello();//登录欢迎页面
            InPut();//输入用户信息
            OutPut();//绘制用户信息图表
            Check();//检查用户信息
        }
        /// <summary>
        /// 绘制图表
        /// </summary>
        public static void Cross()
        {
            Console.WriteLine("----------------------------------------------------");
        }
        /// <summary>
        /// 登录程序，提示用户输入账号密码
        /// </summary>
        public static void Login()
        {
            #region 登录程序
            Console.WriteLine("请输入账号：");
            accout = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            passwd = Console.ReadLine();
            #endregion
        }
        /// <summary>
        /// 检查账号合法性
        /// </summary>
        /// <param name="accout">账号</param>
        /// <param name="passwd">密码</param>
        /// <param name="msg">多余返回登录信息</param>
        /// <returns>返回登录状态</returns>
        public static bool CheckLogin(string accout, string passwd, out string msg)
        {
            #region 检验账号合法性
            if (accout == "admin" && passwd == "admin")
            {
                Console.WriteLine("登录成功！欢迎您！！");
                msg = "登录成功！欢迎您！！";
                return true;
            }
            else if (accout == "admin")
            {
                msg = "密码错误！请重新输入！！";
                return false;
            }
            else if (passwd == "admin")
            {
                msg = "账号错误！请重新输入！！";
                return false;
            }
            else
            {
                msg = "未知错误！请重新输入！！";
                return false;
            }
            #endregion
        }
        /// <summary>
        /// 显示欢迎页面并提示用户输入在线状态
        /// </summary>
        public static void Hello()
        {
            #region 输入在线状态
            Console.WriteLine("亲爱的同学您好，欢迎登录NSU教务网站");
            Program.Cross();
            Console.WriteLine("请选择您的在线状态：\n1---在线\n2---离线\n3---忙碌\n4---Q我吧");
            Qstate usrstate = (Qstate)Enum.Parse(typeof(Qstate), Console.ReadLine());
            Console.WriteLine("您的在线状态为：{0}", usrstate);
            Program.Cross();
            #endregion
        }
        /// <summary>
        /// 提示用户输入信息
        /// </summary>
        public static void InPut()
        {
            #region 输入用户信息
            Program.Cross();
            Console.WriteLine("请输入您的名字：");
            usrinf._name = Console.ReadLine();
            Console.WriteLine("请输入您的年龄：");
            usrinf._age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入您的性别：");
            usrinf._gender = char.Parse(Console.ReadLine());
            Program.Cross();
            #endregion
        }
        /// <summary>
        /// 绘制用户信息图表
        /// </summary>
        public static void OutPut()
        {
            #region 绘制信息图表
            Program.Cross();
            Console.WriteLine("您的姓名是：{0}\n您的年龄是：{1}岁\n您的性别是：{2}", usrinf._name, usrinf._age, usrinf._gender);
            Program.Cross();
            #endregion
        }
        /// <summary>
        /// 提示用户检查信息是否正确
        /// </summary>
        public static void Check()
        {
            #region 信息检验
            Console.WriteLine("请确认信息是否正确：正确请按1，重新输入请按0，退出系统请按+");
            switch (Console.ReadLine())
            {
                case "1":
                    System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\inf.txt", usrinf._name);
                    Console.WriteLine("您的信息已保存！");
                    break;
                case "0":
                    InPut();
                    break;
                case "+":
                    return;
                default:
                    Console.WriteLine("系统异常，即将退出");
                    break;
            }
            #endregion
        }
    }
}