using System;

using BetterCivilizationLauncher.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BetterCivilizationLauncher.Views
{
    public sealed partial class WebViewPage : Page
    {
        public WebViewViewModel ViewModel { get; } = new WebViewViewModel();

        public WebViewPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
