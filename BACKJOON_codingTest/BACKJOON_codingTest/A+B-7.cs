using System;
using System.Text;

namespace BACKJOON_codingTest
{
    class A_B_7
    {
        static void Main()
        {
            StringBuilder number = new StringBuilder();

            int count = int.Parse(Console.ReadLine());
            int[] num = new int[count];

            for (int i = 0; i < count; i++)
            {
                String[] input = Console.ReadLine().Split();
                num[i] = int.Parse(input[0]) + int.Parse(input[1]);
                number.AppendLine($"Case #{i + 1}: " + num[i].ToString());
            }

            Console.WriteLine(number.ToString());
        }
    }

}


