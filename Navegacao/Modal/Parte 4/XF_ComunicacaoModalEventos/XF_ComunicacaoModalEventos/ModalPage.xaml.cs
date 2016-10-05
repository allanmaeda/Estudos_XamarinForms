using System;
using Xamarin.Forms;

namespace XF_ComunicacaoModalEventos
{
    public partial class ModalPage : ContentPage
    {
        // criando event handler para amarrar funções externas
        public event EventHandler ModalHandler;

        public ModalPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            // se o event handler tiver alguma função, chame-a
            ModalHandler?.Invoke(Entry.Text, EventArgs.Empty);
            await Navigation.PopModalAsync(true);
        }
    }
}