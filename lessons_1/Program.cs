using System;

namespace lessons_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя: ");
            var name = Console.ReadLine();

            Console.WriteLine($"Привет {name}, сегодня {DateTime.Now}.");

            Console.ReadKey();
        }
    }
}
