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
            int sum = 0;

            for (int i = 2; i < 2000000; i++)
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
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
