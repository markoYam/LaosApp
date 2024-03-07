namespace LaosApp.Views;

public partial class GeneralPage : ContentPage
{
	public GeneralPage()
	{
		InitializeComponent();
	}

    private void btn1_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }

    private void btn2_Clicked(object sender, EventArgs e)
    {

    }
}