
using LaosApp.Views.MainView;

namespace LaosApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainUserPage();
        }
    }
}
