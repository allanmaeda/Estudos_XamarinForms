using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace XF_App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Application.Current.ModalPushing += (sender, args) => Debug.WriteLine($"{DateTime.Now} - nova tela será aberta via modal");
            Application.Current.ModalPushed += (sender, args) => Debug.WriteLine($"{DateTime.Now} - nova tela foi aberta via modal");
            Application.Current.ModalPopping += (sender, args) => Debug.WriteLine($"{DateTime.Now} - nova tela modal será fechada");
            Application.Current.ModalPopped += (sender, args) => Debug.WriteLine($"{DateTime.Now} - nova tela modal foi fechada");
        }

        private async void ByModal_OnClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage2());
        }
    }
}
