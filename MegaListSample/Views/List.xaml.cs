using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MegaListSample.Views
{
    public partial class List : ContentPage
    {
        public ObservableCollection<string> items = new ObservableCollection<string>();

        public List()
        {
            InitializeComponent();

            for(int i = 1; i <= 10000; i++)
            {
                var skip = (i % 26) + 65;
                items.Add(Convert.ToChar(skip).ToString());
            }
        }

        protected override void OnAppearing()
        {
            MegaListView.ItemsSource = items;

            base.OnAppearing();
        }
    }
}
