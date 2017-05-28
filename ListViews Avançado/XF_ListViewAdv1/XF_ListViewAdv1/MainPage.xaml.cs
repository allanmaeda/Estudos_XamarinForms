using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XF_ListViewAdv1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var listaDeElementos = new List<Model>();

            for (var i = 0; i < 10; i++)
            {
                listaDeElementos.Add(new Model
                {
                    Texto = $"texto{i+1}",
                    Detalhe = $"imagem{i+1}",
                    Imagem = "imagem"
                });   
            }

            ListViewTexto.ItemsSource = new ObservableCollection<Model>(listaDeElementos);
            ListViewImagem.ItemsSource = new ObservableCollection<Model>(listaDeElementos);
        }
    }
}
