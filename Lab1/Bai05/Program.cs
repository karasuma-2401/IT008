using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        try
        {
            DateTime date = new DateTime(year, month, day);
            string dayOfWeek = "";

            switch (date.DayOfWeek)
            {
                case DayOfWeek.Sunday: dayOfWeek = "Sunday"; break;
                case DayOfWeek.Monday: dayOfWeek = "Monday"; break;
                case DayOfWeek.Tuesday: dayOfWeek = "Tuesday"; break;
                case DayOfWeek.Wednesday: dayOfWeek = "Wednesday"; break;
                case DayOfWeek.Thursday: dayOfWeek = "Thursday"; break;
                case DayOfWeek.Friday: dayOfWeek = "Friday"; break;
                case DayOfWeek.Saturday: dayOfWeek = "Saturday"; break;
            }

            Console.WriteLine($"The date {day}/{month}/{year} falls on a {dayOfWeek}.");
        }
        catch (Exception)
        {
            Console.WriteLine("The entered date is invalid!");
        }
    }
}
