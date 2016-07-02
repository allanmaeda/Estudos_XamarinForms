using Xamarin.Forms;

namespace XF_Views_Slider_Xaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Valor antigo era " + e.OldValue);
            System.Diagnostics.Debug.WriteLine("Valor novo é " + e.NewValue);
        }
    }
}
