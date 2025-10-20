using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Bai03
    {
        static bool isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return n > 1;
        }
        static int[,] InputMatrix(int n, int m)
        {
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        static void OutputMatrix(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void FindElement(int[,] a, int n, int m)
        {
            Console.WriteLine("Enter the element k you want to find");
            int k = int.Parse(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] == k)
                    {
                        check = true;
                        Console.WriteLine($"Number {k} have been existed in matrix at [{i} ,{j}]");
                        return;
                    }
                }
            }
            if (!check)
                Console.WriteLine("Can not find a number k in matrix");
        }

        static void PrimeInMatrix(int[,] a, int n, int m)
        {
            Console.Write("List of prime numbers: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (isPrime(a[i, j]))
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
        static int countPrime(int[,] a, int row, int column)
        {
            int count = 0;
            for (int j = 0; j < column; j++)
            {
                if (isPrime(a[row, j]))
                    count++;
            }
            return count;
        }
        static void maxPrimeColumn(int[,] a, int n, int m)
        {
            int maxPrimes = 0;
            int maxRow = -1;
            for (int i = 0; i < n; i++)
            {
                int currentPrime = countPrime(a, i, m);
                if (currentPrime > 0 && currentPrime > maxPrimes)
                {
                    maxRow = i;
                    maxPrimes = currentPrime;
                }
            }
            if (maxRow != -1)
                Console.WriteLine($"The row with the most prime numbers is {maxRow}");
            else
                Console.WriteLine("No rows in matrix exists prime numbers");
        }
        public static void Bai03_Run()
        {
            Console.Write("Enter the number of rows (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns (m): ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = InputMatrix(n, m);
            OutputMatrix(a, n, m);
            FindElement(a, n, m);
            PrimeInMatrix(a, n, m);
            maxPrimeColumn(a, n, m);
        }
    }
}