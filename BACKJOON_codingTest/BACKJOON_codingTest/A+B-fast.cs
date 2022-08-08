using System;
using System.Text;


namespace BACKJOON_codingTest
{
    class A_B_fast
    {
        static void Main()
        {
            StringBuilder answer = new StringBuilder();
            int count = int.Parse(Console.ReadLine());

            int[] a = new int[count];
            int[] b = new int[count];

            for(int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                a[i] = int.Parse(input[0]);
                b[i] = int.Parse(input[1]);

                int sum = a[i] + b[i];
                answer.AppendLine(sum.ToString());
            }

            Console.WriteLine(answer.ToString());
        }
    }

}
