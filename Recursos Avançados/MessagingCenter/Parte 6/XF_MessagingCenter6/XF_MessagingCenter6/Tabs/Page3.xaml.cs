using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MessagingCenter6.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            MessagingCenter.Send(this, "msg", e.NewTextValue);
        }
    }
}