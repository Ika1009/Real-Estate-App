namespace Real_Estate_App;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new NewPage2()); // I have used Navigation Stack, but this can be changed depending on what you want
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // I have used Navigation Stack, but this can be changed depending on what you want
    }
    // red - RGB (249, 90, 90)
    private void ChangeToRedBorder1() { border1.Stroke = Color.FromRgb(249, 90, 90); }
    private void ChangeToRedBorder2() { border2.Stroke = Color.FromRgb(249, 90, 90); }
    private void ChangeToNormalBorder1() { border1.Stroke = Colors.Transparent; }
    private void ChangeToNormalBorder2() { border2.Stroke = Colors.Transparent; }
}