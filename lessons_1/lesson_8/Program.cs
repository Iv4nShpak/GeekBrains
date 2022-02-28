using System;

namespace lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = Properties.Settings.Default.Hello;
            Console.WriteLine(welcome);

            try
            {
                if (string.IsNullOrEmpty(Properties.Settings.Default.NameUser))
                {
                    Console.Write("Введите имя: ");
                    Properties.Settings.Default.NameUser = Console.ReadLine();
                    Properties.Settings.Default.Save();
                }
                if (Properties.Settings.Default.AgeUser == 0)
                {
                    Console.Write("Введите возраст: ");
                    Properties.Settings.Default.AgeUser = int.Parse(Console.ReadLine());
                    Properties.Settings.Default.Save();
                }
                if (string.IsNullOrEmpty(Properties.Settings.Default.TypeOfActivity))
                {
                    Console.Write("Введите род деятельности: ");
                    Properties.Settings.Default.TypeOfActivity = Console.ReadLine();
                    Properties.Settings.Default.Save();
                }

                string nameUser = Properties.Settings.Default.NameUser;
                int ageUser = Properties.Settings.Default.AgeUser;
                string typeOfActivity = Properties.Settings.Default.TypeOfActivity;
                Console.WriteLine($"Пользоваетль: {nameUser}\nВозраст: {ageUser}\nРод деятельсности: {typeOfActivity}");
                Console.ReadKey();

                Console.WriteLine("Для удаления пользователя введите команду: delete");
                string deleteUser = Console.ReadLine();
                if (deleteUser == "delete")
                {
                    Properties.Settings.Default.NameUser = "";
                    Properties.Settings.Default.AgeUser = 0;
                    Properties.Settings.Default.TypeOfActivity = "";
                    Properties.Settings.Default.Save();
                }

            }
            catch (Exception exeption)
            {
                Console.WriteLine(exeption.Message);
            }
        }
    }
}
