using System;
using Xamarin.Forms;

namespace XF_MessagingCenter5
{
    public partial class MainPage : ContentPage
    {
        public string Identificacao { get; }

        public MainPage()
        {
            InitializeComponent();
        }

        private void EnviarMensagem_Clicked(object sender, EventArgs e)
        {
            var r = new Random();
            var m = new Model {Texto = $"texto teste com número ateatório {r.Next(1, 101)}"};
            MessagingCenter.Send(this, "msg", m);
        }

        private void ReceberMensagem_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<MainPage, Model>(this, "msg", async (page, model) =>
            {
                await DisplayAlert($"Mensagem enviada por {page.Title}", model.Texto, "Ok");
            });
        }

        private void IgnorarMensagem_Click(object sender, EventArgs e)
        {
            MessagingCenter.Unsubscribe<MainPage, Model>(this, "msg");
        }
    }
}
