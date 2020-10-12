using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpiralTraverseVisualizer
{
    public interface IAnimationFrameOptions
    {
        IEnumerable<KeyValuePair<IPath, IColored2dLocations>> PathsInformation { get; }
            
    }
}
