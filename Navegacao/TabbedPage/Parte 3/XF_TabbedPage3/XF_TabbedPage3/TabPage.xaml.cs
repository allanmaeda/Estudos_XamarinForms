using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_TabbedPage3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        public TabPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Atenção", "Botão clicado", "Ok");
        }
    }
}