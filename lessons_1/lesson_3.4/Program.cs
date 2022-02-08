using System;

namespace lesson_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] seaBattle =
            {
                {'O', 'O', 'O', 'X', 'O', 'X', 'O', 'O', 'O', 'O'},
                {'O', 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O'},
                {'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O'},
                {'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O'},
                {'O', 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O'},
                {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                {'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                {'X', 'O', 'O', 'O', 'O', 'X', 'X', 'X', 'O', 'O'},
                {'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                {'X', 'O', 'X', 'X', 'O', 'O', 'O', 'O', 'O', 'X'}
            };

            for (int i = 0; i < seaBattle.GetLength(0); i++)
            {
                for (int j = 0; j < seaBattle.GetLength(1); j++)
                {
                    Console.Write(seaBattle[i,j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}