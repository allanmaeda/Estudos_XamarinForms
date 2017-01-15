using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace XF_ListView9
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var lista = new List<Model>();
            string [] grupos = {"Primeiro", "Segundo", "Terceiro", "Quarto", "Quinto"};
            
            foreach (var c in grupos)
            {
                for (var j = 1; j <= 30; j++)
                {
                    var m = new Model(c, $"Info {j}");
                    lista.Add(m);
                }
            }

            var listaAgrupada = lista
                .GroupBy(x => x.Grupo)
                .Select(x => new Agrupamento<string, Model>(x.Key, x.Select(y => y)));
            
            MyListView.ItemsSource = new ObservableCollection<Agrupamento<string, Model>>(listaAgrupada);
        }
    }
}
