using ConsoleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsleCalculatir.Tests.MsTest
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Assert.ThrowsException<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            var ex = Assert.ThrowsException<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            Assert.AreEqual(ex.Operation, "+");

            //Assert.ThrowsException<CalculationException>(
            //    () => sut.Calculate(1, 1, "+"));
        }
    }
}
