using System;

namespace BACKJOON_codingTest
{
    class Reminder
    {
        static void Main()
        {
            int count = 10;
            int[] reminder = new int[10];
            int answer = 1;

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                reminder[i] = int.Parse(input) % 42;
            }

            Array.Sort(reminder);

            for(int i = 0; i < count - 1; i++)
            {
                if (reminder[i] != reminder[i + 1])
                    answer++;
            }
            Console.WriteLine(answer);
        }
    }
}
