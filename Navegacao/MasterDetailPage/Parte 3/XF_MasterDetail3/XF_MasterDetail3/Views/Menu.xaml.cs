using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MasterDetail3.Models;

namespace XF_MasterDetail3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public ListView PublicListView => PrivateListView;

        public Menu()
        {
            InitializeComponent();
            PrivateListView.ItemsSource = new List<ItemMenu>
            {
                new ItemMenu {Texto = "Ir para detalhe 1", Type = typeof(Detalhe1)},
                new ItemMenu {Texto = "ir para detalhe 2", Type = typeof(Detalhe2)}
            };
        }
    }
}