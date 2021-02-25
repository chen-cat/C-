using System;

namespace Action委托
{
    class Program
    {
        static void Method1()
        {
            Console.WriteLine("这里是方法1");
        }
        static void Method2(int a, string b)
        {
            Console.WriteLine("这里是方法2");
        }
        static int Method3()
        {
            Console.WriteLine("这里是方法3");
            return 100;
        }
        static int Method4(int a,bool b)
        {
            Console.WriteLine("这里是方法4");
            return 200;
        }
        static void Main(string[] args)
        {
            Action a = Method1;//Action是系统自带的无返回值的委托
            a();
            Action<int,string> a1 = Method2;
            a1(5, "方法1");
            Func<int> f = Method3;//Func是系统自带的有返回值的委托，<int>代表返回的类型
            f();
            Func<int, bool, int> f1 = Method4;
            Console.WriteLine(f1(4,false));//返回值的类型永远是最后一个

            Console.ReadKey();
        }
    }
}
