using System;
using Xamarin.Forms;

namespace XF_App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage2());
        }
    }
}
