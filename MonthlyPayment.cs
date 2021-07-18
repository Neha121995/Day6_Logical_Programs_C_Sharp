using System;

namespace MonthlyPayment
{
    class MonthlyPayment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter principal loan ::");
            int Payment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of years ::");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of interest ::");
            int Rate = Convert.ToInt32(Console.ReadLine());
            MonthlyPay(Payment, Year, Rate);
        }
        static void MonthlyPay(int Payment, int Year, int Rate)
        {
            double principal = Payment, numberOfYears = Year, rateOfInterest = Rate;
            double payment;
            double rate = rateOfInterest / 1200;
            double n = 12 * Year;
            payment = (principal * rate) / (1 - Math.Pow((1 + rate), (-n)));
            Console.WriteLine("Monthly payment amount is :: INR {0}", payment);
        }
    }
}
