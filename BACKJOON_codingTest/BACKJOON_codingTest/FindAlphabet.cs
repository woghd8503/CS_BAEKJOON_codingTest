using System;
using System.Linq;


namespace BACKJOON_codingTest
{
    class FindAlphabet
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            for (int i = 97; i < 123; i++)
            {
                if (s.Contains(Convert.ToChar(i)))
                {
                    Console.Write(s.IndexOf(Convert.ToChar(i)));
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-1 ");
                }
            }
        }
    }

}

