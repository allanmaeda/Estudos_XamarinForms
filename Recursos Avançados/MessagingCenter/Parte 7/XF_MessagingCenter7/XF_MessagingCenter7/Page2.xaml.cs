using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MessagingCenter7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            MessagingCenter.Send(this, "msg", e.NewTextValue);
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}