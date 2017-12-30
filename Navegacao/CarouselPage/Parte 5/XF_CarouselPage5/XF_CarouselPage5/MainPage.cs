using Xamarin.Forms;

namespace XF_CarouselPage5
{
    public class MainPage : CarouselPage
    {
        public MainPage()
        {
            Children.Add(new Page1());
            Children.Add(new Page2());

            ((Page1) Children[0]).PublicEntry.TextChanged += (sender, args) =>
            {
                ((Page2) Children[1]).PublicEntry.Text = args.NewTextValue;
            };
        }
    }
}
