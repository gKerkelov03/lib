using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpiralTraverseVisualizer
{
    public interface IAnimationFrame : IEnumerable<IColored2dLocations>
    {
        
        IEnumerable<IColored2dLocations> WhatRemainsOnTheScreenAfterThisFrameFinishes{ get; }
    }
}
