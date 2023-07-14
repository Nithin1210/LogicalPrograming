using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Fibanocci
    {
        public static void Fib()
        {
            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.Write("Enter the number :- ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (int i = 2; i < l; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }
        }
    }
}

