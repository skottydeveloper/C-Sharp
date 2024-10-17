using System;

namespace BankTerminal
{
    
    internal class Program
    {
        // use this to run some basic code, this will not affect any of the tests
        static void Main(string[] args)
        {
            BankSystem system = BankSystem.CreateSystem(0);
            system.Deposit(10);
            system.Withdraw(10);
            Console.WriteLine($"Current Balance: {system.CheckBalance()}");
        }
    }
}
