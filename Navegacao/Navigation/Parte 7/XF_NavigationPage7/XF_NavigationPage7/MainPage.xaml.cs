using System;
using Xamarin.Forms;

namespace XF_NavigationPage7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "MainPage1";
            NavigationPage.SetTitleIcon(this, "icon1");
        }

        private async void Button_OnClicked(object sender, EventArgs e){
            await Navigation.PushAsync(new MainPage2());
        }
    }
}
