using System;

namespace _12里氏转换练习
{

    //每次运行程序，都会有不同的输出
    class Program
    {
        static void Main(string[] args)
        {
            Preson[] P = new Preson[5];
            Random r = new Random();
            for(int i=0;i<P.Length;i++)
            {
                int rMember = r.Next(1, 4);
                switch(rMember)
                {
                    case 1:
                        P[i] = new Student();
                        break;
                    case 2:
                        P[i] = new Meilv();
                        break;
                    case 3:
                        P[i] = new Teacher();
                        break;
                    default:
                        P[i] = new Preson();
                        break;
                }
            }
            for(int i=0;i<P.Length; i++)
            {
                if(P[i] is Student)
                {
                    ((Student)P[i]).StudentSayHello();
                }
                else if(P[i] is Teacher)
                {
                    ((Teacher)P[i]).TeacherSayHello();//两个括号是重点
                }
                else if(P[i] is Meilv)
                {
                    ((Meilv)P[i]).MeilvSayHello();
                }
                else
                {
                    P[i].SayHello();
                }
            }
        }
    }
}
