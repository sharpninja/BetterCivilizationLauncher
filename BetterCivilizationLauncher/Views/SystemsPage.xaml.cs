using System;

using BetterCivilizationLauncher.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BetterCivilizationLauncher.Views
{
    public sealed partial class SystemsPage : Page
    {
        public SystemsViewModel ViewModel { get; } = new SystemsViewModel();

        public SystemsPage()
        {
            InitializeComponent();
        }
    }
}
