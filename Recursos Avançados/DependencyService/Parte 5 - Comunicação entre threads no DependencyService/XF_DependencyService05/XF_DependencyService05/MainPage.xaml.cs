using System;
using Xamarin.Forms;
using XF_DependencyService05.Interface;

namespace XF_DependencyService05
{
    public partial class MainPage : ContentPage
    {
        public IContadorLetras ContadorLetras { get; }

        public MainPage()
        {
            InitializeComponent();
            ContadorLetras = DependencyService.Get<IContadorLetras>();
            ContadorLetras.Navigation = Navigation;
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var retorno = await ContadorLetras.Contar(Entry.Text);
            if (retorno != null)
                await DisplayAlert("Atenção", $"Consoantes: {retorno.Consoantes}{Environment.NewLine}Vogais: {retorno.Vogais}{Environment.NewLine}Espaços: {retorno.Espacos}", "OK");
        }
    }
}
