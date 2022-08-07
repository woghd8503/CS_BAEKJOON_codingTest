using System;

namespace BACKJOON_codingTest
{
    class MaxValue
    {
        static void Main()
        {
            int totalCount = 9;
            int[] numbers = new int[totalCount];
            int maxValue = 0;
            int count = 0;

            for(int i = 0; i < totalCount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < totalCount; i++)
            {
                if(maxValue < numbers[i])
                {
                    maxValue = numbers[i];
                    count = i + 1;
                }
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(count);
        }
    }

}
