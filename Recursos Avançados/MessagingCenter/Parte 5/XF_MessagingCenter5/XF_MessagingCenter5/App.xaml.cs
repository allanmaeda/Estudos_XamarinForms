using Xamarin.Forms;

namespace XF_MessagingCenter5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XF_MessagingCenter5.MainPage();
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
