using System;
using Xamarin.Forms;

namespace XF_EventosPages
{
    public partial class MainPage : ContentPage
    {
        private MainPage2 Page { get; set; }

        public MainPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<MainPage2>(this, "Constructor", page2 =>
            {
                Editor.Text += "Constructor foi chamado" + Environment.NewLine;
            });

            MessagingCenter.Subscribe<MainPage2>(this, "OnAppearing", page2 =>
            {
                Editor.Text += "OnAppearing foi chamado" + Environment.NewLine;
            });

            MessagingCenter.Subscribe<MainPage2>(this, "OnDisappearing", page2 =>
            {
                Editor.Text += "OnDisappearing foi chamado" + Environment.NewLine;
            });

            MessagingCenter.Subscribe<MainPage2>(this, "OnBackButtonPressed", page2 =>
            {
                Editor.Text += "OnBackButtonPressed foi chamado" + Environment.NewLine;
            });
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            if (Page == null)
                Page = new MainPage2();
            await Navigation.PushModalAsync(Page);
        }
    }
}
