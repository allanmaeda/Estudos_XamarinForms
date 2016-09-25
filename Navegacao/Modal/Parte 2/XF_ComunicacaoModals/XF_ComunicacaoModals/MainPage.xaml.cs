using System;
using Xamarin.Forms;

namespace XF_ComunicacaoModals
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnAbrirModal_OnClicked(object sender, EventArgs e)
        {
            var modalPage1 = new ModalPage(Entry.Text);
            await Navigation.PushModalAsync(modalPage1, true);
        }
    }
}
