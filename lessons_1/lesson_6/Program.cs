using System;
using System.Diagnostics;
using System.Linq;


namespace testLesson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string taskList = "-tasklist";
            string taskKill = "-taskkill";
            string exitTaskManager = "-exit";

            Console.WriteLine("-----------------Task Manager-----------------\n" +
                              "Список команд:\n" +
                              "-tasklist - вывести список активных процессов.\n" +
                              "-taskkill - завершить указанный процесс.\n" +
                              "-exit     - выход из приложения.\n\n" +
                              "Введите команду:");
            string typingCommand = Console.ReadLine();
            if (typingCommand == taskList)
            {
                procList();
                Console.ReadKey();
                Console.WriteLine();
                Main(new string[0]);
            }
            else if (typingCommand == taskKill)
            {
                procKill();
            }else if (typingCommand == exitTaskManager)
            {
                Environment.Exit(0);    
            }
            else
            {
                Console.WriteLine("\nВведена неизвестная команда!\n");
                Console.ReadKey();
                Console.WriteLine();
                Main(new string[0]);
            }
        }

        public static void procList()
        {
            try
            {
                Process[] process = Process.GetProcesses().OrderBy(x=>x.ProcessName).ToArray();
                Console.WriteLine("\nId:\t\tName:\n======\t\t=================");
                for (int i = 0; i < process.Length; i++)
                {
                    Process carrent = process[i];
                    Console.WriteLine($"{carrent.Id}\t\t{carrent.ProcessName}");
                }
                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Ошибка: {exception.Message}");
            }
        }

        public static void procKill()
        {
            try
            {
                Console.WriteLine("Введите имя или Id процесса, что бы его завершить:");
                string nameTask = Console.ReadLine();
                Process[] processes = Process.GetProcesses();
                for (int i = 0; i < processes.Length; i++)
                {
                    Process current = processes[i];
                    if (int.TryParse(nameTask, out int idTask))
                    {
                        if (current.Id == idTask)
                        {
                            current.Kill();
                            Console.WriteLine($"Процесс: {current.ProcessName} - завершен!");
                        }
                    }else if (current.ProcessName == nameTask)
                    {
                        current.Kill();
                        Console.WriteLine($"Процесс: {current.ProcessName} - завершен!");
                    }
                } 
            }
            catch (Exception exeption)
            {
                Console.WriteLine(exeption.Message);
            }
            Console.ReadKey();
            Console.WriteLine();
            Main(new string[0]);
        }

    }
}
