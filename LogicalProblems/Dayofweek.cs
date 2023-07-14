using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Dayofweek
    {
        public static void Get()
        {
            Console.Write(" Input the Day : ");
            int date = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the Month : ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime ss = new DateTime(date, month, year);
            Console.WriteLine(ss.DayOfWeek);
        }
    }
}
