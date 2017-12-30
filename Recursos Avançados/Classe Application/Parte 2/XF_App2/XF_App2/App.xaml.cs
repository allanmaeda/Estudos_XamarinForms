using Xamarin.Forms;

namespace XF_App2
{
    public partial class App : Application
    {
        public string ExemploDeValor { get; set; }

        public string OutroExemploDeValor { get; set; }

        public App()
        {
            InitializeComponent();
            ExemploDeValor = "Texto Exemplo";
            OutroExemploDeValor = "Outro Exemplo";
            MainPage = new XF_App2.MainPage();
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
