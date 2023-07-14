using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class VendingMachine
    {
        public static void Amount()
        {
            int[] amount = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            Console.WriteLine("Enter the amount to calculate :- ");
            int input = Convert.ToInt32(Console.ReadLine());
            int num = input;
            int noteCount = 0;
            foreach (var balanceamount in amount)
            {
                noteCount += (num / balanceamount);
                num %= balanceamount;
            }
            Console.WriteLine(noteCount);
        }
    }
}
