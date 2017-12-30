using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_Picker1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Atenção", (string) Picker.SelectedItem, "Ok");
        }

        private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Entry.Text = Picker.Items[Picker.SelectedIndex];
        }
    }
}
