
using System.Collections.Generic;

namespace MatrixSpiralTraverseVisualizer
{
    internal class AnimationFrameOptions : IAnimationFrameOptions
    {
        IEnumerable<KeyValuePair<IPath, IColored2dLocations>> PathsInformation { get; }
        
    }
}
