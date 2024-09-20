using Jamesnet.WinUI3;
using Microsoft.UI.Xaml;

namespace Leagueoflegends.Support.UI.Units;

public class RiotFriendGroupItem : RecursiveControl
{
    public RiotFriendGroupItem()
    {
        DefaultStyleKey = typeof(RiotFriendGroupItem);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotFriendItemControl();
    }
}
