using System;

namespace BACKJOON_codingTest
{
    class Chess
    {
        static void Main()
        {
            int[] chessNum = new int[6] { 1, 1, 2, 2, 2, 8 };

            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
                chessNum[i] -= int.Parse(input[i]);

            for (int i = 0; i < input.Length; i++)
                Console.Write(chessNum[i] + " ");
        }
    }

}
