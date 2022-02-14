using System;
using System.IO;

namespace lesson_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userText = Console.ReadLine();
            File.WriteAllText("User_Text.txt", userText);
        }
    }
}