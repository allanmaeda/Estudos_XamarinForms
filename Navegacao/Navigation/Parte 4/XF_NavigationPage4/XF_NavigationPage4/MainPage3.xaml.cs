using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavigationPage4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage3 : ContentPage
    {
        public MainPage3()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage4());
        }
    }
}
