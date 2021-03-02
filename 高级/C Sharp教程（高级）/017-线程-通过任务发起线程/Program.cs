using System;
using System.Threading;
using System.Threading.Tasks;

namespace _017_线程_通过任务发起线程
{
    class Program
    {
        static void DownFile()
        {
            Console.WriteLine("开始下载：");
            Thread.Sleep(1000);
            Console.WriteLine("下载完成。");
        }

        static void T1()
        {
            Console.WriteLine("开始T1任务：");
            Thread.Sleep(2000);
            Console.WriteLine("T1任务完成。");
        }
        static void T2(Task t)
        {
            Console.WriteLine("开始T2任务：");
            Thread.Sleep(1000);
            Console.WriteLine("T2任务完成。");
        }
        static void Main(string[] args)
        {
            //声明线程的方法1：
            //任务相当于对线程进行了一层封装
            Task t = new Task(DownFile);//传递一个需要线程去执行的方法
            t.Start();
            Console.WriteLine(t);

            //声明线程的方法2：任务工厂
            TaskFactory tf = new TaskFactory();
            Task t_1 =  tf.StartNew(DownFile);

            //连续任务
            //如果一个任务t1的执行是依赖于另一个任务t2的执行,那么就需要在t2执行完毕后才开始执行t1
            Task t1 = new Task(T1);
            Task t2 = t1.ContinueWith(T2);
            t1.Start();

            //任务层次结构
            /*我们在一个任务中启动一个新的任务，相当于新的任务是当前任务的子任务，两个任务异步执行，如果父任务执行完了但是子任务没有执行完
             * 他的状态会设置为WaitingForChildrenToComple,只有子任务也完成了，父任务的状态就变成RunToCompletion
            */

            Console.ReadKey();
        }
    }
}
