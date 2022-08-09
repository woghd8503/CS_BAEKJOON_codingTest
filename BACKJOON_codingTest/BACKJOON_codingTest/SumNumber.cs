using System;

namespace BACKJOON_codingTest
{
    class SumNumber
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            char[] arrChar = Console.ReadLine().ToCharArray();
            int answer = 0;

            for(int i = 0; i < arrChar.Length; i++)
            {
                answer += (int)char.GetNumericValue(arrChar[i]);
            }

            Console.WriteLine(answer);
        }
    }

}
