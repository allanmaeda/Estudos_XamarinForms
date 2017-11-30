using System;
using Xamarin.Forms;

namespace XF_DependencyService02
{
    public partial class MainPage : ContentPage
    {
        public IGerenciadorArquivos GerenciadorArquivos { get; }

        public MainPage()
        {
            InitializeComponent();
            GerenciadorArquivos = DependencyService.Get<IGerenciadorArquivos>();
        }

        private async void ButtonCarregarArquivo_OnClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Entry.Text))
            {
                await DisplayAlert("Atenção", "Você precisa digitar o nome do arquivo!", "OK");
                return;
            }

            try
            {
                Editor.Text = await GerenciadorArquivos.CarregarArquivo(Entry.Text);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Atenção", "Houve um erro no carregamento do arquivo!", "OK");
            }
        }

        private async void ButtonSalvarArquivo_OnClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Entry.Text))
            {
                await DisplayAlert("Atenção", "Você precisa digitar o nome do arquivo!", "OK");
                return;
            }

            try
            {
                await GerenciadorArquivos.SalvarArquivo(Entry.Text, Editor.Text);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Atenção", "Houve um erro no salvamento do arquivo!", "OK");
            }
        }
    }
}
