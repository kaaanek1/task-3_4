using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3_4;

namespace task3_4
{
    sealed class TwoDim<T>: Parent<T>
    {
        private T[,] array;

        public TwoDim(IValueProvider<T> provider, bool fill = false) : base(provider, fill) { }

        public override void RndFill()
        {
            int n = rnd.Next(1, 11);
            int m = rnd.Next(1, 11);

            array = new T[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = provider.RandomValue();
                }
            }
        }
        public override void UserFill()
        {
            Console.WriteLine("Введите кол-во подмассивов:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину подмассивов:");
            int m = int.Parse(Console.ReadLine());

            array = new T[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    array[i, j] = provider.UserValue();
                }
            }

            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine($"Двумерный массив [{array[0, 0].GetType()}]:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}