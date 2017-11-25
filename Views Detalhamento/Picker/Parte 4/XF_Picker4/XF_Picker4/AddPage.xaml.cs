using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Picker4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private async void ButtonCancelar_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }

        private async void ButtonConfirmar_OnClicked(object sender, EventArgs e)
        {
            var el = new Elemento
            {
                ValorReal = Convert.ToInt32(EntryReal.Text),
                ValorVisual = EntryVisual.Text
            };
            MessagingCenter.Send(this, "NovoElemento", el);
            await Navigation.PopModalAsync(true);
        }
    }
}