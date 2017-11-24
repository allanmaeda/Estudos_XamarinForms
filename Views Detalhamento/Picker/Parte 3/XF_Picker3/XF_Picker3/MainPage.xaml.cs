using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_Picker3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Picker.ItemsSource = new List<Elemento>
            {
                new Elemento { ValorReal = 5, ValorVisual = "Elemento 1"},
                new Elemento { ValorReal = 14, ValorVisual = "Elemento 2"},
                new Elemento { ValorReal = -2, ValorVisual = "Elemento 3"},
                new Elemento { ValorReal = 8, ValorVisual = "Elemento 4"}
            };
        }

        private async void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var el = (Elemento) Picker.SelectedItem;
            await DisplayAlert("Atenção", $"Elemento selecionado foi {el.ValorReal}", "Ok");
        }
    }
}
