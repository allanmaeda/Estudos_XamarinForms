using System;
using Xamarin.Forms;

namespace XF_Views_TimePicker_Xaml
{
    public partial class MainPage : ContentPage
    {
        public TimeSpan TimeSpan { get; set; }

        public MainPage()
        {
            InitializeComponent();
            TimeSpan = new TimeSpan(22, 35, 00);
            BindingContext = this;
        }
    }
}
