using System;

namespace BACKJOON_codingTest
{
    class SmallerThanX
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int count = int.Parse(input[0]);
            int standardNum = int.Parse(input[1]);
            string[] input1 = Console.ReadLine().Split();

            for(int i = 0; i < count; i++)
            {
                if (int.Parse(input1[i]) >= standardNum)
                    continue;
                else
                    Console.Write(input1[i] + " ");
            }
        }
    }

}
