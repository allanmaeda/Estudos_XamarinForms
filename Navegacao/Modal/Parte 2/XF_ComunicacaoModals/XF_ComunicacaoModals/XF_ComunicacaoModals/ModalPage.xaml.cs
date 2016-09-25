using System;
using Xamarin.Forms;

namespace XF_ComunicacaoModals
{
    public partial class ModalPage : ContentPage
    {
        public ModalPage(string informacao)
        {
            InitializeComponent();
            Label.Text = informacao;
        }

        private async void FecharModal_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}
