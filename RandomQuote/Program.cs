using System;
using System.IO;

namespace RandomQuote
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine(RandomLineFromFile());   
        }
        private static string RandomLineFromFile()
        {
            string filePath = @"C:\Users\opilane\Sample\quotes.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, dataFromFile.Length);
            return dataFromFile[randomIndex];
        }
    }
}
