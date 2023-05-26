namespace Real_Estate_App;

public partial class NewPage7 : ContentPage
{
	public NewPage7()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage9()); // I have used Navigation Stack, but this can be changed depending on what you want
    }

    private async void Button_Tapped_Twice(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new NewPage4()); 
    }
}