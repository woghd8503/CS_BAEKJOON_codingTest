using System;
using System.Linq;


namespace BACKJOON_codingTest
{
    class OXquiz
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            char[] result = new char[count];
            int score = 0;
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                result = input.ToArray();
                sum = 0;
                score = 0;
                for(int j = 0; j < result.Length; j++)
                {
                    if (result[j] == 'O')
                    {
                        score++;
                        sum += score;
                    }
                    else
                        score = 0;
                }
                Console.WriteLine(sum);
            }
        }
    }

}
