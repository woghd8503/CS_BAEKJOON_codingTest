using System;

namespace BACKJOON_codingTest
{
    class PlusCycle
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int firstNum = input;
            int answer = 0;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            while (true)
            {
                num1 = input / 10;
                num2 = input % 10;
                num3 = (num1 + num2) % 10;
                input = num3 + (num2 * 10);
                answer++;
                if (input == firstNum)
                    break;
            }
            Console.WriteLine(answer);
        }
    }

}
