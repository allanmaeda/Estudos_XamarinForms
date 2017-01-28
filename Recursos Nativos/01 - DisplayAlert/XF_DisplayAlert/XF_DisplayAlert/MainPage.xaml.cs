using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_DisplayAlert
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_DisplayAlertSimples(object sender, EventArgs e)
        {
            await DisplayAlert("Título", "Mensagem do alerta", "OK");
        }

        private async void Button_DisplayAlertComplexo(object sender, EventArgs e)
        {
            var resultado = await DisplayAlert("Título", "Mensagem do alerta", "Botão OK", "Botão não OK");
            Label.Text = resultado ? "Botão OK clicado" : "Botão não OK clicado";
            await Task.Delay(500);
            Label.Text = "";
        }
    }
}
