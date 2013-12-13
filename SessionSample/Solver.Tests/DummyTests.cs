using NUnit.Framework;

namespace Solver.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy _instanceUnderTest;

        [SetUp]
        public void SetUp()
        {
            _instanceUnderTest = new Dummy();
        }

        [TestCase(10, ExpectedResult = 10)]
        public int Passthrought_ReturnsSameValue(int value)
        {
            return _instanceUnderTest.Passthrough(value);
        }
    }
}
