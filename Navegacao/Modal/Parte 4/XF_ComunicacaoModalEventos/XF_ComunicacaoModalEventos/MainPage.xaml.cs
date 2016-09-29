using System;
using Xamarin.Forms;

namespace XF_ComunicacaoModalEventos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            // criando a modalPage e amarrando um método ao ModalHandler
            var modalPage = new ModalPage
            {
                ModalHandler = (o, args) =>
                {
                    Entry.Text = (string)o;
                }
            };

            await Navigation.PushModalAsync(modalPage, true);
        }
    }
}
