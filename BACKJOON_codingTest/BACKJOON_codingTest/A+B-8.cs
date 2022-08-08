using System;

namespace BACKJOON_codingTest
{
    class A_B_8
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                String[] input = Console.ReadLine().Split();

                Console.WriteLine($"Case #{i + 1}: {int.Parse(input[0])} + {int.Parse(input[1])} = {int.Parse(input[0]) + int.Parse(input[1])}");
            }
        }
    }

}
