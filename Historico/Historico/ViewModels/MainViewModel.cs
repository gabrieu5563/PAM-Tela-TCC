using Historico.Models;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Historico.ViewModels;

public class MainViewModel
{
    readonly INavigation _navigation;

    public ObservableCollection<HistorySection> Sections { get; } = new ObservableCollection<HistorySection>();

    public ICommand SelectHistoryCommand { get; }

    public MainViewModel(INavigation navigation)
    {
        _navigation = navigation;
        SelectHistoryCommand = new Command<HistoryItem>(async item =>
        {
            if (item == null) return;
            await _navigation.PushAsync(new Views.DetailPage(item));
        });

        LoadSample();
    }

    void LoadSample()
    {
        var hoje = new HistorySection { Title = "Hoje" };
        hoje.Items.Add(new HistoryItem { Title = "Ajuda para pedir Uber", Subtitle = "Passo rápido", Content = "Descricao breve do item." });

        var ontem = new HistorySection { Title = "Ontem" };
        ontem.Items.Add(new HistoryItem { Title = "Ajuda para pedir Ifood", Subtitle = "Pedido pelo app", Content = "Descricao breve do item." });
        ontem.Items.Add(new HistoryItem { Title = "Ajuda para mexer no NSA", Subtitle = "Configurar NSA", Content = "Passos para mexer no NSA..." });

        var semana = new HistorySection { Title = "Semana passada" };
        semana.Items.Add(new HistoryItem { Title = "Ajuda com NSA", Subtitle = "Outro item", Content = "Descricao..." });

        Sections.Add(hoje);
        Sections.Add(ontem);
        Sections.Add(semana);
    }
}
