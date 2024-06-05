using Xunit;
using System;

namespace Atividade13.Tests
{
    public class FactorialCalculatorTests
    {
        [Fact]
        public void Calculate_ShouldThrowArgumentException_WhenNumberIsNegative()
        {
            var calculator = new FactorialCalculator();

            Assert.Throws<ArgumentException>(() => calculator.Calculate(-1));
        }

        [Fact]
        public void Calculate_ShouldReturn1_WhenNumberIs0()
        {
            var calculator = new FactorialCalculator();

            var result = calculator.Calculate(0);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Calculate_ShouldReturn1_WhenNumberIs1()
        {
            var calculator = new FactorialCalculator();

            var result = calculator.Calculate(1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Calculate_ShouldReturnCorrectFactorial_WhenNumberIsPositive()
        {
            var calculator = new FactorialCalculator();

            Assert.Equal(2, calculator.Calculate(2)); 
            Assert.Equal(6, calculator.Calculate(3)); 
            Assert.Equal(24, calculator.Calculate(4)); 
            Assert.Equal(120, calculator.Calculate(5));
        }

        [Fact]
        public void Calculate_ShouldHandleLargeNumbers()
        {
            var calculator = new FactorialCalculator();

            var result = calculator.Calculate(10);
            
            Assert.Equal(3628800, result);
        }
    }
}
