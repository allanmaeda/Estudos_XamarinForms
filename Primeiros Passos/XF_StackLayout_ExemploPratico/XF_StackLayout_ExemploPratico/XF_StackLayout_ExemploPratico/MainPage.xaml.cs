using Xamarin.Forms;

namespace XF_StackLayout_ExemploPratico
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            var color = Color.FromRgb(SliderR.Value, SliderG.Value, SliderB.Value);
            Caixa.BackgroundColor = color;
        }
    }
}
