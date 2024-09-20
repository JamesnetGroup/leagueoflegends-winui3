using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotFriendListBox : ListBox
{
    public RiotFriendListBox()
    {
        DefaultStyleKey = typeof(RiotFriendListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotFriendGroupItem();
    }
}
