using System;

namespace BACKJOON_codingTest
{
    class Receipt
    {
        static void Main()
        {
            int totalPayment = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            int sumMoney = 0;

            for (int i = 0; i < count; i++)
            {
                string[] priceAndNum = Console.ReadLine().Split();
                sumMoney += int.Parse(priceAndNum[0]) * int.Parse(priceAndNum[1]);
            }

            if(sumMoney == totalPayment)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }

}
