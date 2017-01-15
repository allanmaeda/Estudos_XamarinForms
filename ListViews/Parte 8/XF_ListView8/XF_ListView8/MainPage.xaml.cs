using System.Collections.Generic;
using Xamarin.Forms;

namespace XF_ListView8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var list = new List<Model>();

            for (var i = 1; i<= 20 ; i++)
                list.Add(new Model { Informacao = $"Item {i:D2}" });

            MyListView.ItemsSource = list;
        }

        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MyListView.SelectedItem = null;
        }
    }
}
