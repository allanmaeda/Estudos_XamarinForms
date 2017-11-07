using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_CarouselPage5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Entry PublicEntry => Entry;

        public Page2()
        {
            InitializeComponent();
        }
    }
}