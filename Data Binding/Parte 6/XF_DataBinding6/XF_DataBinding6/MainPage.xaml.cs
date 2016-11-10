using Xamarin.Forms;

namespace XF_DataBinding6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel();
            Text1.Text = "0";
        }
    }
}
