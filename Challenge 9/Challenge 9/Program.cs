using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 500; a++)
            {
                for (int b = 1; b < 500; b++)
                {
                    for (int c = 1; c < 500; c++)
                    {
                        if (a + b + c == 1000 && a < b && b < c &&  Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                        {
                            Console.WriteLine("A = " + a.ToString() + "\nB = " + b.ToString() + "\nC = " + c.ToString() + "\n" + (a * b * c).ToString());
                            break;
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
