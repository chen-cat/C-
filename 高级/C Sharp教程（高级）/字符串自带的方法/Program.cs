using System;

namespace 字符串自带的方法
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "www.baidu.com";
            string s1 = "www.baidu.con";
            //.CompareTo
            int res = s.CompareTo(s1);//返回0代表2者相同，返回1代表s>s1，返回-1代表s1>s
            //.Replace
            string newS = s.Replace(".", "_");
            //.Split
            string[] strArray = s.Split(".");//通过点来切割字符串，返回一个数组
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }
            //.Substring
            string s2 = s.Substring(4, 5);//用于截取索引以后的字符串,4代表开始截取的索引，5代表截取几个字符

            //.IndexOf
            int index = s.IndexOf("baidu");//返回baidu在字符串s中的开始索引

            Console.WriteLine(index);

            Console.ReadKey();
        }
    }
}
