using AmazoneShowProduct.Models;
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
    public partial class ProductDetailsPage : ContentPage
    {
        public ProductDetailsPage(ItemsViewModel selectedItem)
        {
            InitializeComponent();
            this.BindingContext = selectedItem;
        }
    }
}