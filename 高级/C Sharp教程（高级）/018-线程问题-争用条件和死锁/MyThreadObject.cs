using System;
using System.Collections.Generic;
using System.Text;

namespace _018_线程问题_争用条件和死锁
{
    class MyThreadObject
    {
        private int state = 5;

        public void ChangeState()
        {
            state++;
            if (state == 5)
            {
                Console.WriteLine("两个以上的线程争用，导致state出现等于5的情况");
            }
            state = 5;
        }
    }
}
