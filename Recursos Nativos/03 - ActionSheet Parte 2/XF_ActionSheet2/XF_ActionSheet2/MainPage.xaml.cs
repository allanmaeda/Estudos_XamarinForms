using System;
using Xamarin.Forms;

namespace XF_ActionSheet2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked1(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Título", "Botão cancelar", null, "opção 1", "opção 2");
            Label.Text = $"Primeiro DisplayAlert fechado com {result}";
        }

        private async void Button_OnClicked2(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Título", null, "Botão destruir", "opção 1", "opção 2");
            Label.Text = $"Segundo DisplayAlert fechado com {result}";
        }

        private async void Button_OnClicked3(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Título", "Botão cancelar", "Botão destruir", "opção 1", "opção 2");
            Label.Text = $"Terceiro DisplayAlert fechado com {result}";
        }
    }
}
