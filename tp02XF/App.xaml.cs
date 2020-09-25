using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tp02XF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            //Page_EstiloPadrão = new NavigationPage(new Page_EstiloPadrão());
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
