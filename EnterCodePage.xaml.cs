namespace Real_Estate_App;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

    private async void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        // checking if all three has been inputed
        if(!string.IsNullOrEmpty(entryCode1.Text) && !string.IsNullOrEmpty(entryCode2.Text) && !string.IsNullOrEmpty(entryCode3.Text))
        {
            //Here is the code for validation
            await Navigation.PushAsync(new NewPage5());
        }
    }
}