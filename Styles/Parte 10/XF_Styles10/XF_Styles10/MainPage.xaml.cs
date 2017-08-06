using System;
using Xamarin.Forms;

namespace XF_Styles10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var r = new Random();
            var vl = r.Next(0, 2);

            if (vl == 0)
                Resources["StyleDinamico"] = Application.Current.Resources["Style1"];
            else
                Resources["StyleDinamico"] = Application.Current.Resources["Style2"];
        }
    }
}
