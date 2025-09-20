using System.Collections.ObjectModel;

namespace Historico.Models;

public class HistorySection
{
    public string Title { get; set; } = string.Empty;
    public ObservableCollection<HistoryItem> Items { get; set; } = new ObservableCollection<HistoryItem>();
}
