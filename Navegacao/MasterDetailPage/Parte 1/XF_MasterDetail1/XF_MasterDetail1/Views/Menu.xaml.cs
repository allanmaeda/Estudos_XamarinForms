using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MasterDetail1.Models;

namespace XF_MasterDetail1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();

            ListView.ItemsSource = new List<ItemMenu>
            {
                new ItemMenu {Texto = "Opção 1"},
                new ItemMenu { Texto = "Opção 2"},
                new ItemMenu { Texto = "Opção 3"},
            };
        }
    }
}