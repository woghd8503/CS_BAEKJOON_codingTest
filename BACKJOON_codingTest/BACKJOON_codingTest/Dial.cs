using System;

namespace BACKJOON_codingTest
{
    class Dial
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] words = input.ToCharArray();
            int sumTime = 0;

            for(int i = 0; i < words.Length; i++)
            {
                int a = CapitalToNum(words[i]);
                sumTime += (a + 1);
            }
            Console.WriteLine(sumTime);
        }

        static int CapitalToNum(char capital)
        {
            if (capital >= 'A' && capital <= 'C')
                return 2;
            else if (capital >= 'D' && capital <= 'F')
                return 3;
            else if (capital >= 'G' && capital <= 'I')
                return 4;
            else if (capital >= 'J' && capital <= 'L')
                return 5;
            else if (capital >= 'M' && capital <= 'O')
                return 6;
            else if (capital >= 'P' && capital <= 'S')
                return 7;
            else if (capital >= 'T' && capital <= 'V')
                return 8;
            else if (capital >= 'W' && capital <= 'Z')
                return 9;
            else
                return 0;
        }
    }

}
