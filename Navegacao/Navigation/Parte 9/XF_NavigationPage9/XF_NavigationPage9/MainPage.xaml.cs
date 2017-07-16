using System;
using Xamarin.Forms;

namespace XF_NavigationPage9
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var novaPagina = new MainPage4();
            await Navigation.PushAsync(novaPagina);
            Navigation.InsertPageBefore(new MainPage2(), novaPagina);
            Navigation.InsertPageBefore(new MainPage3(), novaPagina);
        }
    }
}
