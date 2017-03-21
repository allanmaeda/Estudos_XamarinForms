using Xamarin.Forms;

namespace XF_Imagens1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var image = new Image
            {
                Source = ImageSource.FromResource("XF_Imagens1.imagem.png"),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            Content = image;
        }
    }
}
