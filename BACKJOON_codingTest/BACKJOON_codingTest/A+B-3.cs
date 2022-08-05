using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKJOON_codingTest
{
    class A_B_3
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int[] answer = new int[input];

            for (int i = 0; i < input; i++)
            {
                string[] inputNums = Console.ReadLine().Split();
                int num1 = int.Parse(inputNums[0]);
                int num2 = int.Parse(inputNums[1]);
                answer[i] = num1 + num2;
            }

            for(int i = 0; i < input; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }

}
