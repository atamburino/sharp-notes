using System;

namespace SharpNotes.Examples
{
    class PropertiesAndRecords
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== Properties and Records Examples ===");
            
            // Traditional class with properties
            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };
            
            Console.WriteLine($"\nTraditional class: {person.FullName} is {person.Age} years old");
            
            // Record example (immutable by default)
            var book = new Book("C# Programming", "Jane Smith", 2025);
            Console.WriteLine($"\nRecord: {book.Title} by {book.Author} ({book.Year})");
            
            // Record with expression
            var updatedBook = book with { Year = 2026 };
            Console.WriteLine($"Updated record: {updatedBook.Title} ({updatedBook.Year})");
        }
    }
    
    // Traditional class with properties
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
        public string FullName => $"{FirstName} {LastName}";
    }
    
    // Record (immutable by default)
    record Book(string Title, string Author, int Year);
} 