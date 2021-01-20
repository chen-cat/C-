using System;

namespace 猴子吃桃
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一天悟空吃掉桃子总数一半多一个，第二天又将剩下的桃子吃掉一半多一个，以后每天吃掉前一天剩下的一半多一个，到第n天准备吃的时候只剩下一个桃子，请问他第一天开始吃的时候桃子一共有多少个呢？
            int n = Convert.ToInt32(Console.ReadLine());//输入吃了多少天
            int count = 1;//最后一天剩下一个
            for (int i = n - 1; i > 0; i--)
            {
                count = (count + 1) * 2;
            }
            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
