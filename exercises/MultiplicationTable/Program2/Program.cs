﻿using System;
/*
Week3 Lab Program:
 
Questions:
    Write a C# Program to read a number as user input and display the multiplication table:

    Hint: Please check the code below and also the test cases before trying to solve the question!

*/
namespace Week3LabProgram
{
    class MutliplicationTable
    {
        public static void Main(string[] args)
        {
            // Write code to Declare Variables
            int userInput;

            // Write code to Display appropriate message to the user
            Console.Write("Enter the number (Table to be calculated): ");

            userInput = Convert.ToInt32(Console.ReadLine());

            // Write code to Calculate and display the multiplication table in a loop
            for (int i = 1; i <= 10; i++)
            {
                // Complete the code to calculate and diaplay the table
                Console.WriteLine("{0} X {1} = {2}", userInput, i, userInput * i);
            }

            // Write code to Accept a key input from user
            Console.ReadKey();
        }
    }
}

/*
Test Case:
Program to calculate multiplication table:
-------------------------------------------

Enter the number (Table to be calculated) : 3

3 X 1 = 3
3 X 2 = 6
3 X 3 = 9
3 X 4 = 12
3 X 5 = 15
:
3 X 10 = 30

    */
