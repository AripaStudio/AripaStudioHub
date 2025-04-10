using AripaStudioHub.Class;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AripaStudioHub.Views;

public partial class MainView : UserControl
{
    

    public string Btn_Text_MainPageEnglish = "Main Page";

    public string Btn_Text_MainPagePersian = "صفحه اصلی";

    public MainView()
    {
        InitializeComponent();
        MessageBoxAP.MessageBoxShowOK("Lang : ", GLV.GLV_Language);
        if (GLV.GLV_Language == "English")
        {
            Btn_main_page_border.Content = Btn_Text_MainPageEnglish;
        }
        else if (GLV.GLV_Language == "Persian")
        {
            Btn_main_page_border.Content = Btn_Text_MainPagePersian;
        }
        else
        {
            Btn_main_page_border.Content = Btn_Text_MainPageEnglish;
        }
    }

    private void Btn_main_page_border_OnClick(object? sender, RoutedEventArgs e)
    {
        Border_MainPage.IsVisible = true;
        Border_GamesAP.IsVisible = false;
        Border_SocialMediaLinks.IsVisible = false;
        Border_SoftWareAP.IsVisible = false;
        Border_Setting.IsVisible = false;
    }

    private void Btn_Social_Media_Links_page_border_OnClick(object? sender, RoutedEventArgs e)
    {
        Border_MainPage.IsVisible = false;
        Border_GamesAP.IsVisible = false;
        Border_SocialMediaLinks.IsVisible = true;
        Border_SoftWareAP.IsVisible = false;
        Border_Setting.IsVisible = false;
    }

    private void Btn_Game_page_border_OnClick(object? sender, RoutedEventArgs e)
    {
        Border_MainPage.IsVisible = false;
        Border_GamesAP.IsVisible = true;
        Border_SocialMediaLinks.IsVisible = false;
        Border_SoftWareAP.IsVisible = false;
        Border_Setting.IsVisible = false;
    }

    private void Btn_SoftWare_page_border_OnClick(object? sender, RoutedEventArgs e)
    {
        Border_MainPage.IsVisible = false;
        Border_GamesAP.IsVisible = false;
        Border_SocialMediaLinks.IsVisible = false;
        Border_SoftWareAP.IsVisible = true;
        Border_Setting.IsVisible = false;
    }

    private void Btn_Setting_page_border_OnClick(object? sender, RoutedEventArgs e)
    {
        Border_MainPage.IsVisible = false;
        Border_GamesAP.IsVisible = false;
        Border_SocialMediaLinks.IsVisible = false;
        Border_SoftWareAP.IsVisible = false;
        Border_Setting.IsVisible = true;
    }

    private void CheckBox_Lang_Persian_OnIsCheckedChanged(object? sender, RoutedEventArgs e)
    {
        if (sender is CheckBox checkbox)
        {
            if (checkbox.IsChecked == true)
            {
                GLV.GLV_Language = "Persian";
                CheckBox_Lang_English.IsEnabled = false;
            }
            else
            {
                GLV.GLV_Language = "English";
                CheckBox_Lang_English.IsEnabled = true;
            }
        }
    }

    private void CheckBox_Lang_English_OnIsCheckedChanged(object? sender, RoutedEventArgs e)
    {

        if (sender is CheckBox checkbox)
        {
            if (checkbox.IsChecked == true)
            {
                GLV.GLV_Language = "English";
                CheckBox_Lang_Persian.IsEnabled = false;
            }
            else
            {
                GLV.GLV_Language = "Persian";
                CheckBox_Lang_Persian.IsEnabled = true;
            }
        }
    }
}
