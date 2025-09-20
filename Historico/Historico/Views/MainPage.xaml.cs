using Historico.ViewModels;
using Microsoft.Maui.Controls;

namespace Historico.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel(Navigation);
    }
}
