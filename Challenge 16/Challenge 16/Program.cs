using System;

namespace Challenge_16
{
    class Program
    {
        static void Main(string[] args)
        {
            const int POWER = 1000;
            int[] placeValues = new int[500];
            placeValues[placeValues.Length - 1] = 1;

            for (int n = 0; n < POWER; n++)
            {
                for (int i = placeValues.Length - 1; i >= 0; i--)
                {
                    placeValues[i] *= 2;
                }

                for (int i = placeValues.Length - 1; i >= 0; i--)
                {
                    if (placeValues[i] > 9)
                    {
                        placeValues[i - 1] += placeValues[i] / 10;
                        placeValues[i] %= 10;
                    }
                }
            }

            long sumOfDigits = 0;

            for (int i = 0; i < placeValues.Length; i++)
            {
                sumOfDigits += placeValues[i];
            }

            Console.WriteLine(sumOfDigits);
            Console.ReadLine();
        }
    }
}
