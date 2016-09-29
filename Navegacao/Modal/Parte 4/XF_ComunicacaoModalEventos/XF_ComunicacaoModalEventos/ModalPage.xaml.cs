using System;
using Xamarin.Forms;

namespace XF_ComunicacaoModalEventos
{
    public partial class ModalPage : ContentPage
    {
        // criando event handler para amarrar funções externas
        public EventHandler ModalHandler { get; set; }

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