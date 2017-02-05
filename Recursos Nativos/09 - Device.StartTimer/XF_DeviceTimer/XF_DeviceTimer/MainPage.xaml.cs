using System;
using Xamarin.Forms;

namespace XF_DeviceTimer
{
    public partial class MainPage : ContentPage
    {
        private int _vezesTimer;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (_vezesTimer == 4)
                {
                    _vezesTimer = 0;
                    Button.IsEnabled = true;
                    Entry.Text = string.Empty;
                    return false;
                }

                Entry.Text = $"Timer foi executado {++_vezesTimer} vezes";
                Button.IsEnabled = false;
                return true;
            });
        }
    }
}
