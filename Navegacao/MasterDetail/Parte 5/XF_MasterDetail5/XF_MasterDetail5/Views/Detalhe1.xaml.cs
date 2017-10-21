using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MasterDetail5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhe1 : ContentPage
    {
        public Detalhe1()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "abrirMenu");
        }
    }
}