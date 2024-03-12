using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3_4;

namespace task3_4
{
    sealed class OneDim<T>: Parent<T>
    {
        private T[] array;

        public OneDim(IValueProvider<T> provider, bool fill = false) : base(provider, fill) { }

        public override void RndFill()
        {
            int n = rnd.Next(1, 11);

            array = new T[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = provider.RandomValue();
            }
        }
        public override void UserFill()
        {
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());

            array = new T[n];

            Console.WriteLine("Введите значения вручную.");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = provider.UserValue();
            }

            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine($"Одномерный массив {array[0].GetType()}:");
            Console.WriteLine(String.Join(" ", array));
        }
    }
}