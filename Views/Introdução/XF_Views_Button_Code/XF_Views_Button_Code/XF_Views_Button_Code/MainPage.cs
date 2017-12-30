using System;
using Xamarin.Forms;

namespace XF_Views_Button_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {

            var newButton = new Button
            {
                Text = "Meu Botao",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 25
            };

            newButton.Clicked += NewButtonClicado;

            Content = newButton;
        }

        private static void NewButtonClicado(object sender, EventArgs eventArgs)
        {
            System.Diagnostics.Debug.WriteLine("Botão clicado!");
        }
    }
}
