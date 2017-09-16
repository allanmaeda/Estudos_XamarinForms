using System;
using Xamarin.Forms;

namespace XF_MessagingCenter4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
        }

        private void EnviarMensagem_Clicked(object sender, EventArgs e)
        {
            var r = new Random();
            var model = new Model
            {
                Texto = $"texto teste com número ateatório {r.Next(1, 101)}"
            };
            MessagingCenter.Send(model, "msg");
        }

        private void ReceberMensagem_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<Model>(this, "msg", async model =>
            {
                await DisplayAlert("Atenção!", model.Texto, "Ok");
            });
        }

        private void IgnorarMensagem_Click(object sender, EventArgs e)
        {
            MessagingCenter.Unsubscribe<Model>(this, "msg");
        }
    }
}
