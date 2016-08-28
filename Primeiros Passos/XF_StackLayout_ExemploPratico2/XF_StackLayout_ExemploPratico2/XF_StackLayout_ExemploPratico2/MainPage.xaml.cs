using Xamarin.Forms;

namespace XF_StackLayout_ExemploPratico2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            var color = Color.FromRgb(SliderR.Value, SliderG.Value, SliderB.Value);
            Caixa.BackgroundColor = color;
            
            // vermelho mais que todas as cores
            if (SliderR.Value > SliderG.Value && SliderR.Value > SliderB.Value)
                LblCorResultante.Text = "Predominância de vermelho";

            // verde mais que todas as cores
            if (SliderG.Value > SliderR.Value && SliderG.Value > SliderB.Value)
                LblCorResultante.Text = "Predominância de verde";

            // azul mais que todas as cores
            if (SliderB.Value > SliderG.Value && SliderB.Value > SliderR.Value)
                LblCorResultante.Text = "Predominância de azul";

            // valor igual de cores
            if (SliderR.Value == SliderG.Value && SliderG.Value == SliderB.Value)
                LblCorResultante.Text = "Cor equilibrada";
        }
    }
}
