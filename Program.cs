using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Definition");
            /* Methods are used to break down code into smaller, manageable parts. 
               They cannot be written standalone; they must be written within a class. 
               Methods are beneficial for code organization and readability. */

            int a = 2;
            int b = 3;

            // Using the plus method to add two numbers
            int result = Plus(a, b);
            Console.WriteLine("Result of a + b: " + result);

            // Creating an instance of the 'themethod' class
            Themethod home = new Themethod();

            // Using the Printforscreen method to print the result
            home.Printforscreen(Convert.ToString(result));

            // Using the plusplus method to increment and add two numbers
            int result2 = home.Plusplus(a, b);
            home.Printforscreen(Convert.ToString(result2));
        }

        // Defining the 'Plus' method to add two integers
        static int Plus(int value1, int value2)
        {
            // The method takes two parameters (value1 and value2) and returns their sum
            return (value1 + value2);
        }

        // Creating a class named 'Themethod'
        class Themethod
        {
            // Method to print a string to the console
            public void Printforscreen(string message)
            {
                Console.WriteLine(message);
            }

            // Method to increment and add two integers
            public int Plusplus(int value1, int value2)
            {
                value1 += 1;
                value2 += 1;
                return value1 + value2;
            }
        }
    }
}
