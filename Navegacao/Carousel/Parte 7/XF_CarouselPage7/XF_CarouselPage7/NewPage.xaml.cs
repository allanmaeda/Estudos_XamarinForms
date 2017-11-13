using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_CarouselPage7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPage : ContentPage
    {
        public string Text { get; }

        public NewPage(string text)
        {
            Text = text;
            BindingContext = this;
            InitializeComponent();
        }
    }
}