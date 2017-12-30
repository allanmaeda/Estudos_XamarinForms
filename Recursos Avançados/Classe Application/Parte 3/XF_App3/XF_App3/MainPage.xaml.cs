using System;
using Xamarin.Forms;

namespace XF_App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("OnStart"))
                LabelOnStart.Text = $"OnStart em {Application.Current.Properties["OnStart"]:dd-MM-yyyy HH:mm:ss}";

            if (Application.Current.Properties.ContainsKey("OnSleep"))
                LabelOnSleep.Text = $"OnSleep em {Application.Current.Properties["OnSleep"]:dd-MM-yyyy HH:mm:ss}";

            if (Application.Current.Properties.ContainsKey("OnResume"))
                LabelOnResume.Text = $"OnResume em {Application.Current.Properties["OnResume"]:dd-MM-yyyy HH:mm:ss}";
        }
    }
}
