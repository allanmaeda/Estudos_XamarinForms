using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XF_View_Switch_Xaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Switch_OnToggled(object sender, ToggledEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Status atual do switch: " + e.Value);
        }
    }
}
