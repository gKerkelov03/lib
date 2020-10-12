
namespace MatrixSpiralTraverseVisualizer
{
    internal class LocationsGenerator : ILocationsGenerator
    {
        private ILocationsGeneratorOptions options;
        private HashSet<I2dLocation> positionsBeen;
        private List<I2dLocation> result;
        private I2dLocation offsetEach;
        private byte fullPatternsCount;

        public LocationsGenerator(ILocationsGeneratorOptions options)
        {
            this.positionsBeen = new HashSet<I2dLocation>();
            this.result = new List<I2dLocation>();
        }

        public IEnumerable<I2dLocation> GenereateLocations()
        {
            if (result == null)
            {
                int currentRow;
                int currentCol;
                Queue<Direction> directionQueue = new Queue<Direction>();
                IEnumerator<Direction> enumerator = options.pattern.GetEnumerator();


                this.positionsBeen = null;
                this.result.TrimExcess();
            }

            return this.result;
        }
    }
}







