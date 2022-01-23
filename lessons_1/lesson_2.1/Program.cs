using System;

namespace lesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки (°C):");
            int minTemper = int.Parse(Console.ReadLine()); //ввод минимального числа пользователем
            
            Console.WriteLine("Введите максимальную температуру за сутки (°C):");
            int maxTemper = int.Parse(Console.ReadLine()); //ввод максимального числа пользователем
            
            int averageTemper = (minTemper + maxTemper) / 2; //рассчет среднего значения
            
            Console.WriteLine($"Среднесуточная температура: {averageTemper}°C"); //вывод среднего числа на консоль
            Console.ReadKey();
        }
    }
}