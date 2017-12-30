using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XF_ListView5
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Model> ListaItens { get; }

        public MainPage()
        {
            InitializeComponent();
            ListaItens = new ObservableCollection<Model>();
            MyListView.ItemsSource = ListaItens;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            ListaItens.Add(new Model
            {
                Elemento = "Novo elemento"
            });
        }
    }
}
