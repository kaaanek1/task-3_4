using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3_4;

namespace task3_4
{
    class IntProvider: IValueProvider<int>
    {
        Random rnd = new Random();
        public int RandomValue()
        {
            return rnd.Next(100);
        }

        public int UserValue()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}