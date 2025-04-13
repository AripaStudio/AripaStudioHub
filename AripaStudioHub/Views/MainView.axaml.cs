using System;
using System.Diagnostics;
using AripaStudioHub.Class;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AripaStudioHub.Views;

public partial class MainView : UserControl
{
    

    

    public MainView()
    {
        InitializeComponent();

        Lbl_Content_SocialMedia.Content = TextEnSocialMediaPage[0];
    }
    public string[] BtnTextEnglish = ["Main Page", "Social Media Links", "Games AP", "SoftWare AP", "Setting"];
    public string[] BtnTextPersian = ["صفحه اصلی ", "صفحه های مجازی", "بازی های آریپا", "نرم افزار های آریپا", "تنظیمات"];
    //Main page:
    public string[] BtnTextEnMainPage = ["For more information about our software & games, follow us on Telegram (click to follow)."];
    public string[] BtnTextPeMainPage = ["برای اطلاعات بیشتر از نرم افزار  و بازی  های ما، در تلگرام ما را دنبال کنید (برای دنبال کردن کلیک کنید)."];
    //
    public string[] TextEnSocialMediaPage = [("For information about upcoming versions of the software, be sure to follow us on Telegram and " + Environment.NewLine +
                                              "the software's GitHub page to stay updated on the latest releases." + Environment.NewLine +
                                              "For studio news, follow us on Telegram." + Environment.NewLine +
                                              "To watch videos of our games and software, follow us on YouTube.")
        , "Youtube" , "GitHub" , "Telegram"];



    public string[] TextPeSocialMediaPage = [("برای اطلاعات از نسخه بعدی نرم افزار حتما ما را در تلگرام و صفحه گیت  این نرم افزار  دنبال کنید" + Environment.NewLine +
                                              "تا از آخرین نسخه  منتشر شده باخبر شوید." + Environment.NewLine +
                                              "برای اخبار استودیو، ما را در تلگرام دنبال کنید." + Environment.NewLine +
                                              "برای دیدن ویدیوهای بازی  و نرم  ما، ما را در یوتیوب دنبال کنید.")
        , "یوتیوب" , "گیت هاب" , "تلگرام"];
    void Lang()
    { 
       



        if (GLV.GLV_Language == "English")
        {
            Btn_main_page_border.Content = BtnTextEnglish[0];
            Btn_Social_Media_Links_page_border.Content = BtnTextEnglish[1];
            Btn_Game_page_border.Content = BtnTextEnglish[2];
            Btn_SoftWare_page_border.Content = BtnTextEnglish[3];
            Btn_Setting_page_border.Content = BtnTextEnglish[4];
            //button main page
            Btn_MainPageTelegramLink.Content = BtnTextEnMainPage[0];
            // SocialMedia Content 
            Lbl_Content_SocialMedia.Content = TextEnSocialMediaPage[0];
            BtnSocialMedia_Youtube.Content = TextEnSocialMediaPage[1];
            BtnSocialMedia_Github.Content = TextEnSocialMediaPage[2];
            BtnSocialMedia_Telegram.Content = TextEnSocialMediaPage[3];


        }
        else if (GLV.GLV_Language == "Persian")
        {
            
            Btn_main_page_border.Content = BtnTextPersian[0];
            Btn_Social_Media_Links_page_border.Content = BtnTextPersian[1];
            Btn_Game_page_border.Content = BtnTextPersian[2];
            Btn_SoftWare_page_border.Content = BtnTextPersian[3];
            Btn_Setting_page_border.Content = BtnTextPersian[4];
            //button main page
            Btn_MainPageTelegramLink.Content = BtnTextPeMainPage[0];
            // SocialMedia Content
            Lbl_Content_SocialMedia.Content = TextPeSocialMediaPage[0];
            BtnSocialMedia_Youtube.Content = TextPeSocialMediaPage[1];
            BtnSocialMedia_Github.Content = TextPeSocialMediaPage[2];
            BtnSocialMedia_Telegram.Content = TextPeSocialMediaPage[3];

        }
        else
        {
            
            Btn_main_page_border.Content = BtnTextEnglish[0];
            Btn_Social_Media_Links_page_border.Content = BtnTextEnglish[1];
            Btn_Game_page_border.Content = BtnTextEnglish[2];
            Btn_SoftWare_page_border.Content = BtnTextEnglish[3];
            Btn_Setting_page_border.Content = BtnTextEnglish[4];
            //button main page
            Btn_MainPageTelegramLink.Content = BtnTextEnMainPage[0];
            // SocialMedia Content
            Lbl_Content_SocialMedia.Content = TextEnSocialMediaPage[0];
            BtnSocialMedia_Youtube.Content = TextEnSocialMediaPage[1];
            BtnSocialMedia_Github.Content = TextEnSocialMediaPage[2];
            BtnSocialMedia_Telegram.Content = TextEnSocialMediaPage[3];
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
        Lang();
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
        Lang();
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

    private void Btn_MainPageTelegramLink_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://t.me/AripaStudio";
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        catch (Exception exception)
        {
           MessageBoxAP.MessageBoxShowOK("Error:" , Convert.ToString(exception));
            throw;
        }
    }

    private void BtnSocialMedia_Telegram_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://t.me/AripaStudio";
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        catch (Exception exception)
        {
            MessageBoxAP.MessageBoxShowOK("Error:", Convert.ToString(exception));
            throw;
        }
    }

    private void BtnSocialMedia_Github_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://github.com/AripaStudio";
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        catch (Exception exception)
        {
            MessageBoxAP.MessageBoxShowOK("Error:", Convert.ToString(exception));
            throw;
        }
    }

    private void BtnSocialMedia_Youtube_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://www.youtube.com/@AripaStudio";
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        catch (Exception exception)
        {
            MessageBoxAP.MessageBoxShowOK("Error:", Convert.ToString(exception));
            throw;
        }

    }
}

