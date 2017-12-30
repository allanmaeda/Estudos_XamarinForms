using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavigationPage8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage4 : ContentPage
    {
        public MainPage4()
        {
            InitializeComponent();
        }

        private async void NavegarParaProximaPagina(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage5());
        }

        private void VoltarParaPagina1(object sender, EventArgs e)
        {
            // tirando pagina 2 da pilha
            Navigation.RemovePage(Navigation.NavigationStack[1]);

            // tirando pagina 3 da pilha (que virou a 2)
            Navigation.RemovePage(Navigation.NavigationStack[1]);

            // voltando para pagina anterior
            Navigation.PopAsync();
        }
    }
}