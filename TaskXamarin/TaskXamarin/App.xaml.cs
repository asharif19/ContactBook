using System;
using TaskXamarin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactsPage());
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
