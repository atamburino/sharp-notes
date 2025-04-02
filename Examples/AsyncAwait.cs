using System;
using System.Threading.Tasks;

namespace SharpNotes.Examples
{
    class AsyncAwait
    {
        public static async Task RunExamples()
        {
            Console.WriteLine("=== Async/Await Examples ===");
            
            Console.WriteLine("Starting async operations...");
            
            // Run multiple async operations
            var task1 = DoWorkAsync("Task 1", 2000);
            var task2 = DoWorkAsync("Task 2", 3000);
            
            // Wait for all tasks to complete
            await Task.WhenAll(task1, task2);
            
            Console.WriteLine("All tasks completed!");
        }
        
        private static async Task DoWorkAsync(string taskName, int delay)
        {
            Console.WriteLine($"{taskName} started");
            await Task.Delay(delay);
            Console.WriteLine($"{taskName} completed after {delay}ms");
        }
    }
} 