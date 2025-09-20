using Historico.Models;

namespace Historico.ViewModels;

public class DetailViewModel
{
    public HistoryItem Item { get; }

    public DetailViewModel(HistoryItem item)
    {
        Item = item;
    }

    // Expose convenience properties for binding if needed:
    public string Title => Item?.Title ?? string.Empty;
    public string Subtitle => Item?.Subtitle ?? string.Empty;
    public string Content => Item?.Content ?? string.Empty;
    public string Image => Item?.Image ?? "guide.png";
}
