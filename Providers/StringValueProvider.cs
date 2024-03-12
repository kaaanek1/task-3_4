using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3_4;

namespace task3_4
{
    class StringProvider: IValueProvider<string>
    {
        Random rnd = new Random();

        public string RandomValue()
        {
            string alp = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string let = "";
            for (int i = 0; i < rnd.Next(10); i++)
            {
                let += alp[rnd.Next(alp.Length)];
            }
            return let;
        }

        public string UserValue()
        {
            return Console.ReadLine();
        }
    }
}