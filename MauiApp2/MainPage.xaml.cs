namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            //DateLabel.Date = DateTime.Now; // Use "D" for long date format
        }
        private async void ToReportPageClicked(object sender, EventArgs e)
        {
            // Navigate to SecondPage
            await Navigation.PushAsync(new ReportPage());
        }
        

       
    }

}
