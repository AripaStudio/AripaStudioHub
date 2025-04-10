using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Transformation;
using Avalonia.Threading;
using ReactiveUI;

namespace AripaStudioHub.Class
{
    public static class MessageBoxAP
    {
        
        public static async Task MessageBoxShowOK(string title, string message)
        {
            var dialog = new Window
            {
                Title = title,
                Width = 300,
                Height = 150,
                CanResize = false
            };
            dialog.Content = new StackPanel
            {
                Orientation = Orientation.Vertical,
                Children =
                {
                    new TextBlock
                    {
                        Text = message,
                        Margin = new Thickness(10),
                        TextWrapping = TextWrapping.Wrap
                    },
                    new Button
                    {
                        Content = "OK",
                        HorizontalAlignment = HorizontalAlignment.Center,
                        Margin = new Thickness(10),
                        Command = ReactiveUI.ReactiveCommand.Create(() => CloseDiaog(dialog))
                    }
                }
            };
            await Dispatcher.UIThread.InvokeAsync(async () =>
            {
                await dialog.ShowDialog(App.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop ? desktop.MainWindow : null);
            });
        }

        static void CloseDiaog(Window dlg)
        {
            dlg.Close();
        }
    }
}
