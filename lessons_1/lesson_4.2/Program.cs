using System;

namespace lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            int resultAll = 0;
            string resultCurrent = "";

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != ' ')
                {
                    resultCurrent += value[i];
                }
                if (value[i] == ' ' || i == value.Length - 1)
                {
                    resultAll += Int32.Parse(resultCurrent);
                    resultCurrent = "";
                }
            }
            Console.WriteLine(resultAll);  
        }
    }
}