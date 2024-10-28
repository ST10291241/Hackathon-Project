namespace MauiApp2;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
	private async void OnLoginButtonClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new MainPage());
    }
    private async void ToRegisterPageClicked(object sender, EventArgs e)
    {
        // Navigate to SecondPage
        await Navigation.PushAsync(new RegisterationPage());
    }
}