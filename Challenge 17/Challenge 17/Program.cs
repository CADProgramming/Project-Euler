using System;

namespace Challenge_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ones = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            
            const string HUNDRED = "hundred";
            const string THOUSAND = "thousand";
            const string AND = "and";
            long characterSum = 0;

            for (int i = 1; i <= 1000; i++)
            {
                string result = "";
                string numberAsString = i.ToString();

                int[] placeValues = new int[4];
                int offset = 4 - numberAsString.Length;

                for (int n = numberAsString.Length - 1; n >= 0; n--)
                {
                    placeValues[n + offset] = int.Parse(numberAsString[n].ToString());
                }

                if (placeValues[0] != 0)
                {
                    result += ones[placeValues[0] - 1] + THOUSAND;
                }
                if (placeValues[1] != 0)
                {
                    result += ones[placeValues[1] - 1] + HUNDRED;
                }
                if ((placeValues[0] != 0 || placeValues[1] != 0) && (placeValues[2] != 0 || placeValues[3] != 0))
                {
                    result += AND;
                }
                if ((placeValues[2] > 1 || (placeValues[2] == 1 && placeValues[3] == 0)))
                {
                    result += tens[placeValues[2] - 1];
                }
                else if (placeValues[2] == 1)
                {
                    result += teens[placeValues[3] - 1];
                }
                if (placeValues[2] != 1 && placeValues[3] != 0)
                {
                    result += ones[placeValues[3] - 1];
                }

                characterSum += result.Length;
            }

            Console.WriteLine(characterSum);
            Console.ReadLine();
        }
    }
}
