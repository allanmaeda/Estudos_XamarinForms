using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MessagingCenter7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<Page2, string>(this, "msg", (page2, s) => SegundaEntry.Text = s);
            MessagingCenter.Subscribe<Page3, string>(this, "msg", (page3, s) => TerceiraEntry.Text = s);
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}