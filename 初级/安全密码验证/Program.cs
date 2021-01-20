using System;

namespace 安全密码验证
{
    class Program
    {
        static void Main(string[] args)
        {
            /*要求用户输入一个密码，判断该密码是否是安全的，判断标准为
            1、密码长度大于等于8，且不能超过16
            2、密码中的字符应该包含下面至少3组字符类别
            大写字符：A、B、C...Z
            大写字符：a、b、c...z
            数字：0、1、2...9
            特殊符号：~、！、@*/
            Console.WriteLine("请设置你的密码");
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
                        if (str[i] == '~' || str[i] == '!' || str[i] == '@')
                        {
                            isHaveSpecial = true;
                        }
                    }
                    if (isHavaUpper) count++;
                    if (isHaveLower) count++;
                    if (isHaveNumber) count++;
                    if (isHaveSpecial) count++;
                    if (count >= 3)
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
                else
                {
                    isLength = false;
                    Console.WriteLine("你输入的密码不符合长度,请重新输入");
                    str = Console.ReadLine();
                }

            } while (!isLength && !isSafety);
            Console.ReadLine();
        }
    }
}
