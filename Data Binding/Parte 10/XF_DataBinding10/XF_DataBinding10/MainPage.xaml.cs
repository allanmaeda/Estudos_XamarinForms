using Xamarin.Forms;

namespace XF_DataBinding10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel();
        }
    }
}
