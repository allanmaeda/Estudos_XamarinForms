using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MasterDetail2.Model;

namespace XF_MasterDetail2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public ListView ListView => PrivateListView;

        public Menu()
        {
            InitializeComponent();

            PrivateListView.ItemsSource = new List<ItemMenu>
            {
                new ItemMenu { Texto = "Detalhe 1" },
                new ItemMenu { Texto = "Detalhe 2" },
                new ItemMenu { Texto = "Detalhe 3" }
            };
        }
    }
}