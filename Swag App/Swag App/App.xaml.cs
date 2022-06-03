using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swag_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            bindingContext = swagProperties;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
