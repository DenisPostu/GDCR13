using System.Collections.Generic;

namespace Solver
{
    public class Universe : IUniverse
    {
        private readonly IEnumerable<ICoordinates> _seed;

        public Universe(IEnumerable<ICoordinates> seed)
        {
            _seed = seed;
        }

        public IEnumerable<ICoordinates> GetLivingCellsCoordinates()
        {
            return _seed;
        }
    }
}