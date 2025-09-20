using Historico.Models;
using Historico.ViewModels;
using Microsoft.Maui.Controls;

namespace Historico.Views;

public partial class DetailPage : ContentPage
{
    public DetailPage(HistoryItem item)
    {
        InitializeComponent();
        BindingContext = new DetailViewModel(item);
    }

    void OnBackTapped(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}
