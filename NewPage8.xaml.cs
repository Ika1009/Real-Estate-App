namespace Real_Estate_App;

public partial class NewPage8 : ContentPage
{
	public NewPage8()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync(); // I have used Navigation Stack, but this can be changed depending on what you want
    }
}