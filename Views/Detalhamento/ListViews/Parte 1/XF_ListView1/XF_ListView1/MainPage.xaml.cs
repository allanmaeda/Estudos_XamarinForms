using System.Collections.Generic;
using Xamarin.Forms;

namespace XF_ListView1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var listElements = new List<string>();
            for (var i = 1; i < 20; i++)
            {
                listElements.Add($"Elemento de número {i}");
            }

            var listView = new ListView
            {
                ItemsSource = listElements
            };

            listView.Footer = new Button {Text = "Rodapé"};

            listView.Header = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label {Text = "Cabecalho1"},
                    new Label {Text = "Cabecalho2"}
                }
            };

            Content = listView;
        }
    }
}
