using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace XF_NavigationPage4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Voltar à 1");
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage2());
        }

        private async void Button_OnClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage3());
        }
    }
}
