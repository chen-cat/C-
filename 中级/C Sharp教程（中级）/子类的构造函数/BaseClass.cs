using System;
using System.Collections.Generic;
using System.Text;

namespace 子类的构造函数
{
    class BaseClass
    {
        private int x;
        protected int z;//自身以及子类能够使用，别的类不可使用
        public static int a;//静态字段，只能通过类名访问
        public int b;
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
