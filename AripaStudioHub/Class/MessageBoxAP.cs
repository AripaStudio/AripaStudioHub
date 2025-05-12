using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        
        public static async Task MessageBoxShowOK(string title, string message , int width , int height)
        {
            var dialog = new Window
            {
                Title = title,
                Width = width,
                Height = height,
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

        //show a Game and software dialog but Not Image
        public static async Task ShowSoftWareSimpledialog(string title, string message, string nameGame,
            string linkDownload)
        {
            var dialog = new Window
            {
                Title = title,
                CanResize = false,
                Width = 600,
                Height = 300,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Background = Brushes.Beige
            };

            var stackPanel = new StackPanel
            {
                Orientation = Orientation.Vertical,
                Margin = new Thickness(10)
            };

            var grid = new Grid
            {
                Margin = new Thickness(10)
            };

            stackPanel.Children.AddRange(new Control[]
            {
                new Label
                {
                    Content = nameGame,
                    FontSize = 18,
                    Foreground = Brushes.Black
                },
                new TextBlock()
                {
                    Text = message,
                    FontSize = 15,
                    TextWrapping = TextWrapping.Wrap,
                    Foreground = Brushes.Black,
                    Margin = new Thickness(0, 10, 0, 0)
                },
                new Button
                {
                    Content = "Download",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(10),
                    Command = ReactiveCommand.Create(() =>
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = linkDownload,
                            UseShellExecute = true
                        });
                    })
                },
                new Button
                {
                    Content = "OK",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(10),
                    Command = ReactiveCommand.Create(() => CloseDiaog(dialog))
                }
            });
            grid.Children.Add(stackPanel);
            dialog.Content = grid;
            if (App.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                await dialog.ShowDialog(desktop.MainWindow);
            }


        }
        // Show a game and Software dialog with a title, message, name of the game, download link, and image
        public static async Task ShowGameDialog(string title, string message, string nameGame, string linkDownload, Avalonia.Media.IImage pathImage)
        {
            var dialog = new Window
            {
                Title = title,
                CanResize = false,
                Width = 800,
                Height = 400,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Background = Brushes.Beige
            };

            var grid = new Grid
            {
                ColumnDefinitions = new ColumnDefinitions("Auto, *"),
                Margin = new Thickness(10)
            };

            var imagePanel = new StackPanel
            {
                Orientation = Orientation.Vertical,
                Margin = new Thickness(0, 0, 10, 0)
            };
            imagePanel.Children.Add(new Image
            {
                Source = pathImage,
                Width = 300,
                Height = 300
            });
            Grid.SetColumn(imagePanel, 0);
            grid.Children.Add(imagePanel);

            var contentPanel = new StackPanel
            {
                Orientation = Orientation.Vertical,
                Margin = new Thickness(10, 0, 0, 0)
            };
            contentPanel.Children.AddRange(new Control[]
            {
            new Label
            {
                Content = nameGame,
                FontSize = 18,
                Foreground = Brushes.Black
            },
            new Label
            {
                Content = message,
                FontSize = 15,
                Foreground = Brushes.Black,
                Margin = new Thickness(0, 10, 0, 0)
            },
            new Button
            {
                Content = "Download",
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(10),
                Command = ReactiveCommand.Create(() =>
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = linkDownload,
                        UseShellExecute = true
                    });
                })
            },
            new Button
            {
                Content = "OK",
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(10),
                Command = ReactiveCommand.Create(() => CloseDiaog(dialog))
            }
                });
                Grid.SetColumn(contentPanel, 1);
                grid.Children.Add(contentPanel);

                dialog.Content = grid;

                
                if (App.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
                {
                    await dialog.ShowDialog(desktop.MainWindow);
                }
        }


       

    }

    }
