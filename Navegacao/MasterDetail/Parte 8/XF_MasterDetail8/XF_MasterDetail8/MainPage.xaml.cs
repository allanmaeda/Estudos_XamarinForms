using System;
using Xamarin.Forms;
using XF_MasterDetail8.Views;

namespace XF_MasterDetail8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonPortrait_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MasterDetail { MasterBehavior = MasterBehavior.SplitOnPortrait }, true);
        }

        private async void ButtonLandscape_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MasterDetail { MasterBehavior = MasterBehavior.SplitOnLandscape }, true);
        }
    }
}
