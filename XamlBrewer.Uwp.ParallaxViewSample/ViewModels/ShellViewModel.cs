using Mvvm.Services;
using XamlBrewer.Uwp.ParallaxViewSample;

namespace Mvvm
{
    internal class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            // Build the menus
            Menu.Add(new MenuItem() { Glyph = Icon.GetIcon("HomeIcon"), Text = "Home", NavigationDestination = typeof(HomePage) });
            Menu.Add(new MenuItem() { Glyph = Icon.GetIcon("VerticalIcon"), Text = "Vertical", NavigationDestination = typeof(VerticalPage) });
            Menu.Add(new MenuItem() { Glyph = Icon.GetIcon("HorizontalIcon"), Text = "Horizontal", NavigationDestination = typeof(HorizontalPage) });
            Menu.Add(new MenuItem() { Glyph = Icon.GetIcon("ConfigurationIcon"), Text = "Configuration", NavigationDestination = typeof(ConfigurationPage) });
            Menu.Add(new MenuItem() { Glyph = Icon.GetIcon("ConditionsIcon"), Text = "Conditional", NavigationDestination = typeof(ConditionalPage) });

            SecondMenu.Add(new MenuItem() { Glyph = Icon.GetIcon("InfoIcon"), Text = "About", NavigationDestination = typeof(AboutPage) });
        }
    }
}
