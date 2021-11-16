using Horadagua.Paginas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horadagua
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuPage());
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
