using System;

namespace Challenge_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int mostIterations = 1;
            long startingNumber = 1;

            for (long i = 1; i < 1000000; i++)
            {
                int iterations = 1;
                long number = i;

                while (number > 1)
                {
                    if (number % 2 == 0)
                    {
                        number /= 2;
                    }
                    else
                    {
                        number = (number * 3) + 1;
                    }
                    iterations++;
                }

                if (iterations > mostIterations)
                {
                    mostIterations = iterations;
                    startingNumber = i;
                }
            }

            Console.WriteLine(startingNumber);
            Console.ReadLine();
        }
    }
}
