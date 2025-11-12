using System;

class Program
{
    public static bool IsPrime(int n)
    {
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return n > 1;
    }

    private static void Main(string[] args)
    {
        Console.Write("Enter a positive integer n: ");
        int n = int.Parse(Console.ReadLine());
        long sum = 0;
        bool hasPrime = false;

        for (int i = 0; i < n; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
                hasPrime = true;
            }
        }

        if (!hasPrime)
            Console.WriteLine("There are no prime numbers smaller than n.");
        else
            Console.WriteLine($"The sum of all prime numbers smaller than n is: {sum}");
    }
}
