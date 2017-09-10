using System;
using Xamarin.Forms;

namespace XF_MessagingCenter1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void EnviarMensagem_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "msg");
        }

        private void ReceberMensagem_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<MainPage>(this, "msg", async page =>
            {
                await DisplayAlert("Atenção", "mensagem recebida", "Ok");
            });
        }
    }
}
