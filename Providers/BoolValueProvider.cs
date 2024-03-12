using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3_4;

namespace task3_4
{
    class BoolProvider: IValueProvider<bool>
    {
        Random rnd = new Random();
        public bool RandomValue()
        {
            bool[] flags = { true, false };
            return flags[rnd.Next(flags.Length)];
        }

        public bool UserValue()
        {
            return bool.Parse(Console.ReadLine());
        }
    }
}