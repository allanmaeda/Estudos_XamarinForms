using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MasterDetail6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPageExemplo : ContentPage
    {
        public ContentPageExemplo()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "abrirMenu");
        }
    }
}