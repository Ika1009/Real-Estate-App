namespace Real_Estate_App;

public partial class NewPage5 : ContentPage
{
	public NewPage5()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage7()); // I have used Navigation Stack, but this can be changed depending on what you want
    }
}