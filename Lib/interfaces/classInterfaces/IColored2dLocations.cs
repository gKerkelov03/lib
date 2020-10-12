using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpiralTraverseVisualizer
{
    public interface IColored2dLocations
    {
        IEnumerable<I2dLocation> Locations { get; }
        Color Color { get; }
    }
}
