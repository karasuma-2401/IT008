using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LAB2
{
    internal class Bai05
    {
        class KhuDat
        {
            protected string Location;
            protected long Cost;
            protected double Area;

            public virtual void Input()
            {
                Console.Write("Enter the location: ");
                Location = Console.ReadLine();
                Console.Write("Enter the cost (VND): ");
                Cost = long.Parse(Console.ReadLine());
                Console.Write("Enter the area (m2): ");
                Area = double.Parse(Console.ReadLine());
            }

            public virtual void Output()
            {
                Console.WriteLine($"Location: {Location}, Cost: {Cost}, Area: {Area}m2");
            }
            public string GetLocation() => Location;
            public long GetCost() => Cost;
            public double GetArea() => Area;
        }
        class NhaPho : KhuDat
        {
            private int BuiltYear;
            private int Floor;
            public override void Input()
            {
                base.Input();
                Console.Write("Enter the built year: ");
                BuiltYear = int.Parse(Console.ReadLine());
                Console.Write("Enter the numbers of floor :");
                Floor = int.Parse(Console.ReadLine());
            }
            public override void Output()
            {
                Console.WriteLine($"Type: Nha Pho, Location: {Location}, Cost: {Cost} VND, Area: {Area}m2, Built Year: {BuiltYear}, Floor: {Floor}");
            }
            public int GetBuiltYear() => BuiltYear;
        }
        class ChungCu : KhuDat
        {
            private int BuiltFloor;
            public override void Input()
            {
                base.Input();
                Console.Write("Enter the built floor: ");
                BuiltFloor = int.Parse(Console.ReadLine());
            }
            public override void Output()
            {
                Console.WriteLine($"Type: Chung Cu, Location: {Location}, Cost: {Cost} VND, Area: {Area}m2, Built floor: {BuiltFloor}");
            }
        }
        public static void Bai05_Run()
        {
            List<KhuDat> list = new List<KhuDat>();
            Console.Write("Enter the number of properties: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the information of properties {i + 1}: ");
                Console.WriteLine("1. Khu dat");
                Console.WriteLine("2. Nha Pho");
                Console.WriteLine("3. Chung cu");
                Console.Write("Choose type: ");
                int type = int.Parse(Console.ReadLine());

                KhuDat objection = null;
                switch (type)
                {
                    case 1:
                        objection = new KhuDat();
                        break;
                    case 2:
                        objection = new NhaPho();
                        break;
                    case 3:
                        objection = new ChungCu();
                        break;
                    default:
                        Console.WriteLine("Invalid type!");
                        i--;
                        continue;
                }
                objection.Input();
                list.Add(objection);
            }
            Console.WriteLine("\n---LIST OF PROPERTIES---");
            foreach (var x in list)
            {
                x.Output();
            }
            long totalKhuDat = 0;
            long totalNhaPho = 0;
            long totalChungCu = 0;

            foreach (var x in list)
            {
                if (x is NhaPho)
                {
                    totalNhaPho += x.GetCost();
                }
                else if (x is ChungCu)
                {
                    totalChungCu += x.GetCost();
                }
                else totalKhuDat += x.GetCost();
            }

            Console.WriteLine("\n---TOTAL COSTS OF TYPE---");
            Console.WriteLine($"Total Khu dat: {totalKhuDat} VND");
            Console.WriteLine($"Total Nha pho: {totalNhaPho} VND");
            Console.WriteLine($"Total Chung cu: {totalChungCu} VND");

            Console.WriteLine("\n---PROPERTIES THAT MEET THE CONDITION---");
            foreach (var x in list)
            {
                if (x is NhaPho np)
                {
                    if (x.GetArea() > 60 && np.GetBuiltYear() >= 2019)
                    {
                        x.Output();
                    }
                }
                else if (!(x is ChungCu))
                {
                    if (x.GetArea() > 100)
                    {
                        x.Output();
                    }
                }
            }
            Console.WriteLine("\n---SEARCHING PROPERTIES---");
            Console.Write("Enter the location must find: ");
            string key = Console.ReadLine().ToLower();
            Console.Write("Enter maximum cost: ");
            long costs = long.Parse(Console.ReadLine());
            Console.Write("Enter minimum area: ");
            double areas = double.Parse(Console.ReadLine());

            Console.WriteLine("\n---RESULT OF SEARCHING---");
            foreach (var x in list)
            {
                if (x is NhaPho || x is ChungCu)
                {
                    if (x.GetLocation().ToLower().Contains(key) && x.GetCost() <= costs && x.GetArea() >= areas)
                    {
                        x.Output();
                    }
                }
            }
        }
    }
}