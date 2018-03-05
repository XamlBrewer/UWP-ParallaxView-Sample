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

        private void VerticalShift_ValueChanged(object sender, Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            Parallax.VerticalShift = e.NewValue;
        }

        private void VerticalSourceStartOffset_ValueChanged(object sender, Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            Parallax.VerticalSourceStartOffset = e.NewValue;
        }

        private void VerticalShiftClamped_Toggled(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Parallax.IsVerticalShiftClamped = (sender as ToggleSwitch).IsOn;
        }

        private void VerticalSourceOffsetKind_Toggled(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Parallax.VerticalSourceOffsetKind = (sender as ToggleSwitch).IsOn ? ParallaxSourceOffsetKind.Absolute : ParallaxSourceOffsetKind.Relative;
        }

        private void VerticalSourceEndOffset_ValueChanged(object sender, Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            Parallax.VerticalSourceEndOffset = e.NewValue;
        }
    }
}
