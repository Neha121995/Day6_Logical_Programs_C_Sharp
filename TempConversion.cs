using System;

namespace TemperatureConversion
{
    class TempConversion
    {
        static void Main(string[] args)
        {
            TempConversion();
            static void TempConversion()
            {
                Console.WriteLine("Enter the output temperature unit ::");
                char ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case 'f':
                        Console.Write("Enter the temperature in degreeCelcius (0-100) ::");
                        int degC = Convert.ToInt32(Console.ReadLine());
                        int degF = (degC * 9 / 5) + 32;
                        Console.WriteLine(degF);
                        break;
                    case 'c':
                        Console.Write("Enter the tempurature in degreeFahrenheit (32-212) ::");
                        int degFar = Convert.ToInt32(Console.ReadLine());
                        int degCel = (degFar - 32) * 5 / 9;
                        Console.WriteLine(degCel);
                        break;
                }
            }
        }
    }
}
