using System;

namespace lesson_2._6
{
    class Program
    {
        [Flags]
        public enum DayOfWeek
        {
            Monday = 0b_00000001,
            Tuesday = 0b_00000010,
            Wednesday = 0b_00000100,
            Thursday = 0b_00001000,
            Friday = 0b_00010000,
            Saturday = 0b_00100000,
            Sunday = 0b_01000000,
        }
        static void Main(string[] args)
        {
            DayOfWeek workSchedule1 = DayOfWeek.Monday | DayOfWeek.Tuesday | DayOfWeek.Wednesday | DayOfWeek.Thursday;
            DayOfWeek workSchedule2 = DayOfWeek.Wednesday | DayOfWeek.Thursday | DayOfWeek.Friday | DayOfWeek.Saturday | DayOfWeek.Sunday;
            DayOfWeek workSchedule3 = DayOfWeek.Monday | DayOfWeek.Tuesday | DayOfWeek.Wednesday | DayOfWeek.Thursday | DayOfWeek.Friday;
            DayOfWeek workSchedule4 = DayOfWeek.Tuesday | DayOfWeek.Wednesday | DayOfWeek.Thursday | DayOfWeek.Friday;

            Console.WriteLine("--------------Список офисов:--------------\n|Офис #1|  |Офис #2|  |Офис #3|  " +
                              "|Офис #4|\n \nВведите номер офиса, что бы узнать график его работы:");
            
            int numberOffice = Int32.Parse(Console.ReadLine());

            switch (numberOffice)
            {
                case 1:
                    Console.WriteLine($"Рабочие дни Офиса #1: {workSchedule1}.");
                    break;
                case 2:
                    Console.WriteLine($"Рабочие дни Офиса #2: {workSchedule2}.");
                    break;
                case 3:
                    Console.WriteLine($"Рабочие дни Офиса #3: {workSchedule3}.");
                    break;
                case 4:
                    Console.WriteLine($"Рабочие дни Офиса #4: {workSchedule4}.");
                    break;
                default:
                    Console.WriteLine("Введите номер офиса из списка!");
                    Main(new string[0]);
                    break;
            }

            Console.ReadKey();
        }
    }
}