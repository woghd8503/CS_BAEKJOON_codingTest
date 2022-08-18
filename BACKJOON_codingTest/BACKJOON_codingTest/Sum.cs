using System;

namespace BACKJOON_codingTest
{
    class Sum
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= input; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }

}
