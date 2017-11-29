using System;
using Xamarin.Forms;

namespace XF_DependencyService01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var exemplo = DependencyService.Get<IExemplo>();
            await DisplayAlert("Atenção", exemplo.MensagemCustomizada(), "Ok");
        }
    }
}
