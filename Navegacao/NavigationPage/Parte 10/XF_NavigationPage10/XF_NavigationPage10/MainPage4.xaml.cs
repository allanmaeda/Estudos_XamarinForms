using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavigationPage10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage4 : ContentPage
    {
        public MainPage4()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}