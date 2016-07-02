using System;
using Xamarin.Forms;

namespace XF_Views_Editor_Xaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Editor_OnCompleted(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("texto completo");
        }

        private void Editor_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("texto editado");
        }
    }
}
