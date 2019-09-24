using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numberFound = false;
            int number = 0;

            for (int i = 20; !numberFound; i += 20)
            {
                numberFound = true;

                for (int n = 2; n <= 19; n++)
                {
                    if (i % n != 0)
                    {
                        numberFound = false;
                        break;
                    }
                }

                if (numberFound)
                {
                    number = i;
                    break;
                }
            }

            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
