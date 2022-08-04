using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKJOON_codingTest
{
    class Alarm_clock
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int hour = int.Parse(input[0]);
            int minute = int.Parse(input[1]);

            if (hour < 0 || hour > 24 || minute < 0 || minute > 59) return;

            if (minute < 45)
            {
                hour--;
                minute += 15;

                if (hour < 0)
                    hour = 23;
            }
            else
            {
                minute -= 45;
            }

            Console.WriteLine(hour + " " + minute);
        }
    }

}
