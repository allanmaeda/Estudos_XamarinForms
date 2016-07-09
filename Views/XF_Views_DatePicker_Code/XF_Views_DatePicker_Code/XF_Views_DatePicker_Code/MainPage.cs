using System;
using Xamarin.Forms;

namespace XF_Views_DatePicker_Code
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var datePicker = new DatePicker
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                Format = "yyyy/MM/dd",
                MinimumDate = new DateTime(2016, 01, 01),
                MaximumDate = new DateTime(2016, 01, 31)
            };

            datePicker.DateSelected += (sender, args) =>
            {
                System.Diagnostics.Debug.WriteLine($"Data antiga: {args.OldDate.ToString("yy-MM-dd")}");
                System.Diagnostics.Debug.WriteLine($"Data nova: {args.NewDate.ToString("yy-MM-dd")}");
            };

            Content = datePicker;
        } 
    }
}
