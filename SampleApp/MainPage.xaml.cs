namespace SampleApp
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void NavigateToTabbedPage(object sender, EventArgs e)
		{
			Navigation.PushAsync(new MyTabbedPage());
		}
	}
}