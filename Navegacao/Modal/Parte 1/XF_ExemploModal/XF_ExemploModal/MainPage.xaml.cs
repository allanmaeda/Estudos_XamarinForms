using System;
using Xamarin.Forms;

namespace XF_ExemploModal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPageModal());
        }
    }
}
