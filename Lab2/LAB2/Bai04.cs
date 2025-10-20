using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LAB2
{
    internal class Bai04
    {
        class Fraction
        {
            private int numerator;
            private int denominator;

            public void Input()
            {
                Console.WriteLine("Enter the numerator");
                numerator = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominater");
                denominator = int.Parse(Console.ReadLine());

                while (denominator == 0)
                {
                    Console.WriteLine("Denominator must not be 0. Please try again");
                    denominator = int.Parse(Console.ReadLine());
                }
            }

            public void Output()
            {

                if (numerator % denominator == 0)
                {
                    Console.Write(numerator / denominator);
                }
                else Console.Write($"{numerator}/{denominator}");
            }

            public int GCD(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);

                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }
            public void Simplify()
            {
                int UCLN = GCD(numerator, denominator);
                numerator = numerator / UCLN;
                denominator = denominator / UCLN;
                if (denominator < 0)
                {
                    numerator = -numerator;
                    denominator = -denominator;
                }
            }
            public static Fraction operator +(Fraction a, Fraction b)
            {
                Fraction result = new Fraction();
                result.numerator = a.numerator * b.denominator + a.denominator * b.numerator;
                result.denominator = a.denominator * b.denominator;
                result.Simplify();
                return result;
            }
            public static Fraction operator -(Fraction a, Fraction b)
            {
                Fraction result = new Fraction();
                result.numerator = a.numerator * b.denominator - a.denominator * b.numerator;
                result.denominator = a.denominator * b.denominator;
                result.Simplify();
                return result;
            }
            public static Fraction operator *(Fraction a, Fraction b)
            {
                Fraction result = new Fraction();
                result.numerator = a.numerator * b.numerator;
                result.denominator = a.denominator * b.denominator;
                result.Simplify();
                return result;
            }
            public static Fraction operator /(Fraction a, Fraction b)
            {
                Fraction result = new Fraction();
                result.numerator = a.numerator * b.denominator;
                result.denominator = a.denominator * b.numerator;
                result.Simplify();
                return result;
            }
            public static bool operator >(Fraction a, Fraction b)
            {
                return (double)a.numerator / a.denominator > (double)b.numerator / b.denominator;
            }
            public static bool operator <(Fraction a, Fraction b)
            {
                return (double)a.numerator / a.denominator < (double)b.numerator / b.denominator;
            }
            public static void InputArray(Fraction[] a, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("The fraction {0} th", i + 1);
                    a[i] = new Fraction();
                    a[i].Input();
                }
            }
            public static void OutputArray(Fraction[] a, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    a[i].Simplify();
                    a[i].Output();
                    Console.Write(" ");
                }
            }
            public static Fraction fractionMax(Fraction[] a, int n)
            {
                Fraction res = a[0];
                int Index = 0;
                for (int i = 0; i < n; i++)
                {
                    if (a[i] > res)
                    {
                        res = a[i];
                        Index = i;
                    }
                }
                a[Index].Simplify();
                return a[Index];
            }
            public static void SortArray(Fraction[] a, int n)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] > a[j])
                        {
                            Fraction temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("1. Two fraction");
            Console.WriteLine("2. fraction Array");
            Console.WriteLine("3. Quit");
        }
        public static void twoFraction()
        {
            Console.WriteLine("First fraction: ");
            Fraction a = new Fraction();
            a.Input();

            Console.WriteLine("Second fraction: ");
            Fraction b = new Fraction();
            b.Input();

            Fraction sum = a + b;
            Console.Write("Sum of the two fractions: ");
            sum.Output();
            Console.WriteLine();

            Fraction minus = a - b;
            Console.Write("Minus of the two fractions: ");
            minus.Output();
            Console.WriteLine();

            Fraction time = a * b;
            Console.Write("Times of the two fractions: ");
            time.Output();
            Console.WriteLine();

            Fraction devide = a / b;
            Console.Write("Divide of the two fractions: ");
            devide.Output();
            Console.WriteLine();

            Console.ReadKey();
        }
        public static void ReArrange()
        {
            Console.Write("Enter the number of fractions: ");
            int n = int.Parse(Console.ReadLine());

            Fraction[] a = new Fraction[n];
            Fraction[] fractionArray = new Fraction[n];
            Fraction.InputArray(a, n);

            Console.WriteLine("The largest fraction in the array is ");
            Fraction.fractionMax(a, n).Output();
            Console.WriteLine();

            Console.Write("The fraction array after sorting in ascending order is: ");
            Fraction.SortArray(a, n);
            Fraction.OutputArray(a, n);
            Console.WriteLine();
        }
        public static void Bai04_Run()
        {
            Console.WriteLine("What is your choices:");
            while (true)
            {
                Menu();
                Console.WriteLine("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        twoFraction();
                        break;
                    case 2:
                        ReArrange();
                        break;
                    case 3:
                        Console.WriteLine("Quit progam");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Choose again please");
                        break;
                }

            }
        }
    }
}