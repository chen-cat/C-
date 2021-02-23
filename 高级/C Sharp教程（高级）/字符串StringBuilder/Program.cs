using System;
using System.Text;

namespace 字符串StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder可以定义字符串的内存大小，只要不超过改大小，都可以改变存储的内容。String则不能改变内容
            //如果需要频繁改变字符串的内容，使用StringBuilder会比string效率高很多
            StringBuilder sb1 = new StringBuilder("www.baidu.com");//利用构造函数创建并初始化StringBuilder的内容
            StringBuilder sb2 = new StringBuilder(20);//初始化一个空的对象，占有20个字符的大小，如果超过20个，就需要申请新的内存
            StringBuilder sb3 = new StringBuilder("www.baidu.com", 100);//初始化对象并占100个字符的大小

            //字符串连接
            sb1.Append("啊撤是子由");
            Console.WriteLine(sb1);
            //插入字符
            sb1.Insert(0, "Q");
            Console.WriteLine(sb1);
            //移除字符
            sb1.Remove(4,1);//4代表开始的索引,1代表移除的个数
            Console.WriteLine(sb1);

            sb1.ToString();//把当前StringBuilder中存储的字符串，提取成一个不可变的字符串

            Console.ReadLine();
        }
    }
}
