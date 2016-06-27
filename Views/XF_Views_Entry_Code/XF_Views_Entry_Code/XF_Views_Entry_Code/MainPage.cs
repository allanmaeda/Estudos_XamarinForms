using System;
using Xamarin.Forms;

namespace XF_Views_Entry_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var newEntry = new Entry()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Placeholder = "Digite o texto aqui",
                Keyboard = Keyboard.Email
            };

            newEntry.Completed += NewEntryTextoCompleto;
            newEntry.TextChanged += NewEntryTextoModificado;

            Content = newEntry;
        }

        private static void NewEntryTextoModificado(object sender, TextChangedEventArgs textChangedEventArgs)
        {
            System.Diagnostics.Debug.WriteLine("texto modificado");
        }

        private static void NewEntryTextoCompleto(object sender, EventArgs eventArgs)
        {
            System.Diagnostics.Debug.WriteLine("texto concluído");
        }
    }
}
