using System;
using System.Collections.Generic;
using System.Text;

namespace 子类的构造函数
{
    class BaseClass
    {
        private int x;

        public BaseClass()
        {
            Console.WriteLine("父类的无参构造函数");
        }

        public BaseClass(int x)
        {
            this.x = x;
            Console.WriteLine("父类的有参构造函数,x赋值完成");
        }
    }
}
