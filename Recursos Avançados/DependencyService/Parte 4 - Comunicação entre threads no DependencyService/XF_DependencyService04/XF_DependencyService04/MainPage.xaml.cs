using System;
using Xamarin.Forms;
using XF_DependencyService04.Implementação;
using XF_DependencyService04.Interface;

namespace XF_DependencyService04
{
    public partial class MainPage : ContentPage
    {
        public IContadorLetras ContadorLetras { get; }

        public MainPage()
        {
            InitializeComponent();
            ContadorLetras = DependencyService.Get<IContadorLetras>();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var result = ContadorLetras.Contar(Entry.Text);

            ContadorLetras.ContarVogais = await DisplayAlert("Atenção", "Contar vogais?", "Sim", "Não");
            ContadorLetras.ContarEspacos = await DisplayAlert("Atenção", "Contar espaços?", "Sim", "Não");
            ContadorLetras.ContarConsonantes = await DisplayAlert("Atenção", "Contar consoantes?", "Sim", "Não");

            if (!await DisplayAlert("Atenção", "Deseja mesmo continuar?", "Sim", "Não"))
                return;

            ContadorLetras.Comecar();
            var retorno = result.Result;

            if (retorno == null)
                await DisplayAlert("Atenção", "Parece que o texto está vazio...", "OK");
            else
                await DisplayAlert("Atenção", $"Consoantes: {retorno.Consoantes}{Environment.NewLine}Vogais: {retorno.Vogais}{Environment.NewLine}Espaços: {retorno.Espacos}", "OK");
        }
    }
}
