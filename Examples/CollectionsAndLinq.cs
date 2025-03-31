using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpNotes.Examples
{
    class CollectionsAndLinq
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== Collections and LINQ Examples ===");
            
            // List example
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("\nOriginal numbers: " + string.Join(", ", numbers));
            
            // LINQ Where example
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
            
            // LINQ Select example
            var squaredNumbers = numbers.Select(n => n * n);
            Console.WriteLine("Squared numbers: " + string.Join(", ", squaredNumbers));
            
            // Dictionary example
            var fruits = new Dictionary<string, int>
            {
                { "Apple", 5 },
                { "Banana", 3 },
                { "Orange", 7 }
            };
            
            Console.WriteLine("\nFruit inventory:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine($"{fruit.Key}: {fruit.Value}");
            }
        }
    }
} 