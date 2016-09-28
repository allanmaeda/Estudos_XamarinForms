using System;
using Xamarin.Forms;

namespace XF_ComunicacaoModalsBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var modelo = new Modelo
            {
                InformacaoPrimaria = Info1.Text,
                InformacaoSecundaria = Info2.Text
            };

            var modalPage = new ModalPage
            {
                BindingContext = modelo
            };

            await Navigation.PushModalAsync(modalPage);
        }
    }
}
