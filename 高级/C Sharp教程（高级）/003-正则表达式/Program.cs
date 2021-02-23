using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _003_正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            /*正则表达式的功能：
            1、检索：通过正则表达式，从字符串中获取我们想要的部分
            2、匹配：判断给定的字符串是否符合正则表达式的过滤逻辑*/

            string s = "I am blue cat.";
            //1、Regex是位于System.Text.RegularExpressions的一个类 2、s代表要替换的字符串，"^"代表正则表达式的元字符（过滤逻辑），"开始："新的字符串
            string res = Regex.Replace(s, "^", "开始：");//元字符"^"匹配开始
            string res1 = Regex.Replace(s, "$", "结束");//元字符"$"匹配结束。这两个元字符统称为定位元字符

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
