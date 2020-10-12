using System.Collections.Generic;

namespace MatrixSpiralTraverseVisualizer
{
    public interface ILocationsGenerator
    {
        IEnumerable<I2dLocation> GenereateLocations();
    }
}
