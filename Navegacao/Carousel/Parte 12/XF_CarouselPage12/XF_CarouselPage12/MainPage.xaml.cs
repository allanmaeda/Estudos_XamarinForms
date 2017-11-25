using Xamarin.Forms;
using XF_CarouselPage12.Paginas;

namespace XF_CarouselPage12
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();

            ((Page1) Children[0]).PublicButton.Clicked += (sender, args) =>
            {
                CurrentPage = Children[3];
            };

            ((Page5) Children[4]).PublicButton.Clicked += (sender, args) =>
            {
                CurrentPage = Children[1];
            };

        }
    }
}
