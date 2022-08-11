using System;

namespace BACKJOON_codingTest
{
    class CheckGroupVoca
    {
        static bool[] check = new bool[26];
        static int answer = 0;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                Count(str);
                for (int j = 0; j < check.Length; j++)
                {
                    check[j] = false;
                }
            }
            Console.WriteLine(answer);
        }

        static int Count(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (check[(str[i] - 'a')])
                {
                    return 0;
                }

                check[(str[i] - 'a')] = true;

                if ((i + 1) < str.Length)
                {
                    while (str[i] == str[i + 1])
                    {
                        i++;
                        if ((i + 1) < str.Length)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return answer++;
        }
    }

}
