using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class Program
    {
        public static string primeFactors(int number)
        {
            var primes = new List<int>();

            for (int div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    primes.Add(div);
                    number /= div;
                }
            }

            return string.Join(" x ", primes);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Prime factors of {input} are: {primeFactors(input)}"); 
            // 40 = 2 x 2
            // 7  = 7
            // 30 = 2 x 3 x 5
            // 40 = 2 x 2 x 2 x 5
            // 50 = 2 x 5 x 5
        }
    }
}
