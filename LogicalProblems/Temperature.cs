﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Temperature
    {
        public static void Temp()
        {
            Console.WriteLine("1.celcius to Fahrenheit:\n2.Fahrenheit to celcius:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Enter the value of celcius");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(input * (9 / 5) + 32);
            }
            if (num == 2)
            {
                Console.WriteLine("Enter the valu of Fahrenheit");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine((input - 32) * (5 / 9));
            }
        }
    }
}

