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
            int last = 2;
            int current = 8;

            int total = last + current;

            while (((4 * current) + last) < 4000000)
            {
                //Only goes through even numbers
                int newLast = current;
                current *= 4;
                current += last;
                last = newLast;

                total += current;
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
