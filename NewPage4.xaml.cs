namespace Real_Estate_App;

public partial class NewPage4 : ContentPage
{
	public NewPage4()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new NewPage3()); // I have used Navigation Stack, but this can be changed depending on what you want
    }
}