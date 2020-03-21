using HealthMonitor.MasterPage;
using HealthMonitor.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HealthMonitor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Login = new Login();
            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new HMDS());
            //MainPage = new NavigationPage(new Workflow());
            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
