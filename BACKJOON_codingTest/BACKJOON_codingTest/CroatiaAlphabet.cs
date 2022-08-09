using System;

namespace BACKJOON_codingTest
{
    class CroatiaAlphabet
    {
        static string[] Alpabet = new string[8]
        {
            "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z="
        };

        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Count(input, Alpabet));
        }

        static int Count(string input, string[] alpabet)
        {
            int answer = 0;
            int sum = 0;

            for (int i = 0; i < alpabet.Length; i++)
            {
                sum = input.Length - input.Replace(alpabet[i], "").Length;
                input = input.Replace(alpabet[i], "_");
                answer += sum / alpabet[i].Length;
            }
            input = input.Replace("_", "");
            answer += input.Length;
            return answer;
        }
    }

}
