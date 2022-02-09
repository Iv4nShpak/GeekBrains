using System;

namespace lesson_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName_1 = "Антон";
            string patronymic_1 = "Павлович";
            string lastName_1 = "Чехов";

            string firstName_2 = "Александр";
            string patronymic_2 = "Сергеевич";
            string lastName_2 = "Пушкин";
            
            string firstName_3 = "Лев";
            string patronymic_3 = "Николаевич";
            string lastName_3 = "Толстой";
            
            Console.WriteLine(GettFullName(firstName_1, lastName_1, patronymic_1));
            Console.WriteLine(GettFullName(firstName_2, lastName_2, patronymic_2));
            Console.WriteLine(GettFullName(firstName_3, lastName_3, patronymic_3));
        }

        static string GettFullName(string firstName, string lastName, string patronymic)
        {
            return  lastName + " " + firstName + " " + patronymic;
        }
    }
}