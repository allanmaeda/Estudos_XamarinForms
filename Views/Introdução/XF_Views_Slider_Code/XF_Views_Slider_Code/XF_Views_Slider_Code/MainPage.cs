using Xamarin.Forms;

namespace XF_Views_Slider_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var slider = new Slider
            {
                Minimum = 0,
                Maximum = 125,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Fill,
                Value = 57
            };

            slider.ValueChanged += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine("Valor antigo era " + args.OldValue);
                System.Diagnostics.Debug.WriteLine("Valor novo é " + args.NewValue);
            };

            Content = slider;
        }
    }
}
