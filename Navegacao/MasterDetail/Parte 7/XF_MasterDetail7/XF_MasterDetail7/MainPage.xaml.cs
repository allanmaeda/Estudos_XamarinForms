using System;
using Xamarin.Forms;
using XF_MasterDetail7.Views;

namespace XF_MasterDetail7
{
    public partial class MainPage : ContentPage
    {
        public MasterDetail MasterDetail { get; set; }

        public MainPage()
        {
            InitializeComponent();
            MasterDetail = new MasterDetail();
        }

        private async void ButtonDefault_OnClicked(object sender, EventArgs e)
        {
            MasterDetail.MasterBehavior = MasterBehavior.Default;
            await Navigation.PushModalAsync(MasterDetail);
        }

        private async void ButtonPopover_OnClicked(object sender, EventArgs e)
        {
            MasterDetail.MasterBehavior = MasterBehavior.Popover;
            await Navigation.PushModalAsync(MasterDetail);
        }

        private async void ButtonSplit_OnClicked(object sender, EventArgs e)
        {
            MasterDetail.MasterBehavior = MasterBehavior.Split;
            await Navigation.PushModalAsync(MasterDetail);
        }

        private async void ButtonSplitOnLandscape_OnClicked(object sender, EventArgs e)
        {
            MasterDetail.MasterBehavior = MasterBehavior.SplitOnLandscape;
            await Navigation.PushModalAsync(MasterDetail);
        }

        private async void ButtonSplitOnPortrait_OnClicked(object sender, EventArgs e)
        {
            MasterDetail.MasterBehavior = MasterBehavior.SplitOnPortrait;
            await Navigation.PushModalAsync(MasterDetail);
        }


    }
}
