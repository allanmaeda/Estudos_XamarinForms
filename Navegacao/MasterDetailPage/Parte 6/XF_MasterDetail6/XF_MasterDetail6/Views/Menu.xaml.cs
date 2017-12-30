using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MasterDetail6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ButtonContentPage_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "contentPage");
        }

        private void ButtonTabbedPage_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "tabbedPage");
        }

        private void ButtonNavigationPage_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "navigationPage");
        }
    }
}