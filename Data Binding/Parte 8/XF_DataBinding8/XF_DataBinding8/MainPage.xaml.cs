using Xamarin.Forms;

namespace XF_DataBinding8
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
