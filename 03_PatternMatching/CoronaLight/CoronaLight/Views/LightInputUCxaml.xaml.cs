using CoronaLight.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace CoronaLight.Views
{
    public sealed partial class LightInputUCxaml : UserControl
    {
        public LightInputUCxaml()
        {
            this.InitializeComponent();
        }

        public MainPageViewModel ViewModel
        {
            get => (MainPageViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(MainPageViewModel), typeof(LightInputUCxaml), new PropertyMetadata(null));
    }
}
