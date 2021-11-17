using System;
using System.IO;

namespace CreateTITpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Sample";
            string userFolder = "TITpe21";
            string newDirectoryFullPath = @$"{rootDirectory}\{userFolder}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath);
            if (directoryExists)
            {
                Console.WriteLine($"{userFolder} directory already exists.");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userFolder} has been created");
            }
        }
    }
}
