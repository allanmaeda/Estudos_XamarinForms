using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace XF_ListView10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var lista = new List<Model>();
            string[] grupos = { "Primeiro", "Segundo", "Terceiro", "Quarto", "Quinto" };

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

        private void MyListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            // recuperando a celula selecionada
            var celulaSelecionada = e.Item as Model;

            // recuperando o grupo selecionado
            var grupoSelecionado = (ITemplatedItemsList<Cell>) e.Group;

            // recuperando o nome do grupo selecionado
            var nomeDoGrupoSelecionado = grupoSelecionado.Name;

            // recuperando a lista de itens do grupo selecionado
            var listaDeItemsDoGrupo = grupoSelecionado.ItemsSource as Agrupamento<string, Model>;
        }
    }
}
