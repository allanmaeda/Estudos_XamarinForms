using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_CarouselPage5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Entry PublicEntry => Entry;

        public Page1()
        {
            InitializeComponent();
        }
    }
}