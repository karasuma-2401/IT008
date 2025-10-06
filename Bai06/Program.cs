using System;

class Program
{
    static Random rand = new Random();

    static int[,] InputMatrix(int n, int m, int min = 0, int max = 100)
    {
        int[,] a = new int[n, m];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                a[i, j] = rand.Next(min, max + 1);
        return a;
    }

    static void OutputMatrix(int[,] a)
    {
        int n = a.GetLength(0);
        int m = a.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(a[i, j] + " ");
            Console.WriteLine();
        }
    }

    static (int maxVal, int minVal) FindMaxMin(int[,] a)
    {
        int n = a.GetLength(0), m = a.GetLength(1);
        int maxVal = a[0, 0], minVal = a[0, 0];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] > maxVal) maxVal = a[i, j];
                if (a[i, j] < minVal) minVal = a[i, j];
            }
        return (maxVal, minVal);
    }

    static int MaxRowSum(int[,] a)
    {
        int n = a.GetLength(0), m = a.GetLength(1);
        int maxRow = 0, maxSum = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++) sum += a[i, j];
            if (sum > maxSum)
            {
                maxSum = sum;
                maxRow = i;
            }
        }
        return maxRow;
    }

    static bool IsPrime(int n)
    {
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0)
                return false;
        return n > 1;
    }

    static int SumNonPrime(int[,] a)
    {
        int sum = 0;
        int row = a.GetLength(0), column = a.GetLength(1);
        for (int i = 0; i < row; i++)
            for (int j = 0; j < column; j++)
                if (!IsPrime(a[i, j])) sum += a[i, j];
        return sum;
    }

    static int[,] DeleteRow(int[,] a, int k)
    {
        int n = a.GetLength(0), m = a.GetLength(1);
        if (k < 0 || k >= n) return a;
        int[,] b = new int[n - 1, m];
        int bi = 0;
        for (int i = 0; i < n; i++)
        {
            if (i == k) continue;
            for (int j = 0; j < m; j++)
                b[bi, j] = a[i, j];
            bi++;
        }
        return b;
    }

    static int[,] DeleteColumn(int[,] a)
    {
        int n = a.GetLength(0), m = a.GetLength(1);
        (int maxVal, _) = FindMaxMin(a);

        int maxCol = -1;
        for (int j = 0; j < m; j++)
            for (int i = 0; i < n; i++)
                if (a[i, j] == maxVal) { maxCol = j; break; }
        if (maxCol == -1) return a;

        int[,] b = new int[n, m - 1];
        for (int i = 0; i < n; i++)
        {
            int bj = 0;
            for (int j = 0; j < m; j++)
            {
                if (j == maxCol) continue;
                b[i, bj++] = a[i, j];
            }
        }
        return b;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns (m): ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = InputMatrix(n, m);
        Console.WriteLine("\nInitial matrix:");
        OutputMatrix(matrix);

        var (maxVal, minVal) = FindMaxMin(matrix);
        Console.WriteLine($"\nMaximum element = {maxVal}, Minimum element = {minVal}");

        int maxRow = MaxRowSum(matrix);
        Console.WriteLine($"Row with the largest sum: {maxRow} (counting from 0)");

        Console.WriteLine($"Sum of all NON-prime numbers = {SumNonPrime(matrix)}");

        Console.Write("\nEnter the index of the row to delete: ");
        int k = int.Parse(Console.ReadLine());
        matrix = DeleteRow(matrix, k);
        Console.WriteLine("Matrix after deleting the selected row:");
        OutputMatrix(matrix);

        matrix = DeleteColumn(matrix);
        Console.WriteLine("\nMatrix after deleting the column containing the maximum element:");
        OutputMatrix(matrix);
    }
}
