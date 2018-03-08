using System;
using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.ParallaxViewSample
{
    public sealed partial class ConfigurationPage : Page
    {
        public ConfigurationPage()
        {
            InitializeComponent();
        }

        private void VerticalShiftClamped_Toggled(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Parallax.IsVerticalShiftClamped = (sender as ToggleSwitch).IsOn;
        }

        private void VerticalSourceOffsetKind_Toggled(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
           // Parallax.VerticalSourceOffsetKind = (sender as ToggleSwitch).IsOn ? ParallaxSourceOffsetKind.Absolute : ParallaxSourceOffsetKind.Relative;
        }
    }
}
