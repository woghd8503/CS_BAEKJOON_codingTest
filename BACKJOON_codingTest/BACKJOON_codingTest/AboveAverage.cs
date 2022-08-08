using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKJOON_codingTest
{
    class AboveAverage
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            float average = 0.0f;
            int result = 0;

            for (int i = 0; i < count; i++)
            {
                int sum = 0;
                result = 0;

                string[] input = Console.ReadLine().Split();

                for(int j = 1; j < input.Length; j++)
                {
                    sum += int.Parse(input[j]);
                }
                average = sum / int.Parse(input[0]);

                for(int j = 1; j < input.Length; j++)
                {
                    if (int.Parse(input[j]) > average)
                        result++;
                }
                Console.WriteLine($"{(float)result / float.Parse(input[0]) * 100:0.000}%");
            }
        }
    }

}
