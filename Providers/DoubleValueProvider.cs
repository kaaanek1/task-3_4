using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3_4;

namespace task3_4
{
    class DoubleProvider: IValueProvider<double>
    {
        Random rnd = new Random();
        public double RandomValue()
        {
            return rnd.NextDouble();
        }

        public double UserValue()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}