using Xamarin.Forms;

namespace XF_DataBinding9
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
