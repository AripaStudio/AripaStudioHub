using System;
using System.Diagnostics;
using AripaStudioHub.Class;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace AripaStudioHub.Views;

public partial class MainView : UserControl
{
    

    

    public MainView()
    {
        InitializeComponent();

        Lbl_Content_SocialMedia.Content = TextEnSocialMediaPage[0];
    }
    public string[] BtnTextEnglish = ["Main Page", "Social Media Links", "Games AP", "SoftWare AP", "Setting" , "Coming Soon"];
    public string[] BtnTextPersian = ["صفحه اصلی ", "صفحه های مجازی", "بازی های آریپا", "نرم افزار های آریپا", "تنظیمات" , "به زودی"];
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
            Btn_Coming_Soon_Border.Content = BtnTextEnglish[5];
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
            Btn_Coming_Soon_Border.Content = BtnTextPersian[5];
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
            Btn_Coming_Soon_Border.Content = BtnTextEnglish[5];
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
        Border_Coming_Soon.IsVisible = false;
    }

    private void Btn_Social_Media_Links_page_border_OnClick(object? sender, RoutedEventArgs e)
    {
        Border_MainPage.IsVisible = false;
        Border_GamesAP.IsVisible = false;
        Border_SocialMediaLinks.IsVisible = true;
        Border_SoftWareAP.IsVisible = false;
        Border_Setting.IsVisible = false;
        Border_Coming_Soon.IsVisible = false;
    }

    private void Btn_Game_page_border_OnClick(object? sender, RoutedEventArgs e)
    {
        Border_MainPage.IsVisible = false;
        Border_GamesAP.IsVisible = true;
        Border_SocialMediaLinks.IsVisible = false;
        Border_SoftWareAP.IsVisible = false;
        Border_Setting.IsVisible = false;
        Border_Coming_Soon.IsVisible = false;
    }

    private void Btn_SoftWare_page_border_OnClick(object? sender, RoutedEventArgs e)
    {
        Border_MainPage.IsVisible = false;
        Border_GamesAP.IsVisible = false;
        Border_SocialMediaLinks.IsVisible = false;
        Border_SoftWareAP.IsVisible = true;
        Border_Setting.IsVisible = false;
        Border_Coming_Soon.IsVisible = false;
    }

    private void Btn_Setting_page_border_OnClick(object? sender, RoutedEventArgs e)
    {
        Border_MainPage.IsVisible = false;
        Border_GamesAP.IsVisible = false;
        Border_SocialMediaLinks.IsVisible = false;
        Border_SoftWareAP.IsVisible = false;
        Border_Setting.IsVisible = true;
        Border_Coming_Soon.IsVisible = false;
    }


    private void Btn_Coming_Soon_Border_OnClick(object? sender, RoutedEventArgs e)
    {
        Border_MainPage.IsVisible = false;
        Border_GamesAP.IsVisible = false;
        Border_SocialMediaLinks.IsVisible = false;
        Border_SoftWareAP.IsVisible = false;
        Border_Setting.IsVisible = false;
        Border_Coming_Soon.IsVisible = true;
        
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

    private async void Btn_MainPageTelegramLink_OnClick(object? sender, RoutedEventArgs e)
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
           await MessageBoxAP.MessageBoxShowOK("Error:" , Convert.ToString(exception), 320, 160);
        }
    }

    private async void BtnSocialMedia_Telegram_OnClick(object? sender, RoutedEventArgs e)
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
           await MessageBoxAP.MessageBoxShowOK("Error:", Convert.ToString(exception), 320, 160);
        }
    }

    private async void BtnSocialMedia_Github_OnClick(object? sender, RoutedEventArgs e)
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
            await MessageBoxAP.MessageBoxShowOK("Error:", Convert.ToString(exception), 320, 160);
        }
    }

    private async void BtnSocialMedia_Youtube_OnClick(object? sender, RoutedEventArgs e)
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
            await MessageBoxAP.MessageBoxShowOK("Error:", Convert.ToString(exception), 320, 160);
        }

    }



    //____________________________________________________________________
    //Games AP : 

    private async void Btn_GamesAP_EFR_OnClick(object? sender, RoutedEventArgs e)
    {
        Avalonia.Media.IImage linkImage;
        try
        {
            var uri = new Uri("avares://AripaStudioHub/Assets/GameAsoftware/EFR_Qab.png");
            linkImage = new Bitmap(AssetLoader.Open(uri));
        }
        catch (Exception ex)
        {

            linkImage = null;
            await MessageBoxAP.MessageBoxShowOK("Error", $"Error loading image: {ex.Message}", 320, 160);
        }


        string message ;
        if (GLV.GLV_Language == "Persian")
        {
            message = """
                      بازی فرار از واقعیت AP (EFR) یک بازی معمایی ، داستان و دارای فایت های ساده است 
                      یک بازی ساده و کوتاه است این بازی قسمت اول EFR است (EFR 1)
                      گیم پلی بازی : تقریبا 10 دقیقه
                      """;

        }else if (GLV.GLV_Language == "English")
        {
            message = """
                      The game Escape From Reality AP (EFR) is a puzzle, story-driven game with simple fights.  
                      It is a short and simple game. This is the first part of EFR (EFR 1).  
                      Gameplay duration: approximately 10 minutes.  
                      """;
        }
        else
        {
            message = """
                      The game Escape From Reality AP (EFR) is a puzzle, story-driven game with simple fights.  
                      It is a short and simple game. This is the first part of EFR (EFR 1).  
                      Gameplay duration: approximately 10 minutes.  
                      """;
        }


        await MessageBoxAP.ShowGameDialog("GamesAP", message, "Escape From Reality AP",
                "https://aripastudio.itch.io/escapefromrealityap", linkImage);

    }

    private async void Btn_GamesAP_JangeDayero_OnClick(object? sender, RoutedEventArgs e)
    {
       
            
            Avalonia.Media.IImage linkImage;
            try
            {
                var uri = new Uri("avares://AripaStudioHub/Assets/GameAsoftware/JangeDayero.jpg");
                linkImage = new Bitmap(AssetLoader.Open(uri));
            }
            catch (Exception ex)
            {
                
                linkImage = null; 
                await MessageBoxAP.MessageBoxShowOK("Error", $"Error loading image: {ex.Message}", 320, 160);
            }

            
            

            string message;
            if (GLV.GLV_Language == "Persian")
            {
                message = """
                          درود به همه ، بازی (Jange Dayero ) منتشر شد
                          سیستم عامل های پشتیبانی شده : Windows , linux , MacOS 
                          همین الان میتونید این بازی رو از لینک زیر دانلود کنید
                          """;

            }
            else if (GLV.GLV_Language == "English")
            {
                message = """
                          Hello everyone, the game "Jange Dayero" has been released.
                          Supported operating systems: Windows, Linux, MacOS
                          You can download the game now from the link below.
                          """; 
                          
            }
            else
            {
                message = """
                          Hello everyone, the game "Jange Dayero" has been released.
                          Supported operating systems: Windows, Linux, MacOS
                          You can download the game now from the link below.
                          """;
            }


            await MessageBoxAP.ShowGameDialog("GamesAP", message, "Jange Dayro AP",
                "https://aripastudio.itch.io/jange-dayeroap", linkImage);

    }

    //____________________________________________________________________
    //________________________________________________________________________________________________________________________________________
    //________________________________________________________________________________________________________________________________________
    //SoftWare page : 
    private async void Btn_SoftWareAP_MaterialColorAP_OnClick(object? sender, RoutedEventArgs e)
    {


        string message;
        if (GLV.GLV_Language == "Persian")
        {
            message = """
                      این یک نرم‌افزار متریال رنگ است که می‌توانید رنگ خود را انتخاب کنید و در برنامه امتحان کنید.
                      
                      این نرم‌افزار فقط برای ویندوز است. برای اطلاعات بیشتر و دانلود، روی دکمه دانلود کلیک کنید.
                      """;

        }
        else if (GLV.GLV_Language == "English")
        {
            message = """
                      This is a material color software where you can choose your color and test it in the program.
                      
                      This software is only for Windows. For more information and to download, click the Download button.
                      """;

        }
        else
        {
            message = """
                      This is a material color software where you can choose your color and test it in the program.
                      
                      This software is only for Windows. For more information and to download, click the Download button.
                      """;
        }

        await MessageBoxAP.ShowSoftWareSimpledialog("SoftwareAP", message, "MaterialColorAP", "https://t.me/AripaStudio/15");




    }

    private async void Btn_SoftWareAP_RandomWKap_OnClick(object? sender, RoutedEventArgs e)
    {

        string message;
        if (GLV.GLV_Language == "Persian")
        {
            message = """
                      این یک نرم‌افزار رندوم کار است که می‌توانید برای کارهای رندوم از آن استفاده کنید.
                      
                      این نرم‌افزار فقط برای ویندوز است. برای اطلاعات بیشتر و دانلود، روی دکمه دانلود کلیک کنید.
                      """;

        }
        else if (GLV.GLV_Language == "English")
        {
            message = """
                      This is a random task software that you can use for random tasks.
                      
                      This software is only for Windows. For more information and to download, click the Download button.
                      """;

        }
        else
        {
            message = """
                      This is a random task software that you can use for random tasks.
                      
                      This software is only for Windows. For more information and to download, click the Download button.
                      """;
        }

        await MessageBoxAP.ShowSoftWareSimpledialog("SoftwareAP", message, "RandomWKap", "https://t.me/AripaStudio/11");

    }

    private async void Btn_SoftWareAP_TodoListAP_OnClick(object? sender, RoutedEventArgs e)
    {
        string message;
        if (GLV.GLV_Language == "Persian")
        {
            message = """
                      این یک نرم‌افزار مدیریت وظایف است با قابلیت‌هایی مانند ذخیره تسک‌ها، مشخص کردن جزئیات، و غیره.
                      
                      این نرم‌افزار فقط برای ویندوز است. برای اطلاعات بیشتر و دانلود، روی دکمه دانلود کلیک کنید.
                      """;

        }
        else if (GLV.GLV_Language == "English")
        {
            message = """
                      This is a task management software with features such as saving tasks, specifying details, and more.
                      
                      This software is only for Windows. For more information and to download, click the Download button.
                      """;

        }
        else
        {
            message = """
                      This is a task management software with features such as saving tasks, specifying details, and more.
                      
                      This software is only for Windows. For more information and to download, click the Download button.
                      """;
        }

        await MessageBoxAP.ShowSoftWareSimpledialog("SoftwareAP", message, "TodoListAP", "https://t.me/AripaStudio/24");
    }

    private async void Btn_SoftWareAP_DNCaripaap_OnClick(object? sender, RoutedEventArgs e)
    {

        string message;
        if (GLV.GLV_Language == "Persian")
        {
            message = """
                      این یک نرم‌افزار کنسولی (نسخه گرافیکی DNCaripa 2.0.0، برای اطلاعات بیشتر کانال تلگرام ما را دنبال کنید) برای تغییر DNS در ویندوز است که می‌توانید DNS خود را تغییر دهید، ریست کنید، و DNS خود را ببینید، همراه با قابلیت‌های دیگر...
                      
                      این نرم‌افزار فقط برای ویندوز است. برای اطلاعات بیشتر و دانلود، روی دکمه دانلود کلیک کنید.
                      """;

        }
        else if (GLV.GLV_Language == "English")
        {
            message = """
                      This is a console application (graphical version DNCaripa 2.0.0, follow our Telegram channel for more information) for changing DNS in Windows, allowing you to change, reset, and view your DNS, along with other features...
                      
                      This software is only for Windows. For more information and to download, click the download button.
                      """;

        }
        else
        {
            message = """
                      This is a console application (graphical version DNCaripa 2.0.0, follow our Telegram channel for more information) for changing DNS in Windows, allowing you to change, reset, and view your DNS, along with other features...
                      
                      This software is only for Windows. For more information and to download, click the download button.
                      """;
        }

        await MessageBoxAP.ShowSoftWareSimpledialog("SoftwareAP", message, "DNCaripa", "https://github.com/AripaStudio/DNSchangerWindowsConsole/releases/");
    }

    //____________________________________________________________________
    //________________________________________________________________________________________________________________________________________
    //________________________________________________________________________________________________________________________________________


    private async void Btn_ComingSoon_Corner_of_Existence_OnClick(object? sender, RoutedEventArgs e)
    {
        string message;
        if (GLV.GLV_Language == "Persian")
        {
            message = """
                      یک بازی با سبک بقا و اکشن است 
                      در آینده ساخت آن شروع میشود و اطلاعات بیشتر منتشر میشود
                      """;
        } else if (GLV.GLV_Language == "English")
        {
            message = """
                      It is a survival and action style game. Its development will begin in the future, and more information will be released.
                      """;
        }
        else
        {
            message = """
                      It is a survival and action style game. Its development will begin in the future, and more information will be released.
                      """;
        }

        await MessageBoxAP.MessageBoxShowOK("Corner of Existence", message, 320, 160);
    }

    private async void Btn_ComingSoon_DNCaripa2_OnClick(object? sender, RoutedEventArgs e)
    {
        string message;
        if (GLV.GLV_Language == "Persian")
        {
            message = """
                      نسخه پیشرفته تر و گرافیکی نرم افزار (DNCaripa)
                      """;
        }
        else if (GLV.GLV_Language == "English")
        {
            message = """
                      A more advanced and graphical version of the software (DNCaripa)
                      """;
        }
        else
        {
            message = """
                      A more advanced and graphical version of the software (DNCaripa)
                      """;
        }

        await MessageBoxAP.MessageBoxShowOK("DNCaripa2 ", message, 320, 160);
    }

    private async void Btn_ComingSoon_VibeDriveAP_OnClick(object? sender, RoutedEventArgs e)
    {
        string message;
        if (GLV.GLV_Language == "Persian")
        {
            message = """
                      یک نرم افزار مدیریت و نظم دهی به فایل ها است
                      """;
        }
        else if (GLV.GLV_Language == "English")
        {
            message = """
                      It is a software for managing and organizing files.
                      """;
        }
        else
        {
            message = """
                      It is a software for managing and organizing files.
                      """;
        }

        await MessageBoxAP.MessageBoxShowOK("VibeDrive ", message , 320 , 160);
    }


    private async void BTN_aboutBoxGPLv3_OnClick(object? sender, RoutedEventArgs e)
    {
        string message =
            "Aripa Studio Hub\nCopyright (C) 2025 Khashayar Mobasheri (AripaStudio)\n\nThis program comes with ABSOLUTELY NO WARRANTY.\n\nThis is free software, and you are welcome to redistribute it under the terms of the GNU General Public License version 3.\n\nA copy of the GPLv3 license is distributed with this software.";
        await MessageBoxAP.MessageBoxShowOK("GPLv3" ,message , 400 , 400);
    }
}

