using System;

namespace Challenge_20
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER = 100;
            long[] placeValues = new long[165];
            placeValues[placeValues.Length - 1] = 1;

            for (int i = NUMBER; i > 0; i--)
            {
                for (int n = placeValues.Length - 1; n >= 0; n--)
                {
                    placeValues[n] *= i;
                }

                for (int n = placeValues.Length - 1; n >= 0; n--)
                {
                    if (placeValues[n] > 9)
                    {
                        placeValues[n - 1] += placeValues[n] / 10;
                        placeValues[n] %= 10;
                    }
                }
            }

            long digitSum = 0;

            for (int i = 0; i < placeValues.Length; i++)
            {
                digitSum += placeValues[i];
            }

            Console.WriteLine(digitSum);
            Console.ReadLine();
        }
    }
}
