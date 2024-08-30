using System;
using System.IO;
/*
 The given text file contains 5 set of user IDs and Password. 
 The file stores userID and password in the following format:
<User>, <password>
Hello, abc1234
Admin, admin,
User, user
Write a program to read a given text file and print the data about the user Id and password. 
Write appropriate exception handling code to handle exceptions which might occur while reading the text file.  
 */


namespace Week6LabProgram
{
    class Program2
    {
        static void Main(string[] args)
        {
            try
            {
                // Write the code to read the text file line wise
                // Hint: Use ReadAllLines()
                string[] lines = System.IO.File.ReadAllLines("userIdDB.txt");

                // Split each line using "," as delimiter and print the values as
                // User Name: ------, Passowrd: .... "
                // Hint: use foreach loop
                foreach (string set in lines)
                {
                    // Split each line
                    string[] splits = set.Split(',');
                    //Display the values of username and password
                    Console.WriteLine("UserName: {0}, Password: {1}", splits[0], splits[1]);
                }
                // Ready an key from user                
                Console.ReadKey();
            }
            // Catch the FileNotFoundException exception
            catch(FileNotFoundException e)
            {
                // Display the error message
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

        }
    }
}

/*
Test Case:
Expeted Output: 

UserName: admin, Password: admin
UserName: normaluser, Password: user
UserName: Adam, Password: hello
UserName: George, Password: yessir
UserName: hacker, Password: nohack

    */