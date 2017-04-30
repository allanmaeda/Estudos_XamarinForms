using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_Imagens6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var image = new Image
            {
                Source = ImageSource.FromUri(new Uri("http://www.randrade.net/wp-content/uploads/2017/04/lampada.png")),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Content = image;
        }
    }
}
