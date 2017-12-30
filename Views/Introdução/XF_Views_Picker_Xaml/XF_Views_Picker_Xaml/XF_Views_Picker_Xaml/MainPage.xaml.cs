using System;
using Xamarin.Forms;

namespace XF_Views_Picker_Xaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Índice escolhido do picker: {((Picker)sender).SelectedIndex}");
            System.Diagnostics.Debug.WriteLine($"Elemento escolhido do picker: {((Picker)sender).Items[((Picker)sender).SelectedIndex]}");
        }
    }
}
