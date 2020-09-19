using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmazoneShowProduct.ContentViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TitleBar : ContentView
    {
        public TitleBar()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}