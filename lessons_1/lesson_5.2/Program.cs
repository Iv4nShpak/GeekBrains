using System;
using System.IO;

namespace lesson_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string newDate = DateTime.Now.ToLongTimeString();
            File.AppendAllText("startup.txt", $"Текущее время: {newDate}");
            File.AppendAllText("startup.txt", Environment.NewLine);
        }
    }
}