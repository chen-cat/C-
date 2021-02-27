using System;
using System.Collections.Generic;
using System.Linq;

namespace _011_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化武林高手
            var masterList = new List<MartialArtsMaster>()
            {
                new MartialArtsMaster(){ Id = 1,Name = "黄蓉",Age = 18,Menpai = "丐帮",Kongfu = "打狗棒法",Level = 9 },
                new MartialArtsMaster(){ Id = 2,Name = "洪七公",Age = 70,Menpai = "丐帮",Kongfu = "打狗棒法",Level = 10 },
                new MartialArtsMaster(){ Id = 3,Name = "郭靖",Age = 22,Menpai = "丐帮",Kongfu = "降龙十八掌",Level = 10 },
                new MartialArtsMaster(){ Id = 4,Name = "任我行",Age = 50,Menpai = "明教",Kongfu = "葵花宝典",Level = 1 },
                new MartialArtsMaster(){ Id = 5,Name = "东方不败",Age = 35,Menpai = "明教",Kongfu = "葵花宝典",Level = 10 },
                new MartialArtsMaster(){ Id = 6,Name = "林平之",Age = 23,Menpai = "华山",Kongfu = "葵花宝典",Level = 7 },
                new MartialArtsMaster(){ Id = 7,Name = "岳不群",Age = 50,Menpai = "华山",Kongfu = "葵花宝典",Level = 8 },
                new MartialArtsMaster(){ Id = 8,Name = "令狐冲",Age = 23,Menpai = "华山",Kongfu = "独孤九剑",Level = 10 },
                new MartialArtsMaster(){ Id = 9,Name = "梅超风",Age = 23,Menpai = "桃花岛",Kongfu = "九阴真经",Level = 8 },
                new MartialArtsMaster(){ Id = 10,Name = "黄药师",Age = 42,Menpai = "梅花岛",Kongfu = "弹指神通",Level = 10 },
                new MartialArtsMaster(){ Id = 11,Name = "风清扬",Age = 38,Menpai = "华山",Kongfu = "独孤九剑",Level = 10 }
            };

            //初始化功夫
            var kongfuList = new List<Kongfu>()
            {
                new Kongfu(){ Id = 1,Name = "打狗棒法",Power = 90},
                new Kongfu(){ Id = 2,Name = "降龙十八掌",Power = 95},
                new Kongfu(){ Id = 3,Name = "葵花宝典",Power = 100},
                new Kongfu(){ Id = 4,Name = "独孤九剑",Power = 100},
                new Kongfu(){ Id = 5,Name = "九阴真经",Power = 100},
                new Kongfu(){ Id = 6,Name = "弹指神通",Power = 100},
            };

            //查询所有武学级别大于8的武林高手
            /*var res = new List<MartialArtsMaster>();
            foreach (var item in masterList)
            {
                if (item.Level>8)
                {
                    res.Add(item);
                }
            }*/

            //使用LINQ
            /*var res = from m in masterList//from后面设置查询的集合
                      where m.Level > 8 &&m.Menpai =="丐帮"//查询条件，过滤的作用
                      select m;//表示m的结果结合返回*/

            //扩展方法的写法
            //var res = masterList.Where(Text);//1、使用带返回值的委托方法Text，遍历masterList，获得符合Text方法返回ture的参数
            //var res = masterList.Where(m => m.Level > 8);//使用lambda表达式，减少委托方法的定义。m是masterList类型的形参
            var res = masterList.Where(m => m.Level > 8 && m.Menpai =="丐帮");//使用两个判断，用&&来连接
            foreach (var item in res)
            {
                //Console.WriteLine(item);
            }

            //使用LINQ联合查询（查询两个集合），输出杀伤力大于90的武林高手
            /*var res1 = from m in masterList
                       from k in kongfuList
                       where m.Kongfu == k.Name && k.Power > 90
                       //select new { masterList = m,kongfuList = k};//生成一个新的集合
                       select m;*/
            //扩展方法的写法
            var res1 = masterList.SelectMany(m => kongfuList, (m, k) => new { master = m, kongfu = k }).Where(x => x.master.Kongfu == x.kongfu.Name && x.kongfu.Power > 90);
            foreach (var item in res1)
            {
                //Console.WriteLine(item);
            }

            //使用LINQ对查询结果进行排序orderby(从小到大)
            /*var res2 = from m in masterList
                       where m.Level > 8 && m.Menpai == "丐帮"
                       //orderby m.Age,m.Level;//从小到大,按照多个字段进行排序，如果第一个字段相同，再按照第二个字段排序
                        orderby m.Age descending//从大到小
                       //select new { masterList = m,kongfuList = k};//生成一个新的集合
                       select m;*/
            //扩展方法
            //var res2 = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮").OrderBy(m => m.Age).ThenBy(m =>m.Level);//多个字段用.ThenBy
            //使用join on 集合联合查询
            var res2 = from m in masterList
                       join k in kongfuList on m.Kongfu equals k.Name//from联合第一个集合，join联合第二个集合，on用来判断联合条件，where添加过滤条件
                       where k.Power>95
                       select new { master = m, kongfu = k };
            foreach (var item in res2)
            {
                //Console.WriteLine(item);
            }
            //分组查询into groups（把武林高手按照所学功夫分类，看一下那个功夫修炼的人数最多）
            var res3 = from k in kongfuList//这里from接的是kongfuList，因为这里要考虑一对多的关系，多个武林高手学习一门功夫
                       join m in masterList on k.Name equals m.Kongfu
                       into groups//这一句代表创建了一个新的集合
                       orderby groups.Count()//以groups的元素个数进行从小到大排序
                       select new { kongfu = k, count = groups.Count() };//groups.Count()获得新集合的元素个数
            foreach (var item in res3)
            {
                //Console.WriteLine(item);
            }

            //按照自身字段进行分组group（只有一个集合），查找同一个门派的分别有多少人
            var res4 = from m in masterList
                       group m by m.Menpai//by后面接的是分组的条件
                       into groups//into接的是分类后生成的集合
                       orderby groups.Count()
                       select new { count = groups.Count(), k = groups.Key };//获取集合的元素个数，groups.Key代表这个集合的分类条件
            foreach (var item in res4)
            {
                //Console.WriteLine(item);
            }

            //使用量词操作符any，all判断集合中是否满足某个条件
            bool b1 =  masterList.Any(m => m.Menpai == "丐帮");//.Any(带返回值的委托)，判断m集合里面是否有一个或以上的元素满足丐帮的，有返回true
            Console.WriteLine(b1);
            bool b2 = masterList.All(m => m.Menpai == "丐帮");//.All(带返回值的委托)，判断m集合里面是否所以的元素都满足丐帮的，是返回true
            Console.WriteLine(b2);


            //扩展方法的带返回值的委托方法
            static bool Text(MartialArtsMaster m)
            {
                if (m.Level>8)
                {
                    return true;
                }
                return false;
            }

            Console.ReadKey();
        }
    }
}
