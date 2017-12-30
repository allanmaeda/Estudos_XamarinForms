using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavigationPage4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Voltar à 2");
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage4());
        }
    }
}
