using System;
using Xamarin.Forms;

namespace XF_MessagingCenter2
{
    public partial class MainPage : ContentPage
    {
        public DateTime DataDeEnvioDaMensagem { get; private set; }

        public MainPage()
        {
            InitializeComponent();
        }

        private void EnviarMensagem_Clicked(object sender, EventArgs e)
        {
            DataDeEnvioDaMensagem = DateTime.Now;
            MessagingCenter.Send(this, "msg");
        }

        private void ReceberMensagem_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<MainPage>(this, "msg", async page =>
            {
                await DisplayAlert("Atenção", $"mensagem recebida às {page.DataDeEnvioDaMensagem:HH:mm:ss}", "Ok");
            });
        }
    }
}
