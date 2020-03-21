using HealthMonitor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HealthMonitor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnLoginClick(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Login());


        }
        private async void OnSignUpClick(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SignUp());
        }
    }
}
