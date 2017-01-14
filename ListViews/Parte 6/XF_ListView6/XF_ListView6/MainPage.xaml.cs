using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_ListView6
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Model> ListaItens { get; }

        public MainPage()
        {
            InitializeComponent();
            ListaItens = new ObservableCollection<Model>();
            MyListView.ItemsSource = ListaItens;
        }

        private async void MyListView_OnRefreshing(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                ListaItens.Insert(0, new Model { Conteudo = "Novo elemento"});
            });

            MyListView.EndRefresh();
        }
    }
}
