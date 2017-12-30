using System;
using Xamarin.Forms;

namespace XF_Views_TimePicker_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var timePicker = new TimePicker
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Fill,
                Format = "HH:mm",
                Time = new TimeSpan(22,35,00)
            };

            Content = timePicker;
        }
    }
}
