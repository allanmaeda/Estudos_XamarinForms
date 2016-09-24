using System;
using Xamarin.Forms;

namespace XF_ExemploModal
{
    public partial class MainPageModal : ContentPage
    {
        public MainPageModal()
        {
            InitializeComponent();
        }

        private async void ButtonFecharModal_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}
