using System;

using Xamarin.Forms;

namespace XF_Views_Button_Xaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NewButtonClicado(object sender, EventArgs eventArgs)
        {
            System.Diagnostics.Debug.WriteLine("Botão clicado!");
        }
    }
}
