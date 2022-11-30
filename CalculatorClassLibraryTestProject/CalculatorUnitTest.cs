namespace CalculatorClassLibraryTestProject
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void SumTestMethod_WithValidInput_ReturnsValidResult() // +Ve Test Case
        {
            // AAA approach
            // A - Arrange
            CalculatorClassLibrary.Calculator target = new CalculatorClassLibrary.Calculator();
            int a = 20;
            int b = 20;
            int expected = 40;
            // A - Act
            int actual = target.Sum(a, b);
            // A - Assert
            // no if...else
            // no loops
            // no try..catch
            Assert.AreEqual(expected, actual);
        }
    }
}