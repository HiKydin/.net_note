using System;
namespace _03飞行棋
{
    class Program
    {
        public static int[] map = new int[100];//地图信息数组
        public static int[] PlayerPos = new int[2];//玩家坐标
        public static string[] PlayName = new string[2];//玩家昵称
        public static bool[] Flags = new bool[2];//玩家是否被睡眠，false为未睡眠状态，true为睡眠状态，初始化为false
        static void Main(string[] args)
        {
            #region 游戏开始准备工作
            Program.GameHand();
            Console.ForegroundColor = ConsoleColor.White;
            #region 输入姓名
            Console.WriteLine("请输入玩家A的姓名：");
            PlayName[0] = Console.ReadLine();
            while (PlayName[0] == "")
            {
                Console.WriteLine("玩家A的姓名不能为空！！请重新输入：");
                PlayName[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名：");
            PlayName[1] = Console.ReadLine();
            while (PlayName[1] == "" || PlayName[1] == PlayName[0])
            {
                if (PlayName[1] == "")
                {
                    Console.WriteLine("玩家B的姓名不能为空！！请重新输入：");
                    PlayName[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B的姓名不能与玩家A相同！！请重新输入：");
                    PlayName[1] = Console.ReadLine();
                }
            }
            #endregion
            Console.Clear();
            Program.MapInit();
            Program.GameHand();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("玩家{0}用1P表示", PlayName[0]);
            Console.WriteLine("玩家{0}用2P表示", PlayName[1]);
            Program.DrawMap();
            #endregion
            while (PlayerPos[0] < 99 || PlayerPos[1] < 99)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Random dice = new Random();
                int Dice = dice.Next(1, 7);
                if (Flags[0] == false)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("玩家{0}的回合！！请按任意键掷骰子", PlayName[0]);
                    Console.ReadKey(true);
                    Console.WriteLine("玩家{0}摇到了{1}", PlayName[0], Dice);
                    PlayerPos[0] += Dice;
                    Console.WriteLine("按任意键开始行动");
                    Console.ReadKey(true);
                    if (PlayerPos[0] == PlayerPos[1 - 0])
                    {
                        Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退后6格", PlayName[0], PlayName[1 - 0], PlayName[1 - 0]);
                        PlayerPos[1 - 0] -= 6;
                        Program.CheckPos(1 - 0);
                        Console.ReadKey(true);
                    }
                    else
                    {
                        switch (map[PlayerPos[0]])
                        {
                            case 0:
                                Console.WriteLine("玩家{0}踩到了平地，神马都没有发生", PlayName[0]);
                                Console.ReadKey(true);
                                break;
                            case 1:
                                Console.WriteLine("玩家{0}踩到了幸运轮盘，按1---交换两个玩家位置，按2---对手后退6格。请选择", PlayName[0]);
                                string LuckyChoose = Console.ReadLine();
                                while (true)
                                {
                                    if (LuckyChoose == "1")
                                    {
                                        int temp = 0;
                                        temp = PlayerPos[1];
                                        PlayerPos[1] = PlayerPos[0];
                                        PlayerPos[0] = temp;
                                        Console.WriteLine("交换成功！！按任意键继续");
                                        Console.ReadKey(true);
                                        break;
                                    }
                                    else if (LuckyChoose == "2")
                                    {
                                        PlayerPos[1 - 0] -= 6;
                                        Console.WriteLine("玩家{0}被击退了6格！！按任意键继续", PlayName[1 - 0]);
                                        Program.CheckPos(1 - 0);
                                        Console.ReadKey(true);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("输入格式错误！！请重新输入！！");
                                        LuckyChoose = Console.ReadLine();
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("玩家{0}踩到了地雷，后退6格！！", PlayName[0]);
                                PlayerPos[0] -= 6;
                                Program.CheckPos(0);
                                Console.ReadKey(true);
                                break;
                            case 3:
                                Console.WriteLine("玩家{0}踩到了暂停，暂停一回合！！", PlayName[0]);
                                Flags[0] = true;
                                Console.ReadKey(true);
                                break;
                            case 4:
                                Console.WriteLine("玩家{0}发现了时空隧道，前进10格！！", PlayName[0]);
                                PlayerPos[0] += 10;
                                Program.CheckPos(0);
                                Console.ReadKey(true);
                                break;
                            default:
                                Console.WriteLine("遇到了未知错误！！,按任意键继续");
                                Console.ReadKey(true);
                                break;
                        }//swtich
                    }//if-else
                    Program.CheckPos(0);
                    Program.CheckPos(1);
                    Console.Clear();
                    Program.DrawMap();
                    //Program.PlayGame(PlayerPos[0]);
                    if (PlayerPos[0] >= 99)
                    {
                        //Console.ForegroundColor = ConsoleColor.White;
                        //Console.WriteLine("玩家{0}率先到达终点！！取得胜利", PlayName[0]);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Win(0);
                        break;
                    }
                }
                else
                {
                    Flags[0] = false;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("下一个回合！！！");
                if (Flags[1] == false)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("玩家{0}的回合！！请按任意键掷骰子", PlayName[1]);
                    Console.ReadKey(true);
                    Console.WriteLine("玩家{0}摇到了{1}", PlayName[1], Dice);
                    PlayerPos[1] += Dice;
                    Console.WriteLine("按任意键开始行动");
                    Console.ReadKey(true);
                    if (PlayerPos[1] == PlayerPos[0])
                    {
                        Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退后6格", PlayName[1], PlayName[0], PlayName[0]);
                        PlayerPos[0] -= 6;
                        Program.CheckPos(0);
                        Console.ReadKey(true);
                    }
                    else
                    {
                        switch (map[PlayerPos[1]])
                        {
                            case 0:
                                Console.WriteLine("玩家{0}踩到了平地，神马都没有发生", PlayName[1]);
                                Console.ReadKey(true);
                                break;
                            case 1:
                                Console.WriteLine("玩家{0}踩到了幸运轮盘，按1---交换两个玩家位置，按2---对手后退6格。请选择", PlayName[1]);
                                string LuckyChoose = Console.ReadLine();
                                while (true)
                                {
                                    if (LuckyChoose == "1")
                                    {
                                        int temp = 0;
                                        temp = PlayerPos[1];
                                        PlayerPos[1] = PlayerPos[0];
                                        PlayerPos[0] = temp;
                                        Console.WriteLine("交换成功！！按任意键继续");
                                        Console.ReadKey(true);
                                        break;
                                    }
                                    else if (LuckyChoose == "2")
                                    {
                                        PlayerPos[0] -= 6;
                                        Console.WriteLine("玩家{0}被击退了6格！！按任意键继续", PlayName[0]);
                                        Program.CheckPos(0);
                                        Console.ReadKey(true);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("输入格式错误！！请重新输入！！");
                                        LuckyChoose = Console.ReadLine();
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("玩家{0}踩到了地雷，后退6格！！", PlayName[1]);
                                PlayerPos[1] -= 6;
                                Program.CheckPos(0);
                                Console.ReadKey(true);
                                break;
                            case 3:
                                Console.WriteLine("玩家{0}踩到了暂停，暂停一回合！！", PlayName[1]);
                                Flags[1] = true;
                                Console.ReadKey(true);
                                break;
                            case 4:
                                Console.WriteLine("玩家{0}发现了时空隧道，前进10格！！", PlayName[1]);
                                PlayerPos[1] += 10;
                                Program.CheckPos(1);
                                Console.ReadKey(true);
                                break;
                            default:
                                Console.WriteLine("遇到了未知错误！！,按任意键继续");
                                Console.ReadKey(true);
                                break;
                        }//swtich
                    }//if-else
                    Program.CheckPos(0);
                    Program.CheckPos(1);
                    Console.Clear();
                    Program.DrawMap();
                    if (PlayerPos[1] == 99)
                    {
                        //Console.ForegroundColor = ConsoleColor.White;
                        //Console.WriteLine("玩家{0}率先到达终点！！取得胜利", PlayName[1]);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Win(1);
                        break;
                    }
                }
                else
                {
                    Flags[1] = false;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("下一个回合！！！");
                //Program.PlayGame(PlayerPos[1]);
            }
        }
        /// <summary>
        /// 游戏头
        /// </summary>
        public static void GameHand()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("****羊羊大富翁 v1.0****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************");
        }
        /// <summary>
        /// 地图初始化函数
        /// </summary>
        public static void MapInit()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };
            for (int i = 0; i < luckyturn.Length; i++)
            {
                map[luckyturn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            for (int i = 0; i < landMine.Length; i++)
            {
                map[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };
            for (int i = 0; i < pause.Length; i++)
            {
                map[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                map[timeTunnel[i]] = 4;
            }
        }
        /// <summary>
        /// 地图绘制函数
        /// </summary>
        public static void DrawMap()
        {
            Console.Write("图例：幸运轮盘：");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("√");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    地雷：");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("※");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    暂停：");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("▲");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    时空隧道：");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("卐");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    终点：");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("★");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(DrawStringMap(i));
                Console.WriteLine();
            }
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            for (int i = 65; i < 70; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 地图元素绘制函数
        /// </summary>
        /// <param name="i">当前需要绘制元素的坐标</param>
        /// <returns></returns>
        public static string DrawStringMap(int i)
        {
            string str = "";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
            {
                str = "<>";
            }
            else if (PlayerPos[0] == i)
            {
                str = "1P";
            }
            else if (PlayerPos[1] == i)
            {
                str = "2P";
            }
            else
            {
                switch (map[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "□";//land
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "√";//luckyturn
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "※";//landMine
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "▲";//pause
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "卐";//timeTunnel
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        str = "×";//error
                        break;
                }
            }
            if(i==99)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                str = "★";
            }
            return str;
        }
        /// <summary>
        /// 游戏运行ing
        /// </summary>
        /// <param name="Player">当前行动的玩家</param>
        public static void PlayGame(int Player)
        {
            Random dice = new Random();
            int Dice = dice.Next(1, 7);
            Console.WriteLine("玩家{0}的回合！！请按任意键掷骰子", PlayName[Player]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}摇到了{1}", PlayName[Player], Dice);
            PlayerPos[Player] += Dice;
            Program.CheckPos(Player);
            Console.WriteLine("按任意键开始行动");
            Console.ReadKey(true);
            if (PlayerPos[Player] == PlayerPos[1 - Player])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退后6格", PlayName[Player], PlayName[1 - Player], PlayName[1 - Player]);
                PlayerPos[1 - Player] -= 6;
                Program.CheckPos(1 - Player);
                Console.ReadKey(true);
            }
            else
            {
                switch (map[PlayerPos[Player]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了平地，神马都没有发生", PlayName[Player]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到了幸运轮盘，按1---交换两个玩家位置，按2---对手后退6格。请选择:", PlayName[0]);
                        string LuckyChoose = Console.ReadLine();
                        while (true)
                        {
                            if (LuckyChoose == "1")
                            {
                                int temp = 0;
                                temp = PlayerPos[1];
                                PlayerPos[1] = PlayerPos[0];
                                PlayerPos[0] = temp;
                                Console.WriteLine("交换成功！！按任意键继续");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (LuckyChoose == "2")
                            {
                                PlayerPos[1 - Player] -= 6;
                                Console.WriteLine("玩家{0}被击退了6格！！按任意键继续", PlayName[1 - Player]);
                                Program.CheckPos(1 - Player);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("输入格式错误！！请重新输入！！");
                                LuckyChoose = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷，后退6格！！", PlayName[Player]);
                        PlayerPos[Player] -= 6;
                        Program.CheckPos(Player);
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停，暂停一回合！！", PlayName[Player]);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}发现了时空隧道，前进10格！！", PlayName[Player]);
                        PlayerPos[Player] += 10;
                        Program.CheckPos(Player);
                        break;
                    default:
                        Console.WriteLine("遇到了未知错误！！,按任意键继续");
                        Console.ReadKey(true);
                        break;
                }//swtich
            }//if-else
            Program.CheckPos(0);
            Program.CheckPos(1);
            Console.Clear();
            Program.DrawMap();
        }
        /// <summary>
        /// 玩家坐标合法性检查
        /// </summary>
        /// <param name="Player">玩家号</param>
        public static void CheckPos(int Player)
        {
            if (PlayerPos[Player] < 0)
            {
                PlayerPos[Player] = 0;
            }
            if (PlayerPos[Player] >= 99)
            {
                PlayerPos[Player] = 99;
            }
        }
        /// <summary>
        /// 输出胜利信息
        /// </summary>
        /// <param name="n">玩家编号</param>
        public static void Win(int n)
        {
            Console.WriteLine("恭喜玩家{0}率先到达终点！！", PlayName[n]);
            Console.WriteLine(@"■
                     ■                 ■■■  
        ■■■■  ■  ■            ■■  ■               ■   
        ■    ■  ■  ■                  ■           ■  ■
        ■    ■ ■■■■■■       ■■■■■■■     ■  ■
        ■■■■ ■   ■               ■ ■ ■        ■  ■   
        ■    ■      ■             ■   ■  ■       ■  ■
        ■    ■ ■■■■■■      ■     ■   ■      ■  ■
        ■■■■      ■          ■      ■     ■    ■  ■
        ■    ■      ■                  ■               ■
        ■    ■      ■                  ■               ■
       ■     ■      ■                  ■               ■
      ■    ■■ ■■■■■■■           ■             ■■");
            string endinf;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("请按N键退出");
            endinf=Console.ReadLine();
            while(true)
            {
                if(endinf=="N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("退出失败！请按N键退出：");
                    endinf = Console.ReadLine();
                }
            }
        }
    }
}
