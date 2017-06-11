using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_ListViewAdv4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var listaDeElementos = new List<Model>();

            for (var i = 0; i < 30; i++)
            {
                listaDeElementos.Add(new Model
                {
                    Texto1 = $"Texto1_{i+1}",
                    Texto2 = $"Botão2_{i+1}",
                    Texto3 = $"Texto3_{i+1}",
                    Texto4 = $"Botão4_{i+1}"
                });
            }

            ListView.ItemsSource = new ObservableCollection<Model>(listaDeElementos);
            
        }
    }
}
