using System.Data;
using DataTables.AspNet;


namespace MauiApp2;

public partial class ReportPage : ContentPage
{
	public ReportPage()
	{
		InitializeComponent();
    }

	private void ProcessReport(object sender, EventArgs e)
	{
		
	}

	private async void BackToWelcomePage(object sender, EventArgs e) {

        await Navigation.PopAsync();

    }

	private void NotifyAllAuthorities(object sender,EventArgs e)
	{
		
	}
}