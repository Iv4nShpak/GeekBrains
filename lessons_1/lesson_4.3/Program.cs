using System;

namespace lesson_4._3
{
    class Program
    {
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            unknown
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца: ");
            int monthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetTimeOfYear(TimeOfYear(monthNumber)));
        }

        static Seasons TimeOfYear(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                case 2:
                case 12:
                    return Seasons.Winter;
                case 3:
                case 4:
                case 5:
                    return Seasons.Spring;
                case 6:
                case 7:
                case 8:
                    return Seasons.Summer;
                case 9:
                case 10:
                case 11:
                    return Seasons.Autumn;
                default:
                    return Seasons.unknown;
            }
        }

        static string GetTimeOfYear(Seasons timeOfYear)
        {
            switch (timeOfYear)
            {
                case Seasons.Winter:
                    return "Зима";
                case Seasons.Spring:
                    return "Весна";
                case Seasons.Summer:
                    return "Лето";
                case Seasons.Autumn:
                    return "Осень";
                default:
                    return "Ошибка: введите число от 1 до 12";
            }
        }
    }
}