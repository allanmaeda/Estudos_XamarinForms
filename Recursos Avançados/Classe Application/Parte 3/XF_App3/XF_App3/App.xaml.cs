using System;
using Xamarin.Forms;

namespace XF_App3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            if (!Properties.ContainsKey("OnStart"))
                Properties.Add("OnStart", DateTime.Now);
            else
                Properties["OnStart"] = DateTime.Now;
            SavePropertiesAsync().ConfigureAwait(false);
        }

        protected override void OnSleep()
        {
            if (!Properties.ContainsKey("OnSleep"))
                Properties.Add("OnSleep", DateTime.Now);
            else
                Properties["OnSleep"] = DateTime.Now;
            SavePropertiesAsync().ConfigureAwait(false);
        }

        protected override void OnResume()
        {
            if (!Properties.ContainsKey("OnResume"))
                Properties.Add("OnResume", DateTime.Now);
            else
                Properties["OnResume"] = DateTime.Now;
            SavePropertiesAsync().ConfigureAwait(true);
        }
    }
}
