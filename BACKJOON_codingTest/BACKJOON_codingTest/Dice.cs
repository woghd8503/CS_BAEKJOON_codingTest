using System;

namespace BACKJOON_codingTest
{
    class Dice
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int[] DiceNum = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                DiceNum[i] = int.Parse(input[i]);
            }

            if (DiceNum[0] == DiceNum[1] && DiceNum[1] == DiceNum[2])
                Console.WriteLine(10000 + (DiceNum[1] * 1000));
            else
            {

                if (DiceNum[0] == DiceNum[1])
                    Console.WriteLine(1000 + (DiceNum[1] * 100));

                if (DiceNum[1] == DiceNum[2])
                    Console.WriteLine(1000 + (DiceNum[1] * 100));

                if (DiceNum[0] == DiceNum[2])
                    Console.WriteLine(1000 + (DiceNum[2] * 100));
            }

            if (DiceNum[0] != DiceNum[1] && DiceNum[1] != DiceNum[2] && DiceNum[0] != DiceNum[2])
            {
                Array.Sort(DiceNum);
                Console.WriteLine(DiceNum[input.Length - 1] * 100);
            }
        }
    }

}
