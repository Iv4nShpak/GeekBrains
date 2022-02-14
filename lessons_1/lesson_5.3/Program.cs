using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lesson_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255:");
            string typingNumber = Console.ReadLine();
            
            string[] numberArray = typingNumber.Split();
            byte[] numberArrayBytes = new byte[100];
            
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArrayBytes[i] = Convert.ToByte(numberArray[i]);
            }
            
            File.WriteAllBytes("bytes.bin", numberArrayBytes);
        }

    }
}