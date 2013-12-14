using System.Linq;
using NUnit.Framework;

namespace Solver.Tests
{
    [TestFixture]
    public class UniverseTests
    {
        [Test]
        public void GetLivingCells_OnEmptyUniverse_ReturnsEmptyList()
        {
            var seed = Enumerable.Empty<ICoordinates>();
            var universe = new Universe(seed);
            var livingCells = universe.GetLivingCellsCoordinates();
            
            Assert.IsEmpty(livingCells);
        }

        [Test]
        public void GetLivingCells_NonEmptyUniverse_ReturnsNonEmptyList()
        {
            int dummyX = 2;
            int dummyY = 3;

            var seed = Enumerable.Repeat<ICoordinates>(new Coordinates(dummyX, dummyY), 3);
            var universe = new Universe(seed);
            var livingCells = universe.GetLivingCellsCoordinates();

            Assert.IsNotEmpty(livingCells);
        }

        [Test]
        public void GetLivingCells_NonEmptyUniverse_ReturnsEquivalentList()
        {
            int dummyX = 2;
            int dummyY = 3;

            var seed = Enumerable.Repeat<ICoordinates>(new Coordinates(dummyX, dummyY), 3);
            var universe = new Universe(seed);
            var livingCells = universe.GetLivingCellsCoordinates();

            CollectionAssert.AreEquivalent(seed, livingCells);
        }
    }
}