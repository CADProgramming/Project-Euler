using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int number = 2;

            for (int i = number; count < 10001; i++)
            {
                bool prime = true;

                for (int n = 2; n <= Math.Sqrt(i); n++)
                {
                    if (i % n == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    count++;
                    number = i;
                }
            }

            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
