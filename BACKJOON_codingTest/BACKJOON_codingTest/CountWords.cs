using System;

namespace BACKJOON_codingTest
{
    class CountWords
    {
        static void Main()
        {
            string input = Console.ReadLine().Trim();
            int answer = 0;
            
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                    answer++;
            }
            if(input.Length == 0)
                Console.WriteLine(0);
            else
                Console.WriteLine(answer + 1);
        }
    }

}
