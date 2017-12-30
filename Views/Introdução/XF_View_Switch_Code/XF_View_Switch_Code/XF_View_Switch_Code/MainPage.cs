using Xamarin.Forms;

namespace XF_View_Switch_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var sw = new Switch()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                IsToggled = true
            };

            sw.Toggled += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine("Status atual do switch: " + args.Value);
            };

            Content = sw;
        }
    }
}
