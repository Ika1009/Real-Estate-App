namespace Real_Estate_App;

public partial class NewPage6 : ContentPage
{
	public NewPage6()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new NewPage8()); // I have used Navigation Stack, but this can be changed depending on what you want
    }
}