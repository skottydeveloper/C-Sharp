using System;
using System.IO;

namespace MathPrinter
{
    // this program was used to generate the messed up data
    internal class Program
    {
        public static Random rand = new Random();
        static void Main1(string[] args)
        {
            // collects two sets of random numbers between 0 and 101 exclusive (i.e. 1-100)
            string[] list = File.ReadAllLines("../../../../Math.txt");
            string[] row1 = list[0].Split(new char[] { ' ' });
            string[] row2 = list[1].Split(new char[] { ' ' });
            string[][] output = new string[row1.Length][];

            for (int i = 0; i < row1.Length; i++)
            {
                // generates numbers to decide if the numbers should be messed up
                bool doRand = rand.Next(0, 25) == 0;
                int pos = rand.Next(2, 6);
                int num1 = Convert.ToInt32(row1[i]);
                int num2 = Convert.ToInt32(row2[i]);
                int sum = num1 + num2;
                int minus = num1 - num2;
                int multiply = num1 * num2;
                float divide = (float) num1 / num2;
                // sets the output to the correct result
                output[i] = new string[] { num1.ToString(), num2.ToString(), sum.ToString(), minus.ToString(), multiply.ToString(), divide.ToString("0.00") };
                // if it's decided to mess the numbers replace a random result with a new random number
                if (doRand)
                {
                    output[i][pos] = Convert.ToString(rand.Next(1, 101));
                }
            }

            // print the output into the data.txt file
            string[] rows = new string[row1.Length];
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = string.Join(",", output[i]);
            }
            string result = string.Join("\n", rows);
            Console.WriteLine(result);
            Console.ReadKey();
            File.WriteAllText("../../../../Data.txt", result);
        }
    }
}
