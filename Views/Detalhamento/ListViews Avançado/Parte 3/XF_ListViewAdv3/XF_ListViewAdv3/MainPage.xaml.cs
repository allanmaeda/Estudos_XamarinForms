using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_ListViewAdv3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var lista = new List<Model>();

            for (var i = 0; i < 20; i++)
            {
                lista.Add(new Model
                {
                    Info1 = $"Primeira info {i+1}",
                    Info2 = $"Segunda info {i+1}",
                    Info3 = $"Terceira info {i+1}",
                    Info4 = $"Quarta info {i+1}"
                });    
            }

            ListView.ItemsSource = new ObservableCollection<Model>(lista);
        }
    }
}
