using System;

using BetterCivilizationLauncher.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BetterCivilizationLauncher.Views
{
    public sealed partial class NewsDetailControl : UserControl
    {
        public SampleOrder ListMenuItem
        {
            get { return GetValue(ListMenuItemProperty) as SampleOrder; }
            set { SetValue(ListMenuItemProperty, value); }
        }

        public static readonly DependencyProperty ListMenuItemProperty = DependencyProperty.Register("ListMenuItem", typeof(SampleOrder), typeof(NewsDetailControl), new PropertyMetadata(null, OnListMenuItemPropertyChanged));

        public NewsDetailControl()
        {
            InitializeComponent();
        }

        private static void OnListMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as NewsDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
