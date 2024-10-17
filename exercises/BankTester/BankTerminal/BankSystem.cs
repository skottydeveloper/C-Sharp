using System;

namespace BankTerminal
{
    public class BankSystem
    {
        private double balance;

        private BankSystem(double initialBalance)
        {
            this.balance = initialBalance;
        }

        // should return null if the value of initial balance is negative
        public static BankSystem CreateSystem(double initalBalance) {
            if (initalBalance < 0) return null;
            if (initalBalance > 100000) return null;
            return new BankSystem(initalBalance);
        }

        // should return the current balance to 2 decimal places
        public double CheckBalance()
        {
            return Math.Round(balance, 2);
        }

        // method should return true if deposit is successful
        public bool Deposit(double amount)
        {
            if (amount <= 0) return false;
            if (amount >= 10000) return false;
            balance += amount;
            return true;
        }

        // method should return true if withdrawl is successful
        public bool Withdraw(double amount)
        {
            if (amount <= 0) return false;
            if (balance - amount < 0) return false;
            if (amount >= 10000) return false;
            balance -= amount;
            return true;
        }
    }
}
