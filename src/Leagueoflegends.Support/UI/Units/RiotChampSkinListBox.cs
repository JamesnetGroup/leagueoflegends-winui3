using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotChampSkinListBox : ListBox
{
    public RiotChampSkinListBox()
    {
        DefaultStyleKey = typeof(RiotChampSkinListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotChampSkinGroupItem();
    }
}
