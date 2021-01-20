using System;

namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入n个数，找出其中最小的数，将它与最前面的数交换后输出这些数
            string str = Console.ReadLine();//用于接收用户输入的一串数字
            string[] strArray = str.Split(' ');//把字符串用空格的方式切割成字符串数组
            int[] numArray = new int[strArray.Length];//new一个数组用来接收字符串数组
            //使用for循环把字符串数组转换成数组
            for (int i = 0; i < strArray.Length;i++)
            {
                numArray[i] = Convert.ToInt32(strArray[i]);
            }
            int min = numArray[0];//用于比较大小的数
            int minIndex = 0;//获取最小数的索引
            for (int i = 1; i < numArray.Length; i++)
            {
                if (numArray[i]<min)
                {
                    minIndex = i;
                    min = numArray[i];
                }
            }
            //把最小的数跟第一个数交换
            numArray[minIndex] = numArray[0];
            numArray[0] = min;
            
            //使用for循环遍历输出数组
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(numArray[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
