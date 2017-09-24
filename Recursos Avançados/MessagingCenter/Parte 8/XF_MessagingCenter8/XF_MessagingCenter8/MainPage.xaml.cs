using System;
using Xamarin.Forms;

namespace XF_MessagingCenter8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<MainPage2, ViewModel>(this, "msg", (p, vm) =>
            {
                BindingContext = vm;
            });
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage2());
        }
    }
}
