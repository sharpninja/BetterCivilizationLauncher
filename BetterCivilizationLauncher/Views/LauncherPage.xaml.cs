using System;

using BetterCivilizationLauncher.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BetterCivilizationLauncher.Views
{
    public sealed partial class LauncherPage : Page
    {
        public LauncherViewModel ViewModel { get; } = new LauncherViewModel();

        public LauncherPage()
        {
            InitializeComponent();
        }
    }
}
