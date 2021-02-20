using System;
using 面向对象编程_定义类;

namespace 匿名类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建变量的时候必须指定类型，其实我们也可以不去指定类型，这个就是匿名类型
            //使用var声明的匿名类型，当初始化的时候，这个变量的类型就被确定下来，并且以后不可以修改
            var a = 100;
            var b = "abc";
            var v1 = new Vector3(2,4,3);//引用其他项目的类需要添加引用并引入其所在的命名空间
        }
    }
}
