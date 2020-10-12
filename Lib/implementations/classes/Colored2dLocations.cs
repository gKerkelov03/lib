using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSpiralTraverseVisualizer
{
    internal class Colored2dLocations : IColored2dLocations
    {
        IEnumerable<I2dLocation> Locations { get; private set; }
        Color Color { get; private set; }

        public Colored2dLocations(IEnumerable<I2dLocation> locations, Color color)
        {
            this.Locations = locations;
            this.Color = color;
        }
    }
}
