using System;

namespace BACKJOON_codingTest
{
    class Star_1
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for(int i = 0; i < input; i++)
            {

                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

}
