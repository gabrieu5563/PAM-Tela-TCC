namespace Historico.Models;

public class HistoryItem
{
    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Image { get; set; } = "guide.png"; // default image name (add to Resources/Images)
}
