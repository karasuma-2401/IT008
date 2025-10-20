using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Bai01
    {
        static void PrintCalendar(int month, int year)
        {
            if (month < 1 || month > 12 || year < 0)
            {
                Console.WriteLine($"{month}/{year} invalid");
                return;
            }
            DateTime firstDay = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            Console.WriteLine($"Month: {month}/{year}");
            Console.WriteLine("Sun\tMon\tTue\tWed\tThu\tFri\tSat");

            int current = (int)firstDay.DayOfWeek;
            for (int i = 0; i < current; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= daysInMonth; i++)
            {
                Console.Write($"{i}\t");
                current++;
                if (current > 6)
                {
                    Console.WriteLine();
                    current = 0;
                }
            }
            Console.WriteLine();
        }
        public static void Bai01_Run()
        {
            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());


            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            PrintCalendar(month, year);
        }
    }
}