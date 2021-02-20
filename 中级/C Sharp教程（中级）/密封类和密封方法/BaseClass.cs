using System;
using System.Collections.Generic;
using System.Text;

namespace 密封类和密封方法
{
    /*sealed class BaseClass
    {

    }*/
    class BaseClass
    {
        public virtual void Move()
        {
            Console.WriteLine("虚方法");
        }
    }
}
