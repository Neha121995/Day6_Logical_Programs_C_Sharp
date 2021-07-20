using System;

namespace CouponNumber
{
    class CouponNumber
    {
        static void Main(string[] args)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[6];
            var random = new Random();
            Console.WriteLine("How many ticket u want to generate.");
            int number =int.Parse(Console.ReadLine());
            while (number>0) {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);
                Console.WriteLine(finalString);
                number = number - 1;
            }
            
        }
    }

}

