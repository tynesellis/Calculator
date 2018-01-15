using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.Add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }

        [Fact]
        public void SubtractEm()
        {
            //Given this input to the method
            int sum = _calculator.Subtract(20, 10);

            //We are asserting the output should be as follows
            Assert.Equal(sum, 10);
        }

        [Fact]
        public void MultiplyEm()
        {
            //Given this input to the method
            int sum = _calculator.Multiply(10, 10);

            //We are asserting the output should be as follows
            Assert.Equal(sum, 100);
        }

        [Fact]
        public void DivideEm()
        {
            //Given this input to the method
            int sum = _calculator.Divide(100, 10);

            //We are asserting the output should be as follows
            Assert.Equal(sum, 10);
        }

    }
}
