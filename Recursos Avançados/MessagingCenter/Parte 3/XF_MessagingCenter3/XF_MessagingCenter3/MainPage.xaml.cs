using System;
using Xamarin.Forms;

namespace XF_MessagingCenter3
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
                await DisplayAlert("Atenção!", "Mensagem recebida", "Ok");
            });
        }

        private void IgnorarMensagem_Click(object sender, EventArgs e)
        {
            MessagingCenter.Unsubscribe<MainPage>(this, "msg");
        }
    }
}
