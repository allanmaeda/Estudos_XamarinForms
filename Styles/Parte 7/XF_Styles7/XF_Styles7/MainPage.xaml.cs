using System;
using Xamarin.Forms;

namespace XF_Styles7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DarDestaque_OnClick(object sender, EventArgs e)
        {
            Resources["Estilo"] = Resources["StyleExemploComDestaque"];
        }

        private void TirarDestaque_OnClick(object sender, EventArgs e)
        {
            Resources["Estilo"] = Resources["StyleExemploSemDestaque"];
        }
    }
}
