using System;
using Xamarin.Forms;

namespace XF_Views_TimePicker_Xaml
{
    public class App : Application
    {
        public TimeSpan TimeSpan { get; set; }

        public App()
        {
            MainPage = new MainPage();
            TimeSpan = new TimeSpan(22, 35, 00);
            BindingContext = this;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
