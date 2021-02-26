using System;
using System.Collections.Generic;
using System.Text;

namespace _011_LINQ
{
    class Kongfu
    {
        public int Id { get; set; }
        public int Power { get; set; }
        public String Name { get; set; }
        public override string ToString()
        {
            return string.Format("Id:{0},Power:{1},Name:{2}", Id, Power,Name);
        }
    }
}
