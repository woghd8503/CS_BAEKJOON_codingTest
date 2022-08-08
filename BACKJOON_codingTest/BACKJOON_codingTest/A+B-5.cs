using System;
using System.Collections.Generic;

namespace BACKJOON_codingTest
{
    class A_B_5
    {
        static void Main()
        {
            List<int> answer = new List<int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                int num1 = int.Parse(input[0]);
                int num2 = int.Parse(input[1]);

                if (num1 + num2 == 0)
                    break;

                answer.Add(num1 + num2);
            }

            for (int i = 0; i < answer.Count; i++)
                Console.WriteLine(answer[i]);
        }
    }

}
