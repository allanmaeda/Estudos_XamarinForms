using Xamarin.Forms;

namespace XF_Layout_MultiplasViews_Code
{
    public class MainPage : ContentPage
    {
        private Button Botao { get; }

        private Entry CaixaDeTexto { get; }

        private Label Texto { get; }

        public MainPage()
        {
            Botao = new Button { Text = "Clique aqui! "};
            CaixaDeTexto = new Entry
            {
                HorizontalOptions = LayoutOptions.Fill
            };
            Texto = new Label { Text = "Texto exemplo" };
            Botao.Clicked += (sender, args) =>
            {
                Texto.Text = string.IsNullOrEmpty(CaixaDeTexto.Text) 
                    ? "Você precisa digitar um texto!"
                    : CaixaDeTexto.Text;
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    Texto,
                    Botao,
                    CaixaDeTexto
                }
            };
        }
    }
}

