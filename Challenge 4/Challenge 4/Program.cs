using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "";
            bool palindrome = false;
            int highest = 0;

            for (int x = 999; x > 0; x--)
            {
                for (int y = 999; y > 0; y--)
                {
                    palindrome = true;
                    number = Convert.ToString(x * y);

                    for (int i = 0; i < number.Length; i++)
                    {
                        if (number[i] != number[(number.Length - 1) - i])
                        {
                            palindrome = false;
                            break;
                        }
                    }

                    if (palindrome && Convert.ToInt32(number) > highest)
                    {
                        highest = Convert.ToInt32(number);
                    }
                }
            }

            Console.WriteLine(highest.ToString());
            Console.ReadLine();
        }
    }
}
