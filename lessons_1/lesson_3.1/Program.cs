using System;

namespace lesson_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbersArray = new int [5, 5] 
            {
                {3,7,4,9,3},
                {5,1,8,4,6},
                {7,5,5,3,2},
                {9,6,2,1,1},
                {2,6,9,3,7}
            };
             

            for (int i = 0; i < numbersArray.GetLength(0); i++)
            {
                for (int j = 0; j < numbersArray.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(numbersArray[i, j] + " ");
                    }
                }
            }
            
            
        }
    }
}