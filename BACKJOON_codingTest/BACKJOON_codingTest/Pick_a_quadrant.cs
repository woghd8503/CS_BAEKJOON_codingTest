﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKJOON_codingTest
{
    class Pick_a_quadrant
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int input1 = int.Parse(Console.ReadLine());

            if(input > 0 && input1 > 0)
                Console.WriteLine("1");
            if(input < 0 && input1 > 0)
                Console.WriteLine("2");
            if(input < 0 && input1 < 0)
                Console.WriteLine("3");
            if(input > 0 && input1 < 0)
                Console.WriteLine("4");
        }
    }

}
