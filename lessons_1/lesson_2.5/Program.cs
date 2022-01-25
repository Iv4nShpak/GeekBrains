using System;

namespace lesson_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки (°C):");
            int minTemper = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки (°C):");
            int maxTemper = int.Parse(Console.ReadLine());
            int averageTemper = (minTemper + maxTemper) / 2; //рассчёт средней температуры
            Console.WriteLine($"Среднесуточная температура: {averageTemper}°C");
            
            Console.WriteLine("Введите порядковый номер текущего месяца: ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
                default:
                    Console.WriteLine("Укажите значение от 1 до 12");
                    Main(new string[0]);
                    break;
            } 

            if (averageTemper > 0 && (monthNumber == 1 || monthNumber == 2 || monthNumber == 12))
            {
                Console.WriteLine("Дождливая зима");
            }
            
            Console.ReadKey();
        }
    }
}