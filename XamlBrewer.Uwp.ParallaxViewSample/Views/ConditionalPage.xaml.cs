using Mvvm.Services;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.ParallaxViewSample
{
    public sealed partial class ConditionalPage : Page
    {
        public ConditionalPage()
        {
            InitializeComponent();

            Loaded += ConditionalPage_Loaded;
        }

        private void ConditionalPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (Sdk.SupportsParallaxView)
            {
                // Insert ParallaxView.
                var parallax = new ParallaxView();
                parallax.Source = ForegroundElement;
                parallax.VerticalShift = 100;
                Grid.SetColumn(parallax, 2);
                ContentGrid.Children.Remove(BeachImage);
                parallax.Child = BeachImage;
                ContentGrid.Children.Insert(0, parallax);
            }
        }
    }
}
