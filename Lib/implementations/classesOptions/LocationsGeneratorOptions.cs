
namespace MatrixSpiralTraverseVisualizer
{
    internal class LocationsGeneratorOptions : ILocationsGeneratorOptions
    {
        public int gridRowsCount { get; set; }
        public int gridColumnsCount { get; set; }
      
        public I2dLocation firstPoint { get; set; }
        public I2dLocation secondPoint { get; set; }
        public I2dLocation startingPoint { get; set; }
        
        public IEnumerable<Direction> pattern { get; set; }
        public byte maximumFullPatternsCount { get; set; }

        public LocationsGeneratorOptions(IEnumerable<Direction> pattern, byte maximumFullPatternsCount, int gridRowsCount, int gridColumnsCount, I2dLocation firstPoint, I2dLocation secondPoint, I2dLocation startingPoint)
        {
            this.pattern = pattern; 
            this.maximumFullPatternsCount = maximumFullPatternsCount;
            this.gridRowsCount = gridRowsCount;
            this.gridColumnsCount = gridColumnsCount;
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.startingPoint = startingPoint;
        }
    }
}
