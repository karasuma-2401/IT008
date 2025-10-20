using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chọn bài tập (1-5):");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Bai01.Bai01_Run();
                    break;
                case 2:
                    Bai02.Bai02_Run();
                    break;
                case 3:
                    Bai03.Bai03_Run();
                    break;
                case 4:
                    Bai04.Bai04_Run();
                    break;
                case 5:
                    Bai05.Bai05_Run();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}