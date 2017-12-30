using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_TabbedPage4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        public TabPage()
        {
            InitializeComponent();

            ItemsSource = new List<Model>
            {
                new Model
                {
                    Titulo = "Aba 1",
                    Texto1 = "Primeiro texto da aba 1",
                    Texto2 = "Segundo texto da aba 1",
                    Texto3 = "Terceiro texto da aba 1"
                },
                new Model
                {
                    Titulo = "Aba 2",
                    Texto1 = "Primeiro texto da aba 2",
                    Texto2 = "Segundo texto da aba 2",
                    Texto3 = "Terceiro texto da aba 2"
                },
                new Model
                {
                    Titulo = "Aba 3",
                    Texto1 = "Primeiro texto da aba 3",
                    Texto2 = "Segundo texto da aba 3",
                    Texto3 = "Terceiro texto da aba 3"
                }
            };
        }
    }
}