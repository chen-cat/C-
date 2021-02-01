using System;
namespace 面向对象编程_定义类
{
    //在这里我们定义了一个新的类
    public class Customer
    {
        //数据成员：包含了4个字段
        public string name;
        public string address;
        public int age;
        public string buyTime;
        //函数成员:定义了一个方法
        public void show()
        {
            Console.WriteLine("名字:"+name);
            Console.WriteLine("地址:" + address);
            Console.WriteLine("年龄:" + age);
            Console.WriteLine("购买时间:" + buyTime);
        }
    }
}
