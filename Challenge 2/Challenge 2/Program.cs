using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int last = 1;
            int current = 1;

            while ((current + last) < 4000000)
            {
                int newLast = current;
                current += last;
                last = newLast;

                if (current % 2 == 0)
                {
                    total += current;
                }
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
