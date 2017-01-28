using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_ActionSheet1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Titulo", null, null, "opção 1", "opção 2", "opção 3");
            Label.Text = result;
            await Task.Delay(1000);
            Label.Text = "";
        }
    }
}
