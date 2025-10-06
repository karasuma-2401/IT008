using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter day: ");
        string day = Console.ReadLine();

        Console.Write("Enter month: ");
        string month = Console.ReadLine();

        Console.Write("Enter year: ");
        string year = Console.ReadLine();

        string dateStr = $"{month}/{day}/{year}";

        if (DateTime.TryParse(dateStr, out DateTime date))
            Console.WriteLine("The entered date is valid: " + day + "/" + month + "/" + year);
        else
            Console.WriteLine("The entered date is invalid!");
    }
}
