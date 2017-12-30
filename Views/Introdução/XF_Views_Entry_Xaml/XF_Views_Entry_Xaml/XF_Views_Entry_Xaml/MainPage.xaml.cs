using System;
using Xamarin.Forms;

namespace XF_Views_Entry_Xaml
{
    public partial class MainPage : ContentPage
    {
        public Keyboard KeyboardPersonalizado { get; set; }

        public MainPage()
        {
            InitializeComponent();
            KeyboardPersonalizado = Keyboard.Email;
            BindingContext = this;
        }

        private void NewEntryTextoModificado(object sender, TextChangedEventArgs textChangedEventArgs)
        {
            System.Diagnostics.Debug.WriteLine("texto modificado");
        }

        private void NewEntryTextoCompleto(object sender, EventArgs eventArgs)
        {
            System.Diagnostics.Debug.WriteLine("texto concluído");
        }

    }
}
