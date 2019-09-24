using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475143;
            long highestFactor = number;
            long highestPrime = 0;

            for (int i = 2; i < highestFactor; i++)
            {
                if (number % i == 0)
                {
                    highestFactor = number / i;
                }

                bool isPrime = true;

                for (int n = 2; n < Math.Sqrt(i); n++)
                {
                    if (i % n == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && i < highestFactor && number % i == 0)
                {
                    highestPrime = i;
                }
            }

            Console.WriteLine(highestPrime);
            Console.ReadLine();
        }
    }
}
