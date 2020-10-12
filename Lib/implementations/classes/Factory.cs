
namespace MatrixSpiralTraverseVisualizer
{
    public static class Factory
    {
        public static IAnimation CreateAnimationFrame(IAnimationFrameOptions options)
        {
            CheckAnimationFrameOptions(options);
        }

        public static Path CreateScheme(IPathOptions options)
        {

        }

        public static ILocationsGenerator CreateLocationsGenerator(ILocationsGeneratorOptions options)
        {

        }
        
        private static void CheckAnimationFrameOptions(IAnimationFrameOptions options)
        {

        }

        private static void CheckSchemeOptions(IPathOptions options)
        {

        }

        private static void CheckLocationsGeneratorOptions(ILocationsGenerator options)
        {

        }

        private static T DeepCopy<T>(T objectToCopy)
        {
            
        }

        
    }
}
