using System;
using Xamarin.Forms;

namespace XF_DependencyService03
{
    public partial class MainPage : ContentPage
    {
        public IGerenciadorFotos GerenciadorFotos { get; }

        public MainPage()
        {
            InitializeComponent();
            GerenciadorFotos = DependencyService.Get<IGerenciadorFotos>();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var imageStream = await GerenciadorFotos.ObterFoto();
            Image.Source = ImageSource.FromStream(() => imageStream);
        }
    }
}
