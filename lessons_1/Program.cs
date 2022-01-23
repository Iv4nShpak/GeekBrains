using System;

namespace lessons_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя: "); 
            var name = Console.ReadLine(); //ввод имени пользователем через консоль

            Console.WriteLine($"Привет {name}, сегодня {DateTime.Now}."); //вывод приветствия с актуальной датой на консоль

            Console.ReadKey(); 
        }
    }
}
