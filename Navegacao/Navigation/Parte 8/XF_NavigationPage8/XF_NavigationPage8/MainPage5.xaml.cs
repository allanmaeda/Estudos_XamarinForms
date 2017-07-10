using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavigationPage8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage5 : ContentPage
    {
        public MainPage5()
        {
            InitializeComponent();
        }

        private void VoltarParaPagina3(object sender, EventArgs e)
        {
            // removendo a pagina 4 da pilha
            Navigation.RemovePage(Navigation.NavigationStack[3]);
            Navigation.PopAsync();
        }
    }
}