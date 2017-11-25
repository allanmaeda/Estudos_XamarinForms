using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_CarouselPage12.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Button PublicButton => Button;

        public Page1()
        {
            InitializeComponent();
        }
    }
}