
namespace BankTerminal.UnitTests
{
    public class Tests
    {
        private static BankSystem _bankSystem { get; set; } = null!;

        [TestCase(-100, false, "you cannot start with a negative balance.")]
        [TestCase(100, true, "This should be accepted.")]
        [TestCase(0, true, "This should be accepted.")]
        [TestCase(0.10, true, "This should be accepted.")]
        [TestCase(-0.10, false, "you cannot start with a negative balance.")]
        [TestCase(10000000, false, "initial balance should not be greater than 100000.")]
        [Test]
        public void Test_Constructor(double initialBalance, bool expected, string reason)
        {
            // checks that a bank system has been created correctly
            BankSystem system = BankSystem.CreateSystem(initialBalance);
            Assert.That((system != null) == expected, reason);
        }

        // test cases for depositing money

        [TestCase(20, double.MaxValue, 20, false, "Deposit Values should not be greater than or equal to 10000.")]
        [TestCase(20, 20.22, 40.22, true, "This should be accepted.")]
        [TestCase(20, 20, 40, true, "This should be accepted.")]
        [TestCase(20, -20, 20, false, "Deposit values should not be accepted if less than or equal to 0.")]
        [TestCase(20, 0, 20, false, "Deposit values should not be accepted if less than or equal to 0.")]
        [Test]
        public void Test_Deposit(double initialBal, double deposit, double closingBal, bool expectedResult, string reason)
        {
            // creates
            _bankSystem = BankSystem.CreateSystem(initialBal);
            Assert.That(_bankSystem != null, "check Test_Constructor results.");
            if (_bankSystem == null) { return; }

            // deposits some funds
            bool successful = _bankSystem.Deposit(deposit);
            Assert.That(successful == expectedResult, $"Bank System should not have accepted the deposit: {deposit}\n{reason}");
            // checks new balance
            double newBalance = _bankSystem.CheckBalance();
            Assert.That(closingBal == newBalance, $"Bank System does not accurately represent the expected closing balance.\nExpected: {closingBal}\nWas: {newBalance}");
        }


        // test cases for withdrawing money

        [TestCase(0, 10, 0, false, "Withdrawl values should not be accepted if balance is less than requested funds.")]
        [TestCase(100, 20, 80, true, "This should be accepted.")]
        [TestCase(100, 9999, 100, false, "Withdrawl values should not be accepted if balance is less than requested funds.")]
        [TestCase(90000, 100000000, 90000, false, "Withdrawl values should not be accepted if amount is greater than or equal to 10000.")]
        [TestCase(20.22, 20, 0.22, true, "This should be accepted.")]
        [TestCase(100, -20, 100, false, "Withdrawl values should not be accepted if the value is less than or equal to 0.")]
        [TestCase(20, 0, 20, false, "Withdrawl values should not be accepted if the value is less than or equal to 0.")]
        [Test]
        public void Test_Withdraw(double initialBal, double withdrawl, double closingBal, bool expectedResult, string reason)
        {
            
            // creates a banksystem
            _bankSystem = BankSystem.CreateSystem(initialBal);
            Assert.That(_bankSystem != null, "check Test_Constructor results.");
            if (_bankSystem == null) { return; }

            // withdraws some money
            bool successful = _bankSystem.Withdraw(withdrawl);
            Assert.That(successful == expectedResult, $"Bank System should not have accepted the withdrawl: {withdrawl}\n{reason}");
            // checks new balance
            double newBalance = _bankSystem.CheckBalance();
            Assert.That(closingBal == newBalance, $"Bank System does not accurately represent the expected closing balance.\nExpected: {expectedResult}\nWas: {newBalance}");
        }

        [TestCase(100)]
        [TestCase(100.20)]
        [TestCase(100.22222)]
        [Test]
        public void Test_CheckBalance(double initialBal)
        {
            _bankSystem = BankSystem.CreateSystem(initialBal);
            Assert.That(_bankSystem != null, "check Test_Constructor results.");
            if (_bankSystem == null) { return; }

            // checks that balance is accurate with initial balance
            double bal = _bankSystem.CheckBalance();
            double expected = Math.Round(initialBal, 2);
            Assert.That(bal == expected, $"Initial Balance:\nBalance should be rounded to 2 places\nExpected: {expected}\nWas: {bal}");

            // checks that balance is accurate when depositing
            _bankSystem = BankSystem.CreateSystem(0);
            _bankSystem.Deposit(initialBal);
            bal = _bankSystem.CheckBalance();
            expected = Math.Round(initialBal, 2);
            Assert.That(bal == expected, $"Depositing with No Initial Balance:\nBalance should be rounded to 2 places\nExpected: {expected}\nWas: {bal}");

            // checks that balance is accurate when depositing with initial balance
            _bankSystem = BankSystem.CreateSystem(initialBal);
            _bankSystem.Deposit(initialBal);
            bal = _bankSystem.CheckBalance();
            expected = Math.Round(initialBal * 2, 2);
            Assert.That(bal == expected, $"Depositing with Initial Balance:\nBalance should be rounded to 2 places\nExpected: {expected}\nWas: {bal}");

            // checks that balance is accurate when withdrawing with initial balance of 100000
            _bankSystem = BankSystem.CreateSystem(100000);
            _bankSystem.Withdraw(initialBal);
            bal = _bankSystem.CheckBalance();
            expected = Math.Round(100000 - initialBal, 2);
            Assert.That(bal == expected, $"Withdrawing with Initial Balance:\nBalance should be rounded to 2 places\nExpected: {expected}\nWas: {bal}");

        }
    }
}