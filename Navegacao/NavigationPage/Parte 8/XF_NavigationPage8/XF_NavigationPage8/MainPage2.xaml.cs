using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavigationPage8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        private async void NavegarParaProximaPagina(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage3());
        }
    }
}