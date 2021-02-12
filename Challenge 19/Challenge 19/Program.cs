using System;

namespace Challenge_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeekNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int dayOfMonth = 1;
            int dayOfWeek = 1;
            int month = 1;
            int year = 1900;
            bool isLeapYear = false;

            long sundayCount = 0;

            while (dayOfMonth != 1 || month != 1 || year != 2001)
            {
                if (dayOfWeekNames[dayOfWeek - 1] == "Sunday" && dayOfMonth == 1 && year >= 1901 && year <= 2000)
                {
                    sundayCount++;
                }

                dayOfMonth++;
                dayOfWeek++;

                if (dayOfWeek > 7) dayOfWeek = 1;
                if (dayOfMonth > monthDays[month - 1])
                {
                    if ((isLeapYear && month == 2 && dayOfMonth == monthDays[month - 1] + 1) == false)
                    {
                        dayOfMonth = 1;
                        month++;

                        if (month > 12)
                        {
                            month = 1;
                            year++;

                            isLeapYear = (year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
                        }
                    }
                }
            }

            Console.WriteLine(sundayCount);
            Console.ReadLine();
        }
    }
}
