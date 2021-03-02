using System;
using System.Threading;

namespace _016_线程_通过线程池发起线程
{
    class Program
    {
        static void DownFile(object o)
        {
            Console.WriteLine("开始下载：" + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            Console.WriteLine("下载完成。");
        }
        static void Main(string[] args)
        {
            /*线程池中的所有线程都是后台线程
             * 如果所有的前台进程都结束了，后台进程也会停止
             * 不能把入池的线程改为前台线程
             * 不能给入池的线程设置优先级和名称
             * 一般入池的线程都是时间较短的任务
            */
            ThreadPool.QueueUserWorkItem(DownFile);//开启一个工作线程
            ThreadPool.QueueUserWorkItem(DownFile);
            ThreadPool.QueueUserWorkItem(DownFile);
            ThreadPool.QueueUserWorkItem(DownFile);
            ThreadPool.QueueUserWorkItem(DownFile); 
            ThreadPool.QueueUserWorkItem(DownFile);
            ThreadPool.QueueUserWorkItem(DownFile);
            Console.ReadKey();
        }
    }
}
