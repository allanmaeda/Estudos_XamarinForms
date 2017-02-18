using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_BeginInvokeOnMainThread
{
    public partial class MainPage : ContentPage
    {
        private readonly Random r;

        public MainPage()
        {
            InitializeComponent();
            r = new Random();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Task.Factory.StartNew(() =>
            {
                var valorSorteado = r.Next(0, 10);
                Device.BeginInvokeOnMainThread(() =>
                {
                    Button.Text = $"O valor sorteado foi {valorSorteado}";
                });
            });
        }
    }
}
