using Xamarin.Forms;

namespace XF_HelloWorld
{
    public class App : Application
    {
        public App()
        {
            MainPage = new ContentPage
            {
                Content = new Label
                {
                    Text = "Hello World!",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center
                }
            };
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
