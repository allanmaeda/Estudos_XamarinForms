using Xamarin.Forms;

namespace XF_Views_BoxView_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var boxView = new BoxView
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 200,
                HeightRequest = 350,
                Color = Color.FromRgb(200, 100, 100)
            };

            Content = boxView;
        }
    }
}
