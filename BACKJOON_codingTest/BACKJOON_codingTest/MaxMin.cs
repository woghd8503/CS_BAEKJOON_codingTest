using System;

namespace BACKJOON_codingTest
{
    class MaxMin
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string[] input1 = Console.ReadLine().Split();
            int[] inputArray = new int[input];

            for (int i = 0; i < input; i++)
            {
                inputArray[i] = int.Parse(input1[i]);
            }

            Array.Sort(inputArray);


            Console.WriteLine(inputArray[0] + " " + inputArray[input -1]);
        }
    }

}
