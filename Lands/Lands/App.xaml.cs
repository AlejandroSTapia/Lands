using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lands.Views;

namespace Lands
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //para poder apilar filas en el futuro, con esto podemos colocar una propiedad para el titulo
            //desde COntenpage en LoginPage.xaml
            MainPage = new NavigationPage( new LoginPage());
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
