using Microsoft.Maui.Controls;

namespace MauiApp2
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            // Set the MainPage using the service provider
            MainPage = serviceProvider.GetService<MainPage>();
        }
    }



}
