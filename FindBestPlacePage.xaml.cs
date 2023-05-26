namespace Real_Estate_App;

public partial class NewPage7 : ContentPage
{
	public NewPage7()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//TabBar/ProfilePage"); // this uses Shell navigation to also display tabbar and not use navigation Stack
    }

    private void Button_Tapped_Twice(object sender, TappedEventArgs e)
    {
        // I'm not sure where should this go
    }
}