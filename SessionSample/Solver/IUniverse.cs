using System.Collections.Generic;

namespace Solver
{
    public interface IUniverse
    {
        IEnumerable<ICoordinates> GetLivingCellsCoordinates();
    }
}