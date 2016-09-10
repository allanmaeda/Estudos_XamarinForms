using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace XF_ScrollView_Parte3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MeuScroll_OnScrolled(object sender, ScrolledEventArgs e)
        {
            Debug.WriteLine("");
            Debug.WriteLine($"ScrollView com altura: {MeuScroll.ContentSize.Height}");
            Debug.WriteLine($"ScrollView con largura: {MeuScroll.ContentSize.Width}");
            Debug.WriteLine("");
            Debug.WriteLine($"ScrollView está na posição X:{MeuScroll.ScrollX}");
            Debug.WriteLine($"ScrollView está na posição Y:{MeuScroll.ScrollY}");
            Debug.WriteLine("");

            Debug.WriteLine(Content.Height);
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var r = new Random().Next(0, 4);

            switch (r)
            {
                case 0:
                    await MeuScroll.ScrollToAsync(Box1, ScrollToPosition.Center, true);
                    break;
                case 1:
                    await MeuScroll.ScrollToAsync(Box2, ScrollToPosition.End, true);
                    break;
                case 2:
                    await MeuScroll.ScrollToAsync(Box3, ScrollToPosition.Start, true);
                    break;
                case 3:
                    await MeuScroll.ScrollToAsync(Box4, ScrollToPosition.MakeVisible, true);
                    break;
            }
        }
    }
}
