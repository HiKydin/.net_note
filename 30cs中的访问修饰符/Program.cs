using System;

namespace _30cs中的访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            //public:公开的公共的
            //private:私有的，只能在当前类的内部访问
            //protected:受保护的，只能在当前类的内部以及该类的子类中访问
            //internal:只能在当前程序集中访问。在同一个项目中，internal和public的权限是一样的
            

            //1、能够修饰类的访问修饰符只有两个：public 和internal
            //2、可访问性不一致：子类的访问权限不能高于父类的访问权限，会暴露父亲的成员
        }
    }
}
