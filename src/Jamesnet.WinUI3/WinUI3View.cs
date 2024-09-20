using Jamesnet.Core;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Jamesnet.WinUI3;

public class WinUI3View : ContentControl, IView
{
    private bool _viewModelInitialized = false;

    public WinUI3View()
    {
        DefaultStyleKey = typeof(WinUI3View);
        InitializeViewModel();
        Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        if (_viewModelInitialized && DataContext is IViewLoadable loadable)
        {
            loadable.Loaded();
        }
        Loaded -= OnLoaded;
    }

    public void InitializeViewModel()
    {
        var initializer = ContainerProvider.GetContainer().Resolve<IViewModelInitializer>();
        initializer.InitializeViewModel(this);

        _viewModelInitialized = DataContext != null;

        OnViewModelInitialized();
    }

    protected virtual void OnViewModelInitialized()
    {
    }
}
