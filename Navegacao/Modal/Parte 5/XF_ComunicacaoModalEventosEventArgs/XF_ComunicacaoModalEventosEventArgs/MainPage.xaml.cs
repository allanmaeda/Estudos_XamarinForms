using System;
using Xamarin.Forms;

namespace XF_ComunicacaoModalEventosEventArgs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            // criando a modal page
            var modalPage = new ModalPage();

            // anexando uma funcao para quando a modalpage for fechada
            modalPage.ModalHandler += (o, args) =>
            {
                Entry1.Text = (string) o;
                Entry2.Text = args.Data;
                Entry3.Text = args.Hora;
            };

            await Navigation.PushModalAsync(modalPage, true);
        }
    }
}
