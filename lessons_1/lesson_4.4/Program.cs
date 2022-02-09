using System;

namespace lesson_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine($"Result: {Fibonachi(value)}");
        }

        static int Fibonachi(int value)
        {
            if (value == 0)
                return 0;
            if (value == 1)
                return 1;
            else
                return Fibonachi(value - 1) + Fibonachi(value - 2);
        }
    }
}