using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Aprofundado1.Models;

namespace XF_Aprofundado1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public Informacao Info { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Info = new Informacao
            {
                Titulo = "Título da informação",
                Descricao = "Descrição da informação"
            };
            BindingContext = Info;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaDetalhes.ItemsSource = new ObservableCollection<InformacaoDetalhe>(Info.Detalhes.Where(x => x.Selecionado));
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DetailPage(Info.Detalhes), true);
        }
    }
}