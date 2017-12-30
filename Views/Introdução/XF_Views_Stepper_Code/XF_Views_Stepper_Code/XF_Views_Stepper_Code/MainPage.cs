using Xamarin.Forms;

namespace XF_Views_Stepper_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var stepper = new Stepper
            {
                Maximum = 10,
                Minimum = 1,
                Increment = 0.4,
                Value = 5,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            stepper.ValueChanged += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine("valor antigo era " + args.OldValue);
                System.Diagnostics.Debug.WriteLine("Novo valor é " + args.NewValue);
            };

            Content = stepper;
        }
    }
}
