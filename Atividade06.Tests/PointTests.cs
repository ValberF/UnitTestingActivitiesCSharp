using Xunit;
using System;
using NSubstitute;

namespace Atividade06.Tests
{
    public class PointTests
    {
        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {
            double x = 3.0;
            double y = 4.0;

            Point point = new Point(x, y);

            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }

        [Fact]
        public void DistanceTo_ShouldReturnCorrectDistance()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(3, 4);

            double distance = point1.DistanceTo(point2);

            Assert.Equal(5.0, distance, 4);
        }

        [Fact]
        public void DistanceTo_ShouldThrowArgumentNullException_WhenOtherPointIsNull()
        {
            Point point = new Point(1, 1);

            Assert.Throws<ArgumentNullException>(() => point.DistanceTo(null));
        }

        [Fact]
        public void DistanceTo_ShouldReturnZero_WhenPointsAreTheSame()
        {
            Point point = new Point(2, 2);

            double distance = point.DistanceTo(point);

            Assert.Equal(0.0, distance, 4);
        }
    }
}
