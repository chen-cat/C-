using System;
using System.Threading;

namespace _018_线程问题_争用条件和死锁
{
    class Program
    {
        static void ChangeState(object o)
        {
            MyThreadObject mt = o as MyThreadObject;
            while (true)
            {
                lock (mt)//向系统申请可以不可锁定mt对象，如果m对象没有被锁定，那么可以。如果被锁定了，那么这个语句就会被暂停直到申请成功
                {
                    mt.ChangeState();//上锁后，只有一个线程在执行这个方法
                }//释放对mt的锁
            }
        }

        static void Main(string[] args)
        {
            MyThreadObject mt = new MyThreadObject();
            Thread t = new Thread(ChangeState);
            t.Start(mt);

            new Thread(ChangeState).Start(mt);
            Console.ReadKey();
        }
    }
}
