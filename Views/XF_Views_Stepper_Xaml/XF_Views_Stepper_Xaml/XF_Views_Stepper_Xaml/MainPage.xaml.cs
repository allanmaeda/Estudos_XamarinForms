using Xamarin.Forms;

namespace XF_Views_Stepper_Xaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Stepper_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("valor antigo era " + e.OldValue);
            System.Diagnostics.Debug.WriteLine("Novo valor é " + e.NewValue);
        }
    }
}
