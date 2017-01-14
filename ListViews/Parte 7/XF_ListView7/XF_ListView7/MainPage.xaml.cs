using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace XF_ListView7
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Model> Lista { get; }
        private int _i;

        public MainPage()
        {
            InitializeComponent();
            Lista = new ObservableCollection<Model>();
            MyListView.ItemsSource = Lista;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Lista.Insert(0, new Model($"principal {++_i}", $"secundaria {_i}"));
        }

        private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var itemSelecionado1 = (Model) e.SelectedItem;
            var itemSelecionado2 = (Model) MyListView.SelectedItem;

            // item vindo pelo SelectedItemChangedEventArgs
            Debug.WriteLine($"Hora: {itemSelecionado1.Hora}");
            Debug.WriteLine($"Info1: {itemSelecionado1.InformacaoPrincipal}");
            Debug.WriteLine($"Info2: {itemSelecionado1.InformacaoSecundaria}");
            Debug.WriteLine("------");

            // item vindo da listview
            Debug.WriteLine($"Hora: {itemSelecionado2.Hora}");
            Debug.WriteLine($"Info1: {itemSelecionado2.InformacaoPrincipal}");
            Debug.WriteLine($"Info2: {itemSelecionado2.InformacaoSecundaria}");
            Debug.WriteLine("------");
        }
    }
}
