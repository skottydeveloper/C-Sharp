using System;
using System.IO;

namespace MathPrinter
{
    public class Printer
    {
        public string[][] data;

        public Printer()
        {
            // read all the data from the data.txt and store it in the data variable
            string[] strings = File.ReadAllLines("../../../../Data.txt");
            data = new string[strings.Length][];
            for (int i = 0; i < strings.Length; i++)
            {
                data[i] = strings[i].Split(',');
            }
        }

        private void PrintData()
        {
            // prints out a table with all the results taking them directly from the file rather than recalculating them
            Console.WriteLine($"| Addition        | Subtraction      | Multiplication   | Division              |");
            Console.WriteLine($"---------------------------------------------------------------------------------");
            foreach (string[] values in data)
            {
                int num1 = int.Parse(values[0]);
                int num2 = int.Parse(values[1]);
                int add = int.Parse(values[2]);
                int sub = int.Parse(values[3]);
                int mul = int.Parse(values[4]);
                float div = float.Parse(values[5]);
                Console.WriteLine($"|{num1,3} + {num2,-3} = {add,-5}| {num1,3} - {num2,-3} = {sub,-5}| {num1,3} * {num2,-3} = {mul,-5}| {num1,3} / {num2,-3} = {div,-10}|");
            }
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.PrintData();
        }
    }
}
