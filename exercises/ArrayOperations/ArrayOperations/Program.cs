﻿using System;
// Write a program to Create a ArrayDB class as per below specification
/*
-------------------------------
 | ArrayDB                    |
 -------------------------------
 | - userData: int[]		  |
 | - numberOfElement: int     |
 | - meanValue : double	      |
 | - varianceValue : double   |
 | - sdValue : double         |
 -------------------------------
 | + ArrayDB()		          |
 | + getUserData()            |
 | + CalculateMean():double   |
 | + CalulateVariance():double|
 | + CalculateSD(): double    |
 -------------------------------

    ArrayDB: 1. Contructor to accept the number of Element to inserted into the array from user and store it in numberOfElement
             2. initialize the array with the number of element value

    getUserData: Gets value from the user to store in the array

    CalculateMean: Calculates the mean of the values in the array (Check Tutorial instructions for formula)
    CalulateVariance: Calculates the variance of the values in the array(Check Tutorial instructions for formula)
    CalculateSD: Calculates the Standard Deviation of the values in the array(Check Tutorial instructions for formula)

    In the Main() method:
    1. Create an Object of the arrayDB class
    2. Call the getUserData() and populate the array
    3. Call the methods for mean, variance and Standard Deviation and display the results

    Example Test case:

    Enter the number of elements in the array: 5
    Enter the element 0:1
    Enter the element 1:2
    Enter the element 2:3
    Enter the element 3:4
    Enter the element 4:5

    The Mean is 3
    The Variance is 2.5
    The Standard Deviation is 1.58113883008419

    */


namespace Week4LabProgramQuestion
{
    class ArrayDB
    {
        // Declare private fields
        private int[] userData;
        private int numberOfElement;
        private double meanValue, varianceValue, sdValue;
        
        // Default Constructor 
        public ArrayDB()
        {
            Console.WriteLine("Enter the number of elements in the array:");
            string userInput = Console.ReadLine();
            numberOfElement = Convert.ToInt32(userInput);

            userData = new int[numberOfElement];
        }
        // Method to populate the array with user input
        public void getUserData()
        {
            
            for (int loopVar =0; loopVar < numberOfElement; loopVar++)
            {
                Console.Write("Enter the element {0}:", loopVar);
                string userinput = Console.ReadLine();
                userData[loopVar] = Convert.ToInt32(userinput);
            }
        }
        // Method to calculate Mean
        public double CalculateMean()
        {
            int sum = 0;
            for(int loopVar = 0; loopVar < userData.Length; loopVar++)
            {
                sum += userData[loopVar];
            }
            meanValue = sum / userData.Length;
            return (meanValue);
        }
        // Method to calculate variance
        public double CalulateVariance()
        {
            double sum = 0;
            for(int loopVar = 0; loopVar < numberOfElement; loopVar++)
            {
                sum += (userData[loopVar] - meanValue) * (userData[loopVar] - meanValue);
            }
            varianceValue = sum / (numberOfElement - 1);
            return (varianceValue);
        }
        // Method to calculate Standard Deviation
        public double CalculateSD()
         {
            sdValue = Math.Sqrt(varianceValue);
            return (sdValue);
         }        
    }

    class ArrayOperationsTest
    {
        static void Main(string[] args)
        {
            // Create ArrayDB object
            ArrayDB newDB = new ArrayDB();

            // Get user input
            newDB.getUserData();

            // Calculate and display mean, variance and Standard Deviation
            Console.WriteLine("The Mean is {0}", newDB.CalculateMean());
            Console.WriteLine("The Variance is {0}", newDB.CalulateVariance());
            Console.WriteLine("The Standard Deviation is {0}", newDB.CalculateSD());

            // Accept key press from user
            Console.ReadKey();            
        }
    }
}

/*
    Test case 1:

    Enter the number of elements in the array: 5
    Enter the element 0:1
    Enter the element 1:2
    Enter the element 2:3
    Enter the element 3:4
    Enter the element 4:5

    The Mean is 3
    The Variance is 2.5
    The Standard Deviation is 1.58113883008419
    
    */
