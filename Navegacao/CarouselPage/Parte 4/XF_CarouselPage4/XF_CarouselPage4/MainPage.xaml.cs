using Xamarin.Forms;

namespace XF_CarouselPage4
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();
            Entry.TextChanged += (sender, args) =>
            {
                Entry2.Text = args.NewTextValue;
            };
        }
    }
}
