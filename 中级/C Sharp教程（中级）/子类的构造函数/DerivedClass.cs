using System;
using System.Collections.Generic;
using System.Text;

namespace 子类的构造函数
{
    class DerivedClass : BaseClass
    {
        private int y;
        public DerivedClass() : base()//子类的无参构造函数会默认调用父类的无参构造函数（即类同名函数）,：base()加不加都可以
        {
            Console.WriteLine("子类的无参构造函数");
        }

        public DerivedClass(int x, int y) : base(x)//有参构造函数必须加上：base(x)，否则会调用父类的无参函数
        {
            this.y = y;
            base.z = 100;//引用父类protected的子段
            Console.WriteLine("子类的有参构造函数，y赋值完成");
        }
    }
}
