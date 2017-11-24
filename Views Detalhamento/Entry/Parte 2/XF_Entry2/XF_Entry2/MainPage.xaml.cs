using Xamarin.Forms;

namespace XF_Entry2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Entry1.Completed += (sender, args) =>
            {
                Entry2.IsEnabled = true;
                Entry2.Focus();
            };
            Entry2.Completed += (sender, args) =>
            {
                Entry3.IsEnabled = true;
                Entry3.Focus();
            };
        }
    }
}
