using System;

namespace 插入排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //有n个整数，已经按照从小到大的顺序排列好，现在另外给一个整数x,请将该数插入到序列中，并使新的序列仍然有序
            string str = Console.ReadLine();
            string[] strArray = str.Split(' ');
            int[] numArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                numArray[i] = Convert.ToInt32(strArray[i]);
            }
            for (int j = 0; j < numArray.Length; j++)
            {
                for (int i = 1; i < numArray.Length-j; i++)
                {
                    if (numArray[i - 1] > numArray[i])
                    {
                        int temp = numArray[i];
                        numArray[i] = numArray[i - 1];
                        numArray[i - 1] = temp;
                    }
                }
            }
            int x = Convert.ToInt32(Console.ReadLine());
            int[] newArray = new int[numArray.Length + 1];
            int index = 0;
            bool isInset = false;
            for(int i = 0; i < newArray.Length ; i++)
                {
                if (i==numArray.Length&&isInset == false)
                {
                    newArray[i] = x;
                    isInset = true;
                    break;
                }
                if (x<=numArray[index]&&isInset == false)
                {
                    newArray[i] = x;
                    isInset = true;
                }
                else
                {
                    newArray[i] = numArray[index];
                    index++;
                }
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
