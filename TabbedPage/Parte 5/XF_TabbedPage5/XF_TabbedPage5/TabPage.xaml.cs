using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_TabbedPage5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        public TabPage()
        {
            InitializeComponent();

            Children.Add(new MainPage { Title = "P1" });
            Children.Add(new MainPage2 { Title = "P2" });
            Children.Add(new MainPage3 { Title = "P3" });
        }
    }
}