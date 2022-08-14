using System;
using System.Linq;

namespace BACKJOON_codingTest
{
    class FindDecimal
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int answer = 0;
            int count = 0;
            var arary = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < input; i++)
            {
                for (int j = 2; j <= arary[i]; j++)
                {
                    if (arary[i] % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                    answer++;
                count = 0;
            }
            Console.WriteLine(answer);
        }
    }

}
