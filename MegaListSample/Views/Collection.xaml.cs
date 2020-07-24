using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MegaListSample.Views
{
    public partial class Collection : ContentPage
    {
        public ObservableCollection<string> items = new ObservableCollection<string>();

        public Collection()
        {
            InitializeComponent();

            for (int i = 1; i <= 10000; i++)
            {
                var skip = (i % 26) + 65;
                items.Add(Convert.ToChar(skip).ToString());
            }
        }

        protected override void OnAppearing()
        {
            MegaCollectionView.ItemsSource = items;

            base.OnAppearing();
        }
    }
}
