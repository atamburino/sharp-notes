using System;
using SharpNotes.Examples;

namespace SharpNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SharpNotes - Your C# Learning Notebook!");
            Console.WriteLine("Date: March 31st, 2025");
            Console.WriteLine("----------------------------------------");
            
            // Run collections example
            CollectionsAndLinq.RunExamples();
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
} 