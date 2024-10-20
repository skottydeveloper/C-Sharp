﻿using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class EmployeeList
    {
        // Create a List to store the information from emp.txt file
        private List<Employee> employees;

        // EmployeeList constructor
        public EmployeeList()
        {
            // Create an instance of List<>
            employees = new List<Employee>();
        }

        // Method to process a string which contain a single line for the emp.txt
        // The lfile name is passed as a parameter to the Method
        public void LoadEmployees(string filename)
        {
            // Read the file content using the StreamReader
            StreamReader fileContent = new StreamReader(filename);
            // Create an object of Employee class
            Employee empTemp;

            // Read the StremReader till the last line
            while (!fileContent.EndOfStream)                                                                                                                                                                                                             
            {
                // there are still employees to be loaded
                empTemp = new Employee();
                // Read each line and from the StreamReader
                string line = fileContent.ReadLine();
                // Load the employee detail from file to respective fields
                empTemp.LoadEmployee(line);
                // Add the detall to the list collection
                employees.Add(empTemp);
            }
            // Close the StreamReader
            fileContent.Close();
        }

        // Method to display the details for all the Employee
        public void PrintEmployees()
        {
            // prints each employee details in the employees list on a seperate line
            foreach (Employee tempEmp in employees)
            {
                Console.WriteLine("Employee Details: " + tempEmp.ToString());
            }

        }
        // Sort the employee details based on the Employee ID
        public void SortEmployees()
        {
            employees.Sort();
        }
    }
}
