using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKJOON_codingTest
{
    class multiplication
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{input} * {i} = {i*input}");
            }
        }
    }

}
