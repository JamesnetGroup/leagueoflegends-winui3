using Microsoft.UI.Xaml.Controls;

namespace Leagueoflegends.Support.UI.Units;

// ScrollViewer is sealed in WinUI 3.0, so we need to create a custom control to extend it
public class RiotScrollViewer : Control
{
    public RiotScrollViewer()
    {
        DefaultStyleKey = typeof(RiotScrollViewer);
    }
}
