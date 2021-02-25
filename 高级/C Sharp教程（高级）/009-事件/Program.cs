using System;

namespace _009_事件
{
    class Program
    {
        public delegate void MyDelgate();
        public MyDelgate mydelgate;//声明一个委托类型的变量，作为类的成员
        public event MyDelgate myEvent;//声明一个事件
        static void Main(string[] args)
        {
            Program p = new Program();
            p.mydelgate = Method1;
            p.mydelgate();

            p.myEvent = Method1;
            p.myEvent();//事件用法跟原来的委托没什么区别


            //委托跟事件的区别
            //event MyDelgate myEvent;事件只能作为类的成员成名

            Console.ReadKey();
        }
        static void Method1()
        {
            Console.WriteLine("这里是方法1");
        }
    }
}