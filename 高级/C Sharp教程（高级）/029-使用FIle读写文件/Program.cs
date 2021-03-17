using System;
using System.IO;

namespace _029_使用FIle读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取文件，把每一行文本返回一个字符串，最好组成一个字符串数据
            string[] strArray =  File.ReadAllLines("TextFile1.txt");
            foreach (var item in strArray)
            {
                //Console.WriteLine(item);
            }
            //读取文件，把所有内容读取返回一个字符串
            string s = File.ReadAllText("TextFile1.txt");
            Console.WriteLine(s);
            //读取文件，返回字节数组
            byte[] byteArray = File.ReadAllBytes("11.jpg");
            foreach (var item in byteArray)
            {
                //Console.WriteLine(item);
            }
            //创建或者重写一个文件
            File.WriteAllText("TextFile2.txt", "你好");
            File.WriteAllBytes("22.jpg", byteArray);

            Console.ReadKey();
        }
    }
}
