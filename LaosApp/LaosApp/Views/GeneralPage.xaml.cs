using LaosApp.Views.OrderView;

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

    private void register_Clicked(object sender, TouchEventArgs e)
    {
        Navigation.PushAsync(new RegisterView.RegisterPage());
    }

    private void order_Clicked(object sender, TouchEventArgs e)
    {
        Navigation.PushAsync(new OrderView.OrderPage());
    }

    private void products_Clicked(object sender, TouchEventArgs e)
    {
        Navigation.PushAsync(new ProductosView.ProductsPage());
    }

    private void login_Clicked(object sender, TouchEventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }
}