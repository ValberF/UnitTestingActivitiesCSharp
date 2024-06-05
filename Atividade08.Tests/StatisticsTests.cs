using Xunit;
using System;
using System.Collections.Generic;

namespace Atividade08.Tests
{
    public class StatisticsTests
    {
        [Fact]
        public void CalculateAverage_ShouldReturnCorrectAverage_WhenListIsValid()
        {
            var statistics = new Statistics();
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            var result = statistics.CalculateAverage(numbers);

            Assert.Equal(3.0, result, 1);
        }

        [Fact]
        public void CalculateAverage_ShouldThrowArgumentException_WhenListIsNull()
        {
            var statistics = new Statistics();

            Assert.Throws<ArgumentException>(() => statistics.CalculateAverage(null));
        }

        [Fact]
        public void CalculateAverage_ShouldThrowArgumentException_WhenListIsEmpty()
        {
            var statistics = new Statistics();
            var numbers = new List<int>();

            Assert.Throws<ArgumentException>(() => statistics.CalculateAverage(numbers));
        }
    }
}
