using System;
using Avalonia.Controls;
using Avalonia.Platform;

namespace AripaStudioHub.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        SetWindowIcon();
    }

    private void SetWindowIcon()
    {
        var icon = new WindowIcon(AssetLoader.Open(new Uri("avares://AripaStudioHub/Assets/Icons/iconStudioMenuico.ico")));
        this.Icon = icon;
    }
}
