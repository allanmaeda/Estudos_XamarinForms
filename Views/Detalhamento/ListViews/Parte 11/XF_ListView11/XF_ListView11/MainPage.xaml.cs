using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_ListView11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MyListView.ItemsSource = new List<string>
            {
                "item 1",
                "item 2",
                "item 3",
                "item 4",
                "item 5",
                "item 6",
                "item 7",
                "item 8",
                "item 9",
                "item 10",
                "item 11",
                "item 12",
                "item 13",
                "item 14",
                "item 15"
            };
        }

        private async void MyListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            lblTocado.TextColor = Color.Orange;
            await Task.Delay(250);
            lblTocado.TextColor = Color.Black;
        }

        private async void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            lblSelecionado.TextColor = Color.Orange;
            await Task.Delay(250);
            lblSelecionado.TextColor = Color.Black;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            MyListView.SelectedItem = null;
        }
    }
}
