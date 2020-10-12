using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpiralTraverseVisualizer
{
    public interface IAnimationOptions
    {
        IEnumerable<IAnimationFrame> AnimationFrames { get; }
        ushort MillisecondsDelay { get; }
    }
}
