using System;
using LogicalProgram;

internal class Program
{
    public static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("1.Fibonacci\n2.Perfect_Number\n3.Prime_Number \n4.Reverse_Number\n5.Coupon" +
                            " \n6.Stopwatch\n7.VendingMachine\n8.Day of week \n9.Temperature");
            int ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (ch)
            {
                case 1:
                    Fibanocci.Fib();
                    break;
                case 2:
                    PerfectNumber.Perfect();
                    break;
                case 3:
                    PrimeNumber.Prime();
                    break;
                case 4:
                    ReverseNumber.Reverse();
                    break;
                case 5:
                    Coupon.Coupons();
                    break;
                case 6:
                    StopWatch.Timer();
                    break;

                case 7:
                    VendingMachine.Amount();
                    break;
                case 8:
                    Dayofweek.Get();
                    break;
                case 9:
                    Temperature.Temp();
                    break;


            }
        }
    }
}