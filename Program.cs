using System;

namespace SharpNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SharpNotes - Your C# Learning Notebook!");
            Console.WriteLine("Date: March 30th, 2:00 PM");
            Console.WriteLine("----------------------------------------");
            
            // Basic C# Concepts
            Console.WriteLine("\n1. Variables and Data Types:");
            int number = 42;
            string text = "Hello, C#!";
            bool isLearning = true;
            double pi = 3.14159;
            
            Console.WriteLine($"Integer: {number}");
            Console.WriteLine($"String: {text}");
            Console.WriteLine($"Boolean: {isLearning}");
            Console.WriteLine($"Double: {pi}");
            
            // Control Flow
            Console.WriteLine("\n2. Control Flow:");
            if (isLearning)
            {
                Console.WriteLine("You're learning C#!");
            }
            
            // Loops
            Console.WriteLine("\n3. Loops:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Loop iteration {i + 1}");
            }
            
            // Methods
            Console.WriteLine("\n4. Methods:");
            int sum = AddNumbers(5, 7);
            Console.WriteLine($"Sum of 5 and 7 is: {sum}");
            
            // Classes and Objects
            Console.WriteLine("\n5. Classes and Objects:");
            var person = new Person("John", 25);
            person.Introduce();
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
        // Example method
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
    
    // Example class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
        public void Introduce()
        {
            Console.WriteLine($"Hello, I'm {Name} and I'm {Age} years old.");
        }
    }
} 