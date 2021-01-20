using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuJuJieGou
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一天悟空吃掉桃子总数一半多一个，第二天又将剩下的桃子吃掉一半多一个，以后每天吃掉前一天剩下的一半多一个，到第n天准备吃的时候只剩下一个桃子，请问他第一天开始吃的时候桃子一共有多少个呢？
            /*int n = Convert.ToInt32(Console.ReadLine());//输入吃了多少天
            int count = 1;//最后一天剩下一个
            for (int i = n-1; i > 0; i--)
            {
                count = (count + 1) * 2;
            }
            Console.WriteLine(count);*/

            //输入n个数，找出其中最小的数，将它与最前面的数交换后输出这些数
            /*string str = Console.ReadLine();//用于接收用户输入的一串数字
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
            Console.ReadKey();*/

            //有n个整数，已经按照从小到大的顺序排列好，现在另外给一个整数x,请将该数插入到序列中，并使新的序列仍然有序
            /*string str = Console.ReadLine();
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
            }*/

            //回文串是一个正读和反读都一样的字符串，比如level,noon等，请写一个判断是否是回文串的程序
            /*string str =  Console.ReadLine();
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
            }*/

            /*要求用户输入一个密码，判断该密码是否是安全的，判断标准为
            1、密码长度大于等于8，且不能超过16
            2、密码中的字符应该包含下面至少3组字符类别
            大写字符：A、B、C...Z
            大写字符：a、b、c...z
            数字：0、1、2...9
            特殊符号：~、！、@*/
            /*Console.WriteLine("请设置你的密码");
            string str = Console.ReadLine();
            bool isSafety = false;
            bool isLength = false;
            int count = 0;

            //Console.WriteLine(Convert.ToInt32('z'));
            do
            {
                if (str.Length >= 8 && str.Length <= 16)
                {
                    isLength = true;
                    bool isHavaUpper = false;
                    bool isHaveLower = false;
                    bool isHaveNumber = false;
                    bool isHaveSpecial = false;
                    for (int i = 0; i < str.Length; i++)
                    {
                        if ((str[i] <= 'z' && str[i] >= 'a'))
                        {
                            isHaveLower = true;
                        }
                        if ((str[i] <= 'Z' && str[i] >= 'A'))
                        {
                            isHavaUpper = true;
                        }
                        if ((str[i] <= 9 && str[i] >= 0))
                        {
                            isHaveNumber = true;
                        }
                        if (str[i] == '~'|| str[i] == '!' || str[i] == '@')
                        {
                            isHaveSpecial = true;
                        }
                    }
                    if (isHavaUpper) count++;
                    if (isHaveLower) count++;
                    if (isHaveNumber) count++;
                    if (isHaveSpecial) count++;
                    if (count>=3)
                    {
                        isSafety = true;
                        Console.WriteLine("你的密码很安全,输入的密码是" + str.Length + "位数");
                    }
                    else
                    {
                        isLength = false;
                        Console.WriteLine("你输入的密码不安全,请重新输入");
                        str = Console.ReadLine();
                    }
                }
                else {
                    isLength = false;
                    Console.WriteLine("你输入的密码不符合长度,请重新输入");
                    str = Console.ReadLine();
                }
                
            } while (!isLength&&!isSafety)*/

            //f(n) = f(n-1)+f(n-2),f(0) = 2,f(1)=3,求f(40)递归调用
            /*int DiGui(int i) {
                if (i == 0) return 2;
                if (i == 1) return 3;
                return DiGui(i - 1) + DiGui(i - 2);
            }
            Console.WriteLine(DiGui(40));*/
            //一个球从100米高度自由落下，每次落地后反跳回原高度的一半，在落下，求它在第十次落地时，共经过多少米？第十次反弹多高？
            /*float height = 100;
            float distance = 0;
            for (int i = 1; i < 10; i++)
            {
                distance += height;
                height /= 2;
                distance += height;
            }
            distance += height;

            Console.WriteLine("共经过" + distance+"第十次反弹"+height) ;*/

            //用递归的方式计算5的阶乘，5的阶乘拆分本质为f(n)= n*f(n-1)
            /*int JieCheng(int i)
            {
                if (i == 1) return 1;
                return i * JieCheng(i - 1);
            }
            Console.WriteLine(JieCheng(5));*/

            //有关系式1*1+2*2+...+k*k<2000,求K的最大值
            /*int sum = 0;
            int index = 0;
            do
            {
                index++;
                sum = index * index + sum;
            } while (sum<2000);
            Console.WriteLine(index-1);*/

            //解决百钱买百鸡的问题，某人100元，要买100只鸡，公鸡5元1只，母鸡3元1只，小鸡1元3只，问可以买到公鸡，母鸡，小鸡多少只，把所以可能打印出来。
            /*for (int i = 0; i <=100/5; i++)//公鸡最多可以买多少只
            {
                for (int j = 0; j <= (100 - 5 * i)/3; j++)
                {
                    int conut = (100 - 5 * i - 3 * j) * 3;
                    if (i+j+conut==100)
                    {
                        Console.WriteLine("公鸡有" + i + "母鸡有" + j + "小鸡有" + conut);
                    }
                }
            }*/

            //异常处理，利用try/catch语句捕捉异常
            Console.WriteLine("请输入一个整数");
            int num = 0;
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());//在try块中，如果有一行代码发生了异常，那么try块中后面的代码都不会执行了
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("你输入的不是一个整数");
                }             
            }
            Console.WriteLine("你输入的整数为："+num);
            Console.ReadKey();
        }
    }
}
