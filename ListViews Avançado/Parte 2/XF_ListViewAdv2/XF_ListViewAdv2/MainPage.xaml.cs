using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XF_ListViewAdv2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var lista = new List<Model>();

            for (var i = 0; i < 30; i++)
            {
                lista.Add(new Model
                {
                    InfoEsq = $"InfoEsq{i+1}",
                    InfoDir = $"InfoDir{i+1}"
                });        
            }

            ListView.ItemsSource = new ObservableCollection<Model>(lista);
        }
    }
}
