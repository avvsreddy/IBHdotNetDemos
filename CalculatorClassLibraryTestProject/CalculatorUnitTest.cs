using CalculatorClassLibrary;
using Moq;

namespace CalculatorClassLibraryTestProject
{
    [TestClass]
    public class CalculatorUnitTest
    {
        Calculator target = null;
        Mock<ICalculatorResultRepository> mock = null;

        [TestInitialize]
        public void Init()
        {
            mock = new Mock<ICalculatorResultRepository>();
            mock.Setup(m => m.Save("10+10=20"));
            //MockCalculatorRepository mock = new MockCalculatorRepository();
            target = new Calculator(mock.Object);
        }

        [TestCleanup]
        public void Clean()
        {
            target = null;
        }

        [TestMethod]
        public void SumTestMethod_WithValidInput_ReturnsValidResult() // +Ve Test Case
        {
            // AAA approach
            // A - Arrange
            //CalculatorClassLibrary.Calculator target = new CalculatorClassLibrary.Calculator();
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
        [TestMethod]
        [ExpectedException(typeof(NotPositiveNumbersException))]
        public void Sum_WithNegativeInput_ThrowsExp()
        {
            //Calculator target = new Calculator();
            target.Sum(-10, -10);

        }

        [TestMethod]
        [ExpectedException(typeof(NotEvenNumbersException))]
        public void Sum_WithOddInput_ThrowsExp()
        {
            //Calculator target = new Calculator();
            target.Sum(11, 13);

        }

        [TestMethod]
        [ExpectedException(typeof(NotDoubleDigitException))]
        public void Sum_WithNotDoubleDigits_ThrowsExp()
        {
            //Calculator target = new Calculator();
            target.Sum(2, 4);
        }

        [TestMethod]
        public void Sum_WithValidInput_ShouldCallSave()
        {
            target.Sum(20, 20);
            mock.Verify(m => m.Save("20+20=40"), Times.AtLeastOnce);
        }
    }


    //class MockCalculatorRepository : ICalculatorResultRepository
    //{
    //    public void Save(string result)
    //    {

    //    }
    //}
}