using System.Collections.Generic;

namespace MatrixSpiralTraverseVisualizer
{
    public interface IDrawingEngine
    {       
        void Draw(IEnumerable<I2dLocation> locationsToDrawOn, Color color);
        
        void Clear();
    }
}
