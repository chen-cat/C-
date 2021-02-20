using System;
using System.Collections.Generic;
using System.Text;

namespace 密封类和密封方法
{
    /*class DerivedClass:BaseClass//sealed密封类无法被继承
    {

    }*/
    class DerivedClass : BaseClass
    {
        public sealed override void Move()//只有重写函数才能被声明为密封函数，表示该函数不能再被重写
        {
            Console.WriteLine("重写了父类的move函数并把该函数设置为密封函数");
        }
    }

    //使用密封类和密封函数的情景：1、防止重写某些类或函数导致代码混乱 2、商业原因
}
