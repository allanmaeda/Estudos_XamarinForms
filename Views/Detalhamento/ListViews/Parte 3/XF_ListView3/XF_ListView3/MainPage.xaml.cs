using System.Collections.Generic;
using Xamarin.Forms;

namespace XF_ListView3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var listaElementos = new List<string>();
            for (var i = 1; i <= 30; i++)
            {
                listaElementos.Add($"Elemento {i}");
            }
            var listView = new ListView { ItemsSource = listaElementos };

            var label = new Label { Text = "Titulo", HorizontalOptions = LayoutOptions.CenterAndExpand };
            var botao = new Button { Text = "Botão Exemplo" };

            var layout = new StackLayout
            {
                Children = { label, listView, botao }
            };

            Content = layout;
        }
    }
}
