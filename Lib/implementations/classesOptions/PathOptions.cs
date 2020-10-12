

namespace MatrixSpiralTraverseVisualizer
{
    internal class PathOptions
    {
        IColored2dLocations ColoredLocations { get; set; }
        PathType PathType { get; set; }
        uint CellsToProcessAtTheSameTime { get; set; }

        public PathOptions(IColored2dLocations coloredLocations, PathType pathType, uint cellsToProcessAtTheSameTime)
        {
            this.ColoredLocations = coloredLocations;
            this.CellsToProcessAtTheSameTime = cellsToProcessAtTheSameTime;
            this.PathType = pathType;
        }
    }
}
