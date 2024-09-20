using Leagueoflegends.Support.Local.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotStoreChampListBoxItem : ListBoxItem
{
    public static readonly DependencyProperty IsLockedProperty =
        DependencyProperty.Register(nameof(IsLocked), typeof(bool), typeof(RiotStoreChampListBoxItem),
            new PropertyMetadata(null, OnIsLockedChanged));

    public bool IsLocked
    {
        get => (bool)GetValue(IsLockedProperty);
        set => SetValue(IsLockedProperty, value);
    }

    public RiotStoreChampListBoxItem()
    {
        DefaultStyleKey = typeof(RiotStoreChampListBoxItem);

        DataContextChanged += RiotStoreChampListBoxItem_DataContextChanged;
    }

    private void RiotStoreChampListBoxItem_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
    {
        if (DataContext is StoreChamp viewModel)
        {
            IsLocked = viewModel.IsLocked;
        }
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState(false);
    }

    private static void OnIsLockedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotStoreChampListBoxItem item)
        {
            item.UpdateVisualState(true);
        }
    }

    private void UpdateVisualState(bool useTransitions)
    {
        string stateName = (bool)IsLocked ? "Locked" : "Unlocked";
        VisualStateManager.GoToState(this, stateName, useTransitions);
    }
}
