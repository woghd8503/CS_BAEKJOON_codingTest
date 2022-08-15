using System;

namespace BACKJOON_codingTest
{
    class Decimal
    {
        static void Main()
        {
            int input1 = int.Parse(Console.ReadLine());
            int input = int.Parse(Console.ReadLine());

            bool[] sieve = new bool[input + 1];
            bool check = false;

            int result = 0;
            int Min = 0;

            for (int i = 2; i < Math.Sqrt(input) + 1; i++)  
            {
                if (sieve[i] == false)
                {
                    for (int j = i + i; j < input + 1; j = j + i)
                    {
                        sieve[j] = true;
                    }
                }
            }
            for (int i = input1; i < input + 1; i++) 
            {
                if (i != 1)
                {
                    if (sieve[i] == false)
                    {
                        if (check == false)
                        {
                            check = true;
                            Min = i;
                        }
                        result += i;
                    }
                }
            }
            if (result == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(result);
                Console.WriteLine(Min);
            }
        }
    }
    
}
