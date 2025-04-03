using System;
using System.IO;

namespace SharpNotes.Examples
{
    class FileOperations
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== File Operations Examples ===");
            
            string filePath = "example.txt";
            string contentToWrite = "Hello, this is a test file!";
            
            // Write to a file
            File.WriteAllText(filePath, contentToWrite);
            Console.WriteLine($"Written to file: {contentToWrite}");
            
            // Read from a file
            string readContent = File.ReadAllText(filePath);
            Console.WriteLine($"Read from file: {readContent}");
        }
    }
} 