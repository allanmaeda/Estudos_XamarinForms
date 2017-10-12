using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Aprofundado2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void ButtonAddElemento1_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddElemento1");
        }

        private void ButtonAddElemento2_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddElemento2");
        }

        private void ButtonAddElemento3_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddElemento3");
        }

        private async void ButtonVoltar_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}