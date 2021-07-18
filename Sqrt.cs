using System;

namespace SqrtProgram
{
    class Sqrt
    {
        static void Sqrt(int c)
        {
            int t = c;
            long epsilon = (long)10E-15;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = ((c / t) + t) / 2;
            }
            Console.WriteLine(t);
        }
        static void Main(string[] args)
        {
            Sqrt(16);
        }
            

    }
}
