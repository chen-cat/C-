using System;

namespace _006_升级版冒泡排序
{
    class Program
    {
        static void Sort(int[] array)
        {
            bool isCertain = true;
            int count = 0;
            do
            {
                isCertain = false;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i]>array[i+1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        count++;
                        isCertain = true;
                    }
                }
            } while (isCertain);
            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            int[] sortArray = new int[] { 23, 34, 12, 18};
            Sort(sortArray);
            for (int i = 0; i < sortArray.Length; i++)
            {
                Console.Write(sortArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
