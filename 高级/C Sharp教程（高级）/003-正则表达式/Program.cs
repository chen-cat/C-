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

            //判断用户输入的密码是否合法（全部是数字）
            string s1 = Console.ReadLine();
            string pattern = @"^\d*$";//1、@代表取消转移字符的作用，把\d转成元字符 2、\d匹配数字（0-9） 3、*代表0个或多个字符
            //判断是否符合正则表达式的过滤逻辑
            bool isMatsh = Regex.IsMatch(s1,pattern);//返回的是bool值,只有s1字符串有一个满足pattern的逻辑都会返回true,所以要添加"^"（匹配开始）和"$"（匹配结束），不然输入123456abc也会返回true
            Console.WriteLine(isMatsh);

            string pattern1 = @"[abc]";
            Console.WriteLine("有abc字符，原字符：" + s + "替换后：" + Regex.Replace(s, pattern1, "*"));

            string pattern2 = @"[^abc]";
            Console.WriteLine("除了abc的所有字符，原字符：" + s + "替换后：" + Regex.Replace(s, pattern2, "*"));

            string pattern3 = @"[a-o]";
            Console.WriteLine("有a-o的字符，原字符：" + s + "替换后：" + Regex.Replace(s, pattern3, "*"));

            //检验输入的内容是否为合法的QQ号（5-12位数字）
            string qq1 = "2429523276";
            string qq2 = "24295232762429523276";
            string qq3 = "2429523276@qq.com";
            string pattern4 = @"^\d{5,12}$";
            Console.WriteLine(Regex.IsMatch(qq1, pattern4));
            Console.WriteLine(Regex.IsMatch(qq2, pattern4));
            Console.WriteLine(Regex.IsMatch(qq3, pattern4));

            //查找数字或字母
            string s2 = "2354degf*&*% 打过去问";
            string pattern5 = @"\d|[a-z]";
            MatchCollection match =  Regex.Matches(s2, pattern5);//.Matches函数会把所有符合正则表达式的字符过滤出来生成MatchCollection类型（数组）
            foreach (var item in match)
            {
                Console.WriteLine(item);//
            }

            //分割字符
            string s3 = "chen;jian,feng:niu";
            string pattern6 = @"[;,:]";//字符串分割字符只能以一种类型进行分割，所以这里使用正则表达式可以很简单对以多种字符分割
            //string pattern6 = @"[;][,][:]";//代表连续的;,:符号
            //string pattern6 = @"[;]|[,]|[:]";//使用逻辑或"|"运算符
            string[] strAssets =  Regex.Split(s3, pattern6);
            foreach (var item in strAssets)
            {
                Console.Write(item+" ");
            }

            //重复多个字符使用@"（abc）{2}"进行分组设定，等价于@"abcabc"

            Console.ReadKey();
        }
    }
}
