using System;
using Xunit;

namespace ConsoleCalculator.Tests.XUnit
{
    public class ConsoleCalculatorShould
    {
        [Fact]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Assert.Throws<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            //Assert.Throws<CalculationException>(
            //    () => sut.Calculate(1, 1, "+"));  //fails

            Assert.ThrowsAny<CalculationException>(
                () => sut.Calculate(1, 1, "+"));

            var ex = Assert.Throws<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            Assert.Equal(ex.Operation, "+");
        }
    }
}
