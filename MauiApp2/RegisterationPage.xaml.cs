namespace MauiApp2;

public partial class RegisterationPage : ContentPage
{
	public RegisterationPage()
	{
		InitializeComponent();
	}

	private async void Register(object sender, EventArgs e)
	{
		
        await Navigation.PushAsync(new Login());

    }
}