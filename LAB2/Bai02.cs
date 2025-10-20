using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB2
{
    internal class Bai02
    {
        public static void Bai02_Run()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Enter folder path: ");
            string path = Console.ReadLine();
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Invalid folder!");
                return;
            }
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine($"\n Directory of {path}\n");
            int fileCount = 0;
            int dirCount = 0;
            long totalSize = 0;

            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                Console.WriteLine($"{subDir.LastWriteTime:MM'/'dd'/'yyyy hh:mm tt} {"<DIR>",10}   {subDir.Name}");
                dirCount++;
            }

            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine($"{file.LastWriteTime:MM/dd/yyyy hh:mm tt} {file.Length,20:N0}  {file.Name}");
                totalSize += file.Length;
                fileCount++;
            }
            Console.WriteLine($"\n{fileCount,12} File(s) {totalSize,15:N0} bytes");
            Console.WriteLine($"{dirCount,12} Dir(s) {GetDriveFreeSpace(path),15:N0} bytes free");
            Console.ReadKey();
        }
        static long GetDriveFreeSpace(string path)
        {
            DriveInfo drive = new DriveInfo(Path.GetPathRoot(path));
            return drive.AvailableFreeSpace;
        }
    }
}