using System;

namespace BACKJOON_codingTest
{
    class Hansu
    {
        static void Main()
        {
            int count = 0;
            int input = int.Parse(Console.ReadLine());

            for(int i = 1; i <= input; i++)
            {
                if (Method(i.ToString()))
                    count++;
            }

            Console.WriteLine(count);
        }

        static bool Method(string num)
        {
            if(int.Parse(num) < 100)
            return true;

            int[] numbers = new int[num.Length];

            for(int i = 0; i < num.Length; i++)
            {
                numbers[i] = num[i];
            }

            if ((numbers[0] - numbers[1]) == numbers[1] - numbers[2])
            {
                return true;
            }
            else
                return false;
        }
    }

}
