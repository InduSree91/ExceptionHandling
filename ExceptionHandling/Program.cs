// An exception is the C# object that represents an error

// When an exception occurs 3 things will happen
// 1. Program terminates or Program crashes 
// 2. Error message is displayed
// 3. Statements after the exception will not be executed


using System;

namespace ExceptionHandling
{
    class Exception
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                int result = num1 / num2;

                Console.WriteLine("Result is: " + result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You can not divide a number by zero");
                Console.WriteLine(ex.Message); // Prints the message that C# prints
            }

            Console.WriteLine("Ther is no error so this line is printing");
        }
    }
}