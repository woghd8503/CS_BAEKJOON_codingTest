using System;

namespace BACKJOON_codingTest
{
    class DeliverSugar
    {
        static void Main()
        {

            int input = int.Parse(Console.ReadLine());

            int count = 0;

            while (input > 0)
            {
                if (input % 5 == 0)
                {
                    input -= 5;
                    count++;
                }
                else if (input % 3 == 0)
                {
                    input -= 3;
                    count++;
                }
                else if (input > 5)
                {
                    input -= 5;
                    count++;
                }
                else
                {
                    count = -1;
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }

}
