using System;
using Xamarin.Forms;

namespace XF_Layout_MultiplasViews_Xaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Texto.Text = string.IsNullOrEmpty(CaixaDeTexto.Text)
                    ? "Você precisa digitar um texto!"
                    : CaixaDeTexto.Text;
        }
    }
}
