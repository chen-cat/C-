using System;
using System.Threading;
using System.Threading.Tasks;

namespace _014_线程_委托方式发起线程
{
    class Program
    {
        //一般我们会为比较耗时的操作开启单独的线程去执行，比如下载操作
        static int Test(int i)
        {
            Console.WriteLine("Test"+i);
            Thread.Sleep(100);//让该线程暂停，单位是ms
            return 100;
        }

        static void Main(string[] args)//在mian线程中执行一个线程，里面语句的执行是从上到下的
        {
            //1、通过委托开启一个线程
            //Action<int> a = Test;
            Func<int,int> a = Test;
            //开启一个新的线程去执行a所引用的方法。.BeginInvoke的委托有参数的话，参数放在第一个变量
            IAsyncResult result =  a.BeginInvoke(100,null,null);//IAsyncResult可以获得线程的状态
            while (result.IsCompleted == false)
            {
                Console.WriteLine(".");
            }
            int i= a.EndInvoke(result);//取得异步线程的返回值
            Console.WriteLine(i);

            //线程是同时执行的（异步执行）
            Console.WriteLine("main");

            Console.ReadKey();
        }
     }
}
