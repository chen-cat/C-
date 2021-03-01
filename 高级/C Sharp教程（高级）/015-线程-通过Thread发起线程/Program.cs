using System;
using System.Threading;

namespace _015_线程_通过Thread发起线程
{
    class Program
    {
        static void DownloadFile()
        {
            //Thread.CurrentThread.ManagedThreadId线程ID
            Console.WriteLine("开始下载："+Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("下载完成。");
        }

        static void DownloadFile1(object filename)
        {
            Console.WriteLine("开始下载：" + filename);
            Thread.Sleep(2000);
            Console.WriteLine("下载完成。");
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(DownloadFile);//创建Thread对象，这个线程并没有启动
            t.Start();
            //使用lambda
            Thread t1 = new Thread(() =>
            {
                Console.WriteLine("开始下载1：" + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(2000);
                Console.WriteLine("下载完成1。");
            });
            t1.Start();

            //传递参数的方式1:
            Thread t2 = new Thread(DownloadFile1);//创建Thread对象，这个线程并没有启动
            t2.Start("xxx.种子");
            //传递参数的方式2:
            MyThread my = new MyThread("xxx", "www.baidu.com");
            //当我们构造一个Thread对象的时候，不但可以传递一个静态方法，也可以传递一个对象的普通方法
            Thread t3 =  new Thread(my.DownFile);
            t3.Start();

            Console.WriteLine("main");

            //前台线程和后台线程
            /*只要有一个前台线程在运行，应用程序的进程就在运行，即使main方法已经结束
             * 在默认的情况下，用Thread类创建的线程是前台线程，线程池中的线程总是后台线程
             * 当所有前台线程运行完毕，如果还有后台线程运行的话，所有的后台线程会被终止掉
             */
            Thread t4 = new Thread(DownloadFile);//创建Thread对象，这个线程并没有启动
            t4.IsBackground = true;//设置为后台进程
            t4.Start();
            //t4.Abort();//停止线程
            t4.Join();//当前线程睡眠，等待t4线程执行完毕，然后再继续运行下面的代码
            Console.WriteLine("等待t4完成。");


        }
    }
}
