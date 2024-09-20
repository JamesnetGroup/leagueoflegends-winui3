using Jamesnet.Core;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace Jamesnet.WinUI3
{
    public class WinUI3Layer : ContentControl, ILayer
    {
        public static readonly DependencyProperty LayerNameProperty =
            DependencyProperty.Register(nameof(LayerName), typeof(string), typeof(WinUI3Layer), new PropertyMetadata(null, OnLayerNameChanged));
        private bool _isRegistered = false;
        public string LayerName
        {
            get => (string)GetValue(LayerNameProperty);
            set => SetValue(LayerNameProperty, value);
        }


        public WinUI3Layer()
        {
            DefaultStyleKey = typeof(WinUI3Layer);
            Loaded += WinUI3Layer_Loaded;
        }
        private void WinUI3Layer_Loaded(object sender, RoutedEventArgs e)
        {
            RegisterToLayerManager();
        }
        private void RegisterToLayerManager()
        {
            System.Diagnostics.Debug.WriteLine($"RegisterToLayerManager called for {LayerName}");
            if (string.IsNullOrEmpty(LayerName) || _isRegistered)
            {
                System.Diagnostics.Debug.WriteLine($"Early return for {LayerName}. IsRegistered: {_isRegistered}");
                return;
            }
            try
            {
                var container = ContainerProvider.GetContainer();
                System.Diagnostics.Debug.WriteLine($"Container retrieved for {LayerName}");
                var layerManager = container.Resolve<ILayerManager>();
                if (layerManager != null)
                {
                    layerManager.Register(LayerName, this);
                    _isRegistered = true;
                    System.Diagnostics.Debug.WriteLine($"Layer {LayerName} registered successfully");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"LayerManager is null for {LayerName}");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in RegisterToLayerManager for {LayerName}: {ex}");
            }
        }
        private static void OnLayerNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WinUI3Layer layer)
            {
                layer._isRegistered = false;  // Reset registration status when LayerName changes
                layer.RegisterToLayerManager();
            }
        }
    }
}