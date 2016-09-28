using Xamarin.Forms;

namespace XF_ComunicacaoModalsBinding
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new MainPage();
            MainPage = new NavigationPage(content);
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
