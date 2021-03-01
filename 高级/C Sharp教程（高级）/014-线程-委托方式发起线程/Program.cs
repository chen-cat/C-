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
            //检测线程结束方法一
            while (result.IsCompleted == false)
            {
                Console.WriteLine(".");
            }
            int i= a.EndInvoke(result);//取得异步线程的返回值
            Console.WriteLine(i);

            //检测线程结束方法二
            bool isEnd =  result.AsyncWaitHandle.WaitOne(1000);//1000毫秒表示等待最大时间，如果线程超过这个时间还没结束的话返回false
            if (isEnd)
            {
                int b = a.EndInvoke(result);
                Console.WriteLine(b);
            }

            //检测线程结束方法三:回调函数
            Func<int, int> func = Test;
            //倒数第二个参数是一个委托类型的参数，表示回调函数，就是当线程结束的时候调用这个委托指向的方法。倒数第一个参数是用来给回调函数传递数据
            func.BeginInvoke(100, OnCallBack, func);
            //委托改成lambda表达式
            func.BeginInvoke(100,ar =>
            {
                int res = func.EndInvoke(ar);
                Console.WriteLine("在lamba表达式中获取" + res);
            },null);
            //IAsyncResult在使用回调函数的时候系统会自动赋值
            static void OnCallBack(IAsyncResult r)
            {
                Func<int, int> func = r.AsyncState as Func<int, int>;
                int res = func.EndInvoke(r);
                Console.WriteLine("再回调函数中取得结果"+res);
            }

            //线程是同时执行的（异步执行）
            Console.WriteLine("main");

            Console.ReadKey();
        }
     }
}
