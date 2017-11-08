using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_EventosPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
            MessagingCenter.Send(this, "Constructor");
            Editor.Text += "Constructor foi chamado" + Environment.NewLine;
        }

        protected override void OnAppearing()
        {
            MessagingCenter.Send(this, "OnAppearing");
            base.OnAppearing();
            Editor.Text += "OnAppearing foi chamado" + Environment.NewLine;
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Send(this, "OnDisappearing");
            base.OnDisappearing();
            Editor.Text += "OnDisappearing foi chamado" + Environment.NewLine;
        }

        protected override bool OnBackButtonPressed()
        {
            MessagingCenter.Send(this, "OnBackButtonPressed");
            Editor.Text += "OnBackButtonPressed foi chamado" + Environment.NewLine;
            return base.OnBackButtonPressed();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}