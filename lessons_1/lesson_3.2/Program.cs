using System;

namespace lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] telephoneBook = 
            {
                {"Дмитрий", "8(960) 455-88-77"},
                {"Сергей", "8(961) 133-55-11"},
                {"Арсений", "8(962) 222-55-22"},
                {"Евгений", "8(909) 123-44-33"},
                {"Роман", "8(911) 334-83-11"}
            };

            for (int i = 0; i < telephoneBook.GetLength(0); i++)
            {
                for (int j = 0; j < telephoneBook.GetLength(1); j++)
                {
                    Console.Write(telephoneBook[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}