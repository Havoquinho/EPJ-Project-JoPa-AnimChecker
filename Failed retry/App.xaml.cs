using Failed_retry.Services;
using Failed_retry.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Failed_retry
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
