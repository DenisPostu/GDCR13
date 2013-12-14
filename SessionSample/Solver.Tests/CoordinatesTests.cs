using NUnit.Framework;

namespace Solver.Tests
{
    [TestFixture]
    public class CoordinatesTests
    {
        private int _dummy = -1;

        [TestCase(1, ExpectedResult = 1)]
        [TestCase(11, ExpectedResult = 11)]
        [TestCase(21, ExpectedResult = 21)]
        [TestCase(41, ExpectedResult = 41)]
        [TestCase(5, ExpectedResult = 5)]
        public int Constructor_XCoordinateIsSetOk(int x)
        {
            return new Coordinates(x: x, y: _dummy).X;
        }

        [TestCase(1, ExpectedResult = 1)]
        [TestCase(11, ExpectedResult = 11)]
        [TestCase(21, ExpectedResult = 21)]
        [TestCase(41, ExpectedResult = 41)]
        [TestCase(5, ExpectedResult = 5)]
        public int Constructor_YCoordinateIsSetOk(int y)
        {
            return new Coordinates(x: _dummy, y: y).Y;
        }
    }
}
