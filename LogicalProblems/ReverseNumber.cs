using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ReverseNumber
    {
        public static void Reverse()
        {
            Console.WriteLine("Enter a number to reverse :-");
            int num= Convert.ToInt32(Console.ReadLine());
            int d = 0, rev = 0;
            while (num > 0)
            {
                d = num% 10;
                rev = rev * 10 + d;
                num = num / 10;
            }
            Console.WriteLine(rev);
        }
    }
}
