using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\SAMPLES";
            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            string filelName = Console.ReadLine();
            
            //File.Create($"{rootDirectory}\\{newDirectory}\\{filelName}");

            if (Directory.Exists($"{rootDirectory}\\{ newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{filelName}"))
            {
                Console.WriteLine($"Directory and File exist.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{filelName}");
            }
        }
    }
}
 