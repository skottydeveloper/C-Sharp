using System;

/*
  Write a program to create a MathOperation class with static methods for:
  1. Addtion
  2. Substration
  3. Multiplication
  4. Division
  5. Modulus 
  Operations on two integer.
  Use Multi-cast delegate to execute all the operations and remove some operations on two 
  integer numbers: 4 and 5
 
 */
namespace MathOperations
{
    // Create a delegate
    public delegate void mathop(int n1, int n2);

    // Create the MathOperation class
    class MathOperations
    {
        // Method to add two integers
        public static void add(int n1, int n2)
        {
            Console.WriteLine("{0} + {1} = {2}", n1, n2, (n1 + n2));
        }
        // Method to substract two integers
        public static void sub(int n1, int n2)
        {
            Console.WriteLine("{0} - {1} = {2}", n1, n2, (n1 - n2));
        }
        // Method to multiple two integers
        public static void mul(int n1, int n2)
        {
            Console.WriteLine("{0} X {1} = {2}", n1, n2, (n1 * n2));
        }
        // Method to divide two integers
        public static void divide(int n1, int n2)
        {
            Console.WriteLine("{0} / {1} = {2}", n1, n2, (n1 / n2));
        }
        // Method to calculate the modulus two integers
        public static void mod(int n1, int n2)
        {
            Console.WriteLine("{0} % {1} = {2}", n1, n2, (n1 % n2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the delegate
            mathop operation = new mathop(MathOperations.add);

            // Add all operations to the delegate
            operation += new mathop(MathOperations.sub);
            operation += new mathop(MathOperations.mul);
            operation += new mathop(MathOperations.divide);
            operation += new mathop(MathOperations.mod);
            Console.WriteLine("Executing the Multicast Delegate:");
            operation(5, 4);

            // Remove mul, and sub from the delegate
            Console.WriteLine("\nExecuting the Multicast Delegate after removing some operations:");
            operation -= new mathop(MathOperations.mod);
            operation -= new mathop(MathOperations.sub);
            
            operation(5, 4);

            Console.Read();
        }
    }
}
/*
Test case:

Executing the Multicast Delegate:
5 + 4 = 9
5 - 4 = 1
5 X 4 = 20
5 / 4 = 1
5 % 4 = 1

Executing the Multicast Delegate after removing some operations:
5 + 4 = 9
5 X 4 = 20
5 / 4 = 1
*/