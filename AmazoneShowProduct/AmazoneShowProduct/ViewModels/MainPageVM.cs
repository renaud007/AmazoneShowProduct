using AmazoneShowProduct.Models;
using AmazoneShowProduct.Services;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AmazoneShowProduct.ViewModels
{
   public class MainPageVM : BaseViewModel
    {
        public ObservableRangeCollection<Category> Categories { get; set; }

        public ObservableRangeCollection<ItemsViewModel> Items { get; set; }

        public Category SelectedCategory { get; set; }

        public ICommand ItemSelected { get; set; }

        public ICommand CategorySelectionChanged { get; set; }
        public MainPageVM()
        {
            ItemSelected = new Command<ItemsViewModel>(ItemSelectedExecute);

            Categories = new ObservableRangeCollection<Category>();
            Categories.AddRange(DataStore.GetCategories());
            CategorySelectionChanged = new Command(DoThing);

            var items = DataStore.GetItemsForCategory(SelectedCategory);

            Items = new ObservableRangeCollection<ItemsViewModel>();
            foreach (var item in items)
            {
                Items.Add(new ItemsViewModel(item));
            }

        }

        private void ItemSelectedExecute(ItemsViewModel obj)
        {

        }

        private void DoThing(object obj)
        {
            Items.Clear();
            var items = DataStore.GetItemsForCategory(obj.ToString());

            foreach (var item in items)
            {
                Items.Add(new ItemsViewModel(item));
            }

        }
    }
}
