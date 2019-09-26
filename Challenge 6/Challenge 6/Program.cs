using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            double difference = 0;
            double num1 = 0;
            double num2 = 0;

            for (int i = 1; i <= number; i++)
            {
                num1 += i;

                num2 += Math.Pow(i, 2);
            }

            num1 = Math.Pow(num1, 2);
            difference = num1 - num2;

            Console.WriteLine(difference);
            Console.ReadLine();
        }
    }
}
