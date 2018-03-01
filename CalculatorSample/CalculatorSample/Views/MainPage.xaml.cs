using System;

using CalculatorSample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace CalculatorSample.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
