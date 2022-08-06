using System;

namespace BACKJOON_codingTest
{
    class OvenTimer
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int hour = int.Parse(input[0]);
            int minute = int.Parse(Console.ReadLine()) + int.Parse(input[1]);

            hour = (hour + minute / 60) % 24;
            minute %= 60;

            Console.WriteLine(hour + " " + minute);
        }
    }

}