using System;
using System.IO;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your personality defining color (Red, Blue, Green, Yellow)");
            string userColor = Console.ReadLine();
            Console.WriteLine(GetPersonalityData(userColor));
        }
        public static string[] ReadPersonalityFile()
        {
            string filePath = @"C:\Users\Laptop\samples\personality.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
        public static string GetPersonalityData(string userInput)
        {
            string[] horoscope = ReadPersonalityFile();
            string personality = "";
            foreach (string element in horoscope)
            {
                if (element.Contains(userInput))
                {
                    personality = element;
                }

            }
            return personality;
        }
    }
}
