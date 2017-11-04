using Xamarin.Forms;

namespace XF_CarouselPage2
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();
            Children.Add(new Page1());
            Children.Add(new Page2());
            Children.Add(new Page3());
        }
    }
}
