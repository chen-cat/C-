using System;

namespace 回文串
{
    class Program
    {
        static void Main(string[] args)
        {
            //回文串是一个正读和反读都一样的字符串，比如level,noon等，请写一个判断是否是回文串的程序
            string str =  Console.ReadLine();
            bool isHui = true;
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i]!=str[str.Length-1-i])
                {
                    isHui = false;
                    break;
                }
            }
            if (isHui)
            {
                Console.WriteLine("是回文串");
            }
            else
            {
                Console.WriteLine("不是回文串");
            }

            Console.ReadLine();
        }
    }
}
