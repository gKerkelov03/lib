using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpiralTraverseVisualizer
{
    public interface ILocationsGeneratorOptions
    {
        int MatrixRowsCount { get; }
        int MatrixColumnsCount { get; }

        IEnumerable<KeyValuePair<Direction, uint>> pattern { get; }
        byte MaximumFullPatternsCount { get; }
        
        I2dLocation firstPoint { get; }
        I2dLocation secondPoint { get; }
        I2dLocation startingPoint { get; }
    }   
}
