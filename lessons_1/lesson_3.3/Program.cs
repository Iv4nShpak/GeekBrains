using System;

namespace lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomText = Console.ReadLine();

            for (int i = randomText.Length - 1; i >= 0; i--)
            {
                Console.Write(randomText[i]);
            }
            Console.WriteLine();
        }
    }
}