using Xamarin.Forms;

namespace XF_Views_BoxView_Xaml
{
    public partial class MainPage : ContentPage
    {
        public Color BoxColor { get; set; }

        public MainPage()
        {
            InitializeComponent();
            BoxColor = Color.FromRgb(200, 100, 100);
            BindingContext = this;
        }
    }
}
