using System;

namespace task3_4
{
    class Program
    {
        static void Main()
        {
            IPrinter[] arrays = new IPrinter[8];

            IntProvider _int = new();
            StringProvider _string = new();
            BoolProvider _bool = new();
            DoubleProvider _double = new();

            Console.Write("Будешь заполнять массивы сам?(true/false): ");
            bool fill = bool.Parse(Console.ReadLine());

            Console.WriteLine();
            // Console.WriteLine("Порядок массивов: int, string, double, bool");

            OneDim<int> intOneDim = new(_int, fill);
            arrays[0] = intOneDim;
            OneDim<string> stringOneDim = new(_string, fill);
            arrays[1] = stringOneDim;
            OneDim<double> doubleOneDim = new(_double, fill);
            arrays[2] = doubleOneDim;
            OneDim<bool> boolOneDim = new(_bool, fill);
            arrays[3] = boolOneDim;

            Console.WriteLine();

            TwoDim<int> intTwoDim = new(_int, fill);
            arrays[4] = intTwoDim;
            TwoDim<string> stringTwoDim = new(_string, fill);
            arrays[5] = stringTwoDim;
            TwoDim<double> doubleTwoDim = new(_double, fill);
            arrays[6] = doubleTwoDim;
            TwoDim<bool> boolTwoDim = new(_bool, fill);
            arrays[7] = boolTwoDim;

            Console.WriteLine();


            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i].Print();
                Console.WriteLine();
            }
        }
    }
}
