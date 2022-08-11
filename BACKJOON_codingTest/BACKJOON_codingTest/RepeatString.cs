using System;

namespace BACKJOON_codingTest
{
    class RepeatString
    {
        class Program
        {
            static void Main(string[] args)
            {
                string answer = "";
                int t = int.Parse(Console.ReadLine());

                for (int i = 0; i < t; i++)
                {
                    string[] s = Console.ReadLine().Split();
                    int r = int.Parse(s[0]);

                    for (int j = 0; j < s[1].Length; j++)
                    {
                        for (int k = 0; k < r; k++)
                        {
                            answer += s[1][j];
                        }
                    }
                    Console.WriteLine(answer);
                    answer = "";
                }
            }
        }
    }

}
