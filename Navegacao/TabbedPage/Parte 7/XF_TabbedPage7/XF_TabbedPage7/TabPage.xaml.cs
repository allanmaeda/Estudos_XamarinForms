using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_TabbedPage7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        public TabPage()
        {
            InitializeComponent();

            BarBackgroundColor = Color.AliceBlue;
            BarTextColor = Color.DarkOrange;
        }
    }
}