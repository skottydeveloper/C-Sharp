using NUnit.Framework;

namespace MathPrinter.nUnitTests
{
    public class Tests
    {
        private static Printer _mathPrinter { get; set; } = null!;
        
        // Generates all 1000 test cases to test in the later tests
        // The first two array variables are always correct
        // The last four variables are simple equations of the first two variables
        // The equations are addition, subtraction, multiplication, and division in that order
        // The division output is to 2 decimal places
        private static IEnumerable<int> GetTestCases()
        {
            _mathPrinter = new Printer();
            for (int i = 0; i < _mathPrinter.data.Length; i++)
            {
                yield return i;
            }
        }

        // tests the addition of the first two numbers in the data file and tests to see if they are correct
        [TestCaseSource(nameof(GetTestCases))]
        [Test]
        public void TestAddition(int position)
        {
            string[] values = _mathPrinter.data[position];

            int num1 = Convert.ToInt16(values[0]);
            int num2 = Convert.ToInt16(values[1]);
            float add = num1 + num2;

            Assert.That(add.ToString().Equals(values[2]), $"Addition on Line {position + 1} is incorrect.\n\tExpected: {add}\n\tBut was: {values[2]}");
        }

        // tests the subtraction of the first two numbers in the data file and tests to see if they are correct
        [TestCaseSource(nameof(GetTestCases))]
        [Test]
        public void TestSubtraction(int position)
        {
            string[] values = _mathPrinter.data[position];

            int num1 = Convert.ToInt16(values[0]);
            int num2 = Convert.ToInt16(values[1]);
            float sub = num1 - num2;

            Assert.That(sub.ToString().Equals(values[3]), $"Subtraction on Line {position + 1} is incorrect.\n\tExpected: {sub}\n\tBut was: {values[3]}");
        }

        // tests the multiplication of the first two numbers in the data file and tests to see if they are correct
        [TestCaseSource(nameof(GetTestCases))]
        [Test]
        public void TestMultiplication(int position)
        {
            string[] values = _mathPrinter.data[position];

            int num1 = Convert.ToInt16(values[0]);
            int num2 = Convert.ToInt16(values[1]);
            float mul = num1 * num2;

            Assert.That(mul.ToString().Equals(values[4]), $"Multiplication on Line {position + 1} is incorrect.\n\tExpected: {mul}\n\tBut was: {values[4]}");
        }

        // tests the division of the first two numbers in the data file and tests to see if they are correct
        [TestCaseSource(nameof(GetTestCases))]
        [Test]
        public void TestDivision(int position)
        {
            string[] values = _mathPrinter.data[position];

            int num1 = Convert.ToInt16(values[0]);
            int num2 = Convert.ToInt16(values[1]);
            float div = (float)num1 / num2;

            Assert.That(div.ToString("0.00").Equals(values[5]), $"Division on Line {position + 1} is incorrect.\n\tExpected: {div.ToString("0.00")}\n\tBut was: {values[5]}");
        }
    }
}