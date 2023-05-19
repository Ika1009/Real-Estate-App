using Microsoft.Maui.Platform;
using Real_Estate_App.Customs;

namespace Real_Estate_App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
		{
#if __ANDROID__
			handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
			handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
			handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
		});

        Microsoft.Maui.Handlers.SearchBarHandler.Mapper.AppendToMapping(nameof(LinelessSearch), (handler, view) =>
        {
#if __ANDROID__
			Android.Widget.LinearLayout linearLayout =  handler.PlatformView.GetChildAt(0) as Android.Widget.LinearLayout;  
            linearLayout = linearLayout.GetChildAt(2) as Android.Widget.LinearLayout;  
            linearLayout = linearLayout.GetChildAt(1) as Android.Widget.LinearLayout;  
            linearLayout.Background = null; 
#elif __IOS__
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
#endif
        });
    }
}
