using System;
using System.Collections.Generic;
using System.Text;

namespace 定义和实现接口
{
    interface IB:IA//接口也可以继承，而且同为接口，不需要像类一样需要实现接口的函数
    {
        void MethodB();
    }
}
