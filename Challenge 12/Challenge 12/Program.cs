using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int factors = 0;
            int count = 1;
            int number = 0;

            do
            {
                number = 0;
                factors = 0;

                for (int i = 1; i <= count; i++)
                {
                    number += i;
                }

                int limit = number;

                for (int i = 1; i < limit; i++)
                {
                    if (number % i == 0)
                    {
                        limit = number / i;
                        if (number / i == i)
                        {
                            factors++;
                        }
                        else
                        {
                            factors += 2;
                        }
                    }
                }
                count++;

            } while (factors < 500);

            Console.Write(number.ToString());
            Console.ReadLine();
        }
    }
}
