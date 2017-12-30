using System;
using Xamarin.Forms;

namespace XF_NavigationPage2
{
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }
    }
}
