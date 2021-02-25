using System;

namespace _007_多播委托
{
    class Program
    {
        static void Method1()
        {
            Console.WriteLine("这里是方法1");
            //throw new Exception();//抛出异常，如果多播委托其中一个方法有异常，整个委托过程就会停止
        }
        static void Method2()
        {
            Console.WriteLine("这里是方法2");
        }
        static void Main(string[] args)
        {
            //多播委托只能得到调用的最后一个方法的结果，所以多播委托的返回类型一般是声明为void
            Action a = Method1;
            a += Method2;
            if (a!=null)//当一个委托没有指向任何方法的时候，调用的话会出现异常
            {
                a();//调用方法的顺序为注册方法的先后
            }

            //取得多播委托的所有方法
            Delegate[] de = a.GetInvocationList();//返回Delegate的数组
            foreach (Delegate item in de)
            {
                item.DynamicInvoke();
            }

            Console.ReadKey();
        }
    }
}
