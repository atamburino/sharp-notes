using System;
using System.Threading.Tasks;
using SharpNotes.Examples;

namespace SharpNotes
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to SharpNotes - Your C# Learning Notebook!");
            Console.WriteLine("Date: April 3rd, 2025");
            Console.WriteLine("----------------------------------------");
            
            // Run collections example
            CollectionsAndLinq.RunExamples();
            
            // Run async/await example
            await AsyncAwait.RunExamples();
            
            // Run file operations example
            FileOperations.RunExamples();
            
            // Run OOP example
            OOPExample.RunExamples();
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
} 