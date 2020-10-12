using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpiralTraverseVisualizer
{
    public interface IPath
    {
        IColored2dLocations ColoredLocations { get; }
        PathType PathType { get; }
        uint CellsToProcessAtTheSameTime { get; }
    }
}
