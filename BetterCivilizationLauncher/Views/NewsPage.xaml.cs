using System;

using BetterCivilizationLauncher.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BetterCivilizationLauncher.Views
{
    public sealed partial class NewsPage : Page
    {
        public NewsViewModel ViewModel { get; } = new NewsViewModel();

        public NewsPage()
        {
            InitializeComponent();
            Loaded += NewsPage_Loaded;
        }

        private async void NewsPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(ListDetailsViewControl.ViewState);
        }
    }
}
