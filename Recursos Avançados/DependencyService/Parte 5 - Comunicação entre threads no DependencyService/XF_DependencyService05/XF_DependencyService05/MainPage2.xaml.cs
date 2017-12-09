using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_DependencyService05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        public Switch PublicSwitchVogais => SwitchVogais;
        public Switch PublicSwitchConsoantes => SwitchConsoantes;
        public Switch PublicSwitchEspacos => SwitchEspacos;

        public Button PublicButtonCancelar => ButtonCancelar;
        public Button PublicButtonConfirmar => ButtonConfirmar;

        public MainPage2()
        {
            InitializeComponent();
        }
    }
}