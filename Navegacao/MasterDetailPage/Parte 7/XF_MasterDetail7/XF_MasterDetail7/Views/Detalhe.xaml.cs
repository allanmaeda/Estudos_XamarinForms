using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MasterDetail7.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhe : ContentPage
    {
        public Detalhe()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "abrirMenu");
        }

        private void ButtonVoltar_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "voltar");
        }
    }
}