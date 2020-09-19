using AmazoneShowProduct.Models;
using AmazoneShowProduct.ViewModels;
using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmazoneShowProduct.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageVM();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            var selectedItem = MyCarousel.CurrentItem as ItemsViewModel;
            if (selectedItem == null) return;
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, selectedItem.Name);
            Navigation.PushAsync(new ProductDetailsPage(selectedItem));
           
        }
    }
}