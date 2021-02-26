using System;

namespace _010_观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("汤姆猫","红色");

            Mouse m1 = new Mouse("米奇", "白色",cat);
            //cat.actComing += m1.mouseRun;//太繁琐了，可以在老鼠类的构造方法中加入猫的变量，构造时直接注册方法
            Mouse m2 = new Mouse("艾克", "黑色",cat);
            //cat.actComing += m2.mouseRun;
            cat.catComing();
            
            Console.ReadKey();
        }
    }
}
