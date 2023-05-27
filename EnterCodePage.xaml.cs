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
        // after inputing each entry, the next gets enabled and gets a border to indicate that it is enabled
        if(!string.IsNullOrEmpty(entryCode0.Text))
        {
            borderCode0.StrokeThickness = 0;
            entryCode1.IsEnabled = true;
            borderCode1.StrokeThickness = 3;

            if(!string.IsNullOrEmpty(entryCode1.Text))
            {
                borderCode1.StrokeThickness = 0;
                entryCode2.IsEnabled = true;
                borderCode2.StrokeThickness = 3;

                if(!string.IsNullOrEmpty(entryCode2.Text))
                {
                    borderCode2.StrokeThickness = 0;
                    entryCode3.IsEnabled = true;
                    borderCode3.StrokeThickness = 3;
                    if (!string.IsNullOrEmpty(entryCode3.Text))
                    {
                        borderCode3.StrokeThickness = 0;

                        //Here should be the code for validation when all four are inputed

                        await Navigation.PushAsync(new NewPage5());
                    }
                }
            }

        }
    }
}