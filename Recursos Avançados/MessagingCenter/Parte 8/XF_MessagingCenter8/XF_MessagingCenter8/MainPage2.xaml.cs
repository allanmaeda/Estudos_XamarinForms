using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MessagingCenter8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        public ViewModel Vm { get; }

        public MainPage2()
        {
            InitializeComponent();
            Vm = new ViewModel();
            BindingContext = Vm;
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "msg", Vm);
            await Navigation.PopModalAsync(true);
        }
    }
}