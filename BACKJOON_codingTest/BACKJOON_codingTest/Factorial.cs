using System;

namespace BACKJOON_codingTest
{
    class Factorial
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialMethod(n));
        }

        static int FactorialMethod(int num)
        {
            int result = num;
            for (int i = 1; i < num; i++)
            {
                result = result * (num - i);
            }

            if (result == 0) result = 1;

            return result;
        }
    }

}