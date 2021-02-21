using System;
using System.Collections.Generic;

namespace 列表List的创建和使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //列表的创建方式
            List<int> scoreList = new List<int>();
            var scoreList1 = new List<int>();
            var scoreList2 = new List<int>() { 3, 2, 4,1};//初始数据

            scoreList.Add(1);//数据插入
            Console.WriteLine(scoreList[0]);//根据索引访问数据
            //Console.WriteLine(scoreList[1]);//超出索引会出现异常

            Console.WriteLine(scoreList.Count);//结果：1，列表元素个数
            Console.WriteLine(scoreList.Capacity);//结果：4,存储数组的长度大小即列表容量

            Console.WriteLine(scoreList.IndexOf(1));//取得指定元素所在列表中的索引位置
            Console.WriteLine(scoreList2.LastIndexOf(2));//从后往前搜索

            scoreList2.Sort();//升序排序
            scoreList2.Reverse();//反转排序
            foreach (var item in scoreList2)
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadKey();
        }
    }
}
