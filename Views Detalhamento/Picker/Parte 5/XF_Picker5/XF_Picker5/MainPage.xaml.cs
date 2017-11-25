using System.Collections.Generic;
using Xamarin.Forms;

namespace XF_Picker5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var vm = new ViewModel
            {
                Elementos = new List<Elemento>
                {
                    new Elemento {ValorReal = 123, ValorVisual = "Elemento 1"},
                    new Elemento {ValorReal = 456, ValorVisual = "Elemento 2"},
                    new Elemento {ValorReal = 789, ValorVisual = "Elemento 3"}
                }
            };
            
            BindingContext = vm;
        }
    }
}
