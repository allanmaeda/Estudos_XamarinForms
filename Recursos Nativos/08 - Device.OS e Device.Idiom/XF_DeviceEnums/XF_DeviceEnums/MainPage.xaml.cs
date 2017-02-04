using System;
using Xamarin.Forms;

namespace XF_DeviceEnums
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void PrimeiroBotao_OnClicked(object sender, EventArgs e)
        {
            if (Device.OS == TargetPlatform.Android)
                await DisplayAlert("Atenção", "Código está rodando em Android", "Ok");
            else if (Device.OS == TargetPlatform.iOS)
                await DisplayAlert("Atenção", "Código está rodando em iOS", "Ok");
        }

        private async void SegundoBotao_OnClicked(object sender, EventArgs e)
        {
            if (Device.Idiom == TargetIdiom.Desktop)
                await DisplayAlert("Atenção", "Código está rodando em desktop", "Ok");
            if (Device.Idiom == TargetIdiom.Phone)
                await DisplayAlert("Atenção", "Código está rodando em smartphone", "Ok");
            if (Device.Idiom == TargetIdiom.Tablet)
                await DisplayAlert("Atenção", "Código está rodando em tablet", "Ok");
        }
    }
}
