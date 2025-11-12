using System;
class Program
{
    static bool isPrime(int n)
    {
           for (int i = 2; i <= Math.Sqrt(n); i++)
           {
               if (n % i == 0) return false;
           }
       return n > 1;
    }

    static bool isPerfectSquare (int n)
    {
        int x = (int)Math.Sqrt(n);
        return x * x == n; 
    }

    static int sumOdd(int[] arr)
    {
        int sum = 0;
        foreach (int x in arr) {
            if (x % 2 != 0) 
                sum += x;
        }
        return sum;
    }

    static int countPrimes(int[] arr)
    {
        int count = 0;
        foreach (int x in arr)
        {
            if (isPrime(x))
                count++;
        }
        return count;
    }

    static int minPerfectSquare(int[] arr)
    {
        int minVal = int.MaxValue;
        foreach (int x in arr)
        {
            if (isPerfectSquare(x) && x < minVal)
                minVal = x;
        }
        return minVal == int.MaxValue ? -1 : minVal;
    }

    private static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.Write("Random array: ");
        Random random = new Random();
        for (int i =0; i < n; i++)
        {
            arr[i] = random.Next(0, 1000);
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Sum of odd numbers in the array: " + sumOdd(arr)); 
        Console.WriteLine("Number of prime numbers in the array: " + countPrimes(arr));
        int minSquare = minPerfectSquare(arr);
        if (minSquare != -1)
            Console.WriteLine("Smallest perfect square in the array: " + minSquare);
        else
            Console.WriteLine("No perfect square found in the array.");
    }
}