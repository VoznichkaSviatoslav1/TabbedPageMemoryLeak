namespace SampleApp;

public partial class MyTabbedPage : TabbedPage
{
	public MyTabbedPage()
	{
		InitializeComponent();

		Console.WriteLine("Constructor was called");
	}

	~MyTabbedPage()
	{
		Console.WriteLine("Destructor was called");
	}

	private void NavigateBackToMainPage(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}