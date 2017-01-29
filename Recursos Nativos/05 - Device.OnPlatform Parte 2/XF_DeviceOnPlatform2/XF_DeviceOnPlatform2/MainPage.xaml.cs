using Xamarin.Forms;

namespace XF_DeviceOnPlatform2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var valor = Device.OnPlatform(20, 0, 0);
            Padding = new Thickness(0, valor, 0, 0);
        }
    }
}
