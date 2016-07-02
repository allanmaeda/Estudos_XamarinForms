using Xamarin.Forms;

namespace XF_Views_ActivityIndicator_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var activityIndicator = new ActivityIndicator
            {
                IsRunning = true,
                IsVisible = true
            };

            Content = activityIndicator;
        }
    }
}
