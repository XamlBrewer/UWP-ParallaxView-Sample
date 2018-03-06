namespace Mvvm.Services
{
    using Windows.Foundation.Metadata;

    public static class Sdk
    {
        public static bool SupportsParallaxView
        {
            get
            {
                return ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 5);
            }
        }
    }
}
