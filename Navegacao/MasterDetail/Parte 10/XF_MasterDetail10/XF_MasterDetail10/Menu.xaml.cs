using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MasterDetail10.Detalhes;

namespace XF_MasterDetail10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public ListView PublicListView => ListView;

        public Menu()
        {
            InitializeComponent();

            ListView.ItemsSource = new List<ItemMenu>
            {
                new ItemMenu
                {
                    Texto = "Página 1",
                    Type = typeof(Page1)
                },
                new ItemMenu
                {
                    Texto = "Página 2",
                    Type = typeof(Page2)
                },
                new ItemMenu
                {
                    Texto = "Página 3",
                    Type = typeof(Page3)
                },
                new ItemMenu
                {
                    Texto = "Carrossel",
                    Type = typeof(Carrossel),
                    Carrossel = true
                }
            };
        }
    }
}