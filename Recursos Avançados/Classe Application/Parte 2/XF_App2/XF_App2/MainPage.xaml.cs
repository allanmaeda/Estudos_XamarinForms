using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label1.Text = ((App) Application.Current).ExemploDeValor;
            Label2.Text = ((App) Application.Current).OutroExemploDeValor;

        }
    }
}
