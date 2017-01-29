using System;
using Xamarin.Forms;

namespace XF_DeviceOnPlatform1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonExecutarAcao_OnClicked(object sender, EventArgs e)
        {
            var result = string.Empty;
            Action acaoIos = () => result = "Método rodou no iOS";
            Action acaoAndroid = () => result = "Método rodou no Android";
            Action acaoPadrao = () => result = "Método padrão";
            Device.OnPlatform(acaoIos, acaoAndroid, null, acaoPadrao);
            await DisplayAlert("Atenção", result, "OK");
        }

        private async void ButtonRetornarValor_OnClicked(object sender, EventArgs e)
        {
            var result = Device.OnPlatform(
                "String retornado no iOS",
                "String retornado no Android",
                "String retornado no WinPhone");
            await DisplayAlert("Atenção", result, "OK");
        }
    }
}
