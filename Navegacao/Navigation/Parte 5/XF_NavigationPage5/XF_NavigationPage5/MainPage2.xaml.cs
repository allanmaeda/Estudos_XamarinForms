using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_NavigationPage5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        public string Texto { get; set; }

        public MainPage2()
        {
            InitializeComponent();
            Texto = $"Esta é a {Title}";
            BindingContext = this;
            Title = "";
        }
    }
}
