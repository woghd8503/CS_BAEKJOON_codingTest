using System;

namespace BACKJOON_codingTest
{
    class HoneyComb
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int cnt = 1; 
            long range = 1; 
            long temp = 1; 

            while (true)
            {
                if (range >= input) 
                {
                    break;
                }
                temp = 6 * cnt++; 
                range += temp; 
            }
            Console.WriteLine(cnt);
        }
    }

}
