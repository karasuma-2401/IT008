using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (month < 1 || month > 12)
        {
            Console.WriteLine("Invalid month!");
            return;
        }

        if (year <= 0)
        {
            Console.WriteLine("Invalid year!");
            return;
        }

        int days = DateTime.DaysInMonth(year, month);

        Console.WriteLine($"Month {month}/{year} has {days} days.");
    }
}
