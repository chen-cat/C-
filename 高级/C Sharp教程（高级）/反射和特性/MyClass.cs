using System;
using System.Collections.Generic;
using System.Text;

namespace 反射和特性
{
    class MyClass
    {
        private int age;
        private string name;
        public int Age { get; set; }
        public string Name { get; set; }
        public int number;
        public void Method1()
        {
            Console.WriteLine("这里是方法1");
        }
        public void Method2()
        {
            Console.WriteLine("这里是方法2");
        }
    }
}
