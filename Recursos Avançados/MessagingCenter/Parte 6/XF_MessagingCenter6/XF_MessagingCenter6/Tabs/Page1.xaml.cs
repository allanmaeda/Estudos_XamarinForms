using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MessagingCenter6.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ButtonAtivar_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<Page2, string>(this, "msg", (p, s) =>
            {
                if (!string.IsNullOrEmpty(s))
                    EntryPage2.Text = s;
            });

            MessagingCenter.Subscribe<Page3, string>(this, "msg", (p, s) =>
            {
                if (!string.IsNullOrEmpty(s))
                    EntryPage3.Text = s;
            });
        }

        private void ButtonDesativar_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Unsubscribe<Page2, string>(this, "msg");
            MessagingCenter.Unsubscribe<Page3, string>(this, "msg");
        }
    }
}