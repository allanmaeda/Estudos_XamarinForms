using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MasterDetail5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhe2 : ContentPage
    {
        public Detalhe2()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "abrirMenu");
        }
    }
}