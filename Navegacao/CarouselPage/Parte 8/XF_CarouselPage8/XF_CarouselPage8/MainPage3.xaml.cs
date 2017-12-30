using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_CarouselPage8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage3 : ContentPage
    {
        public Button PublicButton => Button;

        public MainPage3()
        {
            InitializeComponent();
        }
    }
}