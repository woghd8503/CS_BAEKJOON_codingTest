using System;

namespace BACKJOON_codingTest
{
    class BreakEven
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            if (B >= C)
            {
                Console.WriteLine(-1);
                return;
            }
            else
            {
                int n = A / (C - B);
                Console.WriteLine(n + 1);
            }
        }
    }

}
