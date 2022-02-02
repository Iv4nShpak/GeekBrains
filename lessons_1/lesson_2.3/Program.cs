using System;

namespace lesson_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
                        int userNumber = int.Parse(Console.ReadLine());
            
                        int calculatedNumber = userNumber % 2;
            
                        if (calculatedNumber == 0)
                        {
                            Console.WriteLine("Введенное число является чётным.");
                        }
                        else
                        {
                            Console.WriteLine("Введенное число является нечётным.");
                        }
            
                        Console.ReadKey();
        }
    }
}