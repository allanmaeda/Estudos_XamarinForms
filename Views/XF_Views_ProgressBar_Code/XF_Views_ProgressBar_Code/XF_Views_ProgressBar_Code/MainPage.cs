using Xamarin.Forms;

namespace XF_Views_ProgressBar_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var progressBar = new ProgressBar
            {
                Progress = 0.5,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Content = progressBar;
        }
    }
}
