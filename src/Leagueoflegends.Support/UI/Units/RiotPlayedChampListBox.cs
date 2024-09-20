using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Leagueoflegends.Support.UI.Units;
public class RiotPlayedChampListBox : ListBox
{
    public RiotPlayedChampListBox()
    {
        DefaultStyleKey = typeof(RiotPlayedChampListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotPlayedChampListBoxItem();
    }
}
