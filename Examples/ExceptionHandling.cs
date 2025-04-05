using System;

namespace SharpNotes.Examples
{
    class ExceptionHandling
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== Exception Handling Examples ===");

            try
            {
                // Attempt to divide by zero to trigger an exception
                int result = Divide(10, 0);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }

            try
            {
                // Throw a custom exception
                ThrowCustomException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught a custom exception: {ex.Message}");
            }
        }

        static int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        static void ThrowCustomException()
        {
            throw new Exception("This is a custom exception.");
        }
    }
} 