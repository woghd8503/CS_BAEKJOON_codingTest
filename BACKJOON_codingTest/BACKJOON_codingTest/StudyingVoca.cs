using System;

namespace BACKJOON_codingTest
{
    class StudyingVoca
    {
        static int[] answer = new int[26];
        static char[] Max = new char[26];

        static void Main()
        {
            for (int i = 0; i < 26; i++)
            {
                Max[i] = (char)((int)'A' + i);
            }
            string text = Console.ReadLine().ToUpper();
            Count(text);
            Console.WriteLine(Result());
        }

        static void Count(string t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 0; j < Max.Length; j++)
                {
                    if (t[i] == Max[j])
                    {
                        answer[j]++;
                    }
                }
            }
        }

        static char Result()
        {
            int num = 0;
            int high = 0;
            bool same = false;

            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == high && answer[i] != 0)
                {
                    same = true;
                }
                if (answer[i] > high)
                {
                    high = answer[i];
                    num = i;
                    same = false;
                }
            }

            if (same)
            {
                return '?';
            }
            else
            {
                return Max[num];
            }
        }
    }

}
