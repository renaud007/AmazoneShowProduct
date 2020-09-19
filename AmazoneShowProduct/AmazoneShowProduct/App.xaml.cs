using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AmazoneShowProduct.Views;
using Plugin.SharedTransitions;

namespace AmazoneShowProduct
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

           
            MainPage = new SharedTransitionNavigationPage(new MainPage());
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
