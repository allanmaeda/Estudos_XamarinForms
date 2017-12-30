using System;
using Xamarin.Forms;

namespace XF_Views_SearchBar_Xaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Texto que estava no elemento: " + e.OldTextValue);
            System.Diagnostics.Debug.WriteLine("Texto que está no elemento: " + e.NewTextValue);
        }

        private void SearchBar_OnSearchButtonPressed(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Texto no elemento: " + ((SearchBar)sender).Text);
        }
    }
}
