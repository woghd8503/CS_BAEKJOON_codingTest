using System;

namespace BACKJOON_codingTest
{
    class FindFraction
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int level = 1;
            int temp = 1;

            while(temp < input)
            {
                level++;
                temp = temp + level;
            }

            int den = temp - input + 1;

            if (level % 2 == 0)
                Console.WriteLine((level + 1 - den) + "/" + den);
            else
                Console.WriteLine(den + "/" + (level + 1 - den));
        }
    }

}
