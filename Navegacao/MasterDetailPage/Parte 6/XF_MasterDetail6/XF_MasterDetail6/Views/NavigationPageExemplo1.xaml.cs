using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MasterDetail6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageExemplo1 : ContentPage
    {
        public NavigationPageExemplo1()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPageExemplo2());
        }
    }
}