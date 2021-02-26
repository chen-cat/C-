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
            var res = from m in masterList
                      where m.Level > 8
                      select m;
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }
    }
}
