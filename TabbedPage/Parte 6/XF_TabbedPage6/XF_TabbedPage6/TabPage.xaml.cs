using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_TabbedPage6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        public TabPage()
        {
            InitializeComponent();

            Children.Add(new MainPage { Title="P1" });
            Children.Add(new NavigationPage(new MainPage2()) { Title = "P2" });
        }
    }
}