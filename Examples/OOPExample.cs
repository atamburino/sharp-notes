using System;

namespace SharpNotes.Examples
{
    // Base class
    class Animal
    {
        // Property to store the name of the animal
        public string Name { get; set; }

        // Constructor to initialize the name
        public Animal(string name)
        {
            Name = name;
        }

        // Virtual method that can be overridden in derived classes
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // Derived class inheriting from Animal
    class Dog : Animal
    {
        // Constructor that calls the base class constructor
        public Dog(string name) : base(name)
        {
        }

        // Overriding the Speak method to provide specific behavior for Dog
        public override void Speak()
        {
            Console.WriteLine($"{Name} barks.");
        }
    }

    class OOPExample
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== Object-Oriented Programming Examples ===");

            // Create an instance of the base class
            Animal genericAnimal = new Animal("Generic Animal");
            genericAnimal.Speak(); // Calls the base class method

            // Create an instance of the derived class
            Dog dog = new Dog("Buddy");
            dog.Speak(); // Calls the overridden method in the derived class
        }
    }
} 